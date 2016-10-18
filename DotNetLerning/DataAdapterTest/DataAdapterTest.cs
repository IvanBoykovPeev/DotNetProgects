using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterTest
{
    class DataAdapterTest
    {
        static void Main()
        {
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsStore;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            string strCon = @"Data Source=(localdb)\MSSQLLocalDB;" + "Integrated Security=true;DataBase=SportsStore";
            SqlConnection cnSportStore = new SqlConnection(strCon);

            //Create and populate with data the table for the example
            CreateTestTable(cnSportStore);
            PopulateTestTable(cnSportStore);

            string strSelect = "SELECT Id, Name FROM TestTable";

            //Create an adapter and generateits commands
            //with a CommandBuilder
            SqlDataAdapter daAdapter = new SqlDataAdapter(strSelect, cnSportStore);
            SqlCommandBuilder cbBuilder = new SqlCommandBuilder();
            cbBuilder.DataAdapter = daAdapter;

            //Add an event handler for the RowUpdat edevent
            daAdapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

            //Create and fill a DataSet
            DataSet dsSportStore = new DataSet();
            daAdapter.Fill(dsSportStore, "TestTable");

            Console.WriteLine("Initial table content from the DB:");
            PrintTableTestTable(dsSportStore);

            //Add some data to the DataSet
            MakeChanges(dsSportStore);

            Console.WriteLine("Table after adding some records:");
            PrintTableTestTable(dsSportStore);

            Console.WriteLine("Trying to update the table...");
            daAdapter.Update(dsSportStore, "TestTable");

            //Check if there were conflicts and if so, resolve them
            //and call Update(...) again. This time there should be
            //no conflict, because the conflicting rows are deleted
            //from DataSet
            if (dsSportStore.HasErrors)
            {
                Console.WriteLine("There were conflict!");
                ResolveErrorsInTableTestTable(dsSportStore);

                Console.WriteLine("Trying to update the table again...");
                daAdapter.Update(dsSportStore, "TestTable");
                if (dsSportStore.HasErrors)
                {
                    Console.WriteLine("Errors during update!");
                }
                else
                {
                    Console.WriteLine("No errors during update.");
                }
            }

            //Fill the DataSet with up-to-date data
            daAdapter.Fill(dsSportStore);
            Console.WriteLine("The table content from the database:");
            PrintTableTestTable(dsSportStore);

            //Drop the sample table
            DropTableTestTable(cnSportStore);
        }

        

        //Add some rows to the DataSet
        private static void MakeChanges(DataSet aDataSet)
        {
            //This row will cause a conflict - it has value
            //1 for the field, but such value is already
            //present in the table, and Id is primary key
            DataRow row = aDataSet.Tables["TestTable"].NewRow();
            row["Id"] = 1;
            row["Name"] = "Sasho";
            aDataSet.Tables["TestTable"].Rows.Add(row);

            //Add some non-conflict rows
            row = aDataSet.Tables["TestTable"].NewRow();
            row["Id"] = 4;
            row["Name"] = "Tosho";
            aDataSet.Tables["TestTable"].Rows.Add(row);
        }

        //RowUpdate event handler
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs aEventArgs)
        {
            //Check the Statusproperty of the SqlRowEventArgs
            //argument for indication for errors
            if (aEventArgs.Status == UpdateStatus.ErrorsOccurred)
            {
                //Conflict found. Set error for the updated row
                string errorMessage = string.Format("\nRow \" {0} {1}\"" + " conflicts with some row in the database:\n{2}\n", aEventArgs.Row["Id"], aEventArgs.Row["Name"], aEventArgs.Errors.Message);
                aEventArgs.Row.SetColumnError("Id", errorMessage);

                //Set the Status property to Coontinue so that the
                //Update(...) method continues with the other rows
                aEventArgs.Status = UpdateStatus.Continue;
            }
        }

        //Resolve the conflict for the rows that have errors
        private static void ResolveErrorsInTableTestTable(DataSet aDataSet)
        {
            DataTable testTable = aDataSet.Tables["TestTable"];
            DataRow[] conflictRows = testTable.GetErrors();
            foreach (DataRow row in conflictRows)
            {
                DataColumn[] conflictColums = row.GetColumnsInError();
                foreach (DataColumn column in conflictColums)
                {
                    string errorMessage = row.GetColumnError(column);
                    Console.WriteLine(errorMessage);
                }

                //Resolve the conflict by deleting the conflicting row
                row.Delete();
                row.ClearErrors();
            }
        }

        //Prints the data from the DataSet on the console
        private static void PrintTableTestTable(DataSet aDataSet)
        {
            Console.WriteLine("ID Name");
            foreach (DataRow row in aDataSet.Tables["TestTable"].Rows)
            {
                Console.WriteLine("{0} {1}", row["Id"], row["Name"]);
            }
            Console.WriteLine();
        }


        //Create the table, used in the example        
        private static void CreateTestTable(SqlConnection aConnection)
        {
            try
            {
                aConnection.Open();
                string strCreate = "CREATE TABLE TestTable" + "(Id int primary key, Name nvarchar(15))";
                SqlCommand cmdCreate = new SqlCommand(strCreate, aConnection);
                cmdCreate.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }
            finally
            {
                aConnection.Close();
            }
        }

        //Populates the created table the with some sample data
        private static void PopulateTestTable(SqlConnection aConnection)
        {
            try
            {
                aConnection.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = aConnection;

                cmdInsert.CommandText = "INSERT INTO TestTable" + " VALUES(1, 'Ivan')";
                cmdInsert.ExecuteNonQuery();
                cmdInsert.CommandText = "INSERT INTO TestTable" + " VALUES(2, 'Pesho')";
                cmdInsert.ExecuteNonQuery();
                cmdInsert.CommandText = "INSERT INTO TestTable" + " VALUES(3, 'Gosho')";
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {

                Console.WriteLine(sqlEx.Message);
            }
            finally
            {
                aConnection.Close();
            }
        }
        

        //Drop the table at the end of example
        private static void DropTableTestTable(SqlConnection aConnection)
        {
            try
            {
                aConnection.Open();
                string strDropTable = "DROP TABLE TestTable";
                SqlCommand cmdDropTable = new SqlCommand(strDropTable, aConnection);
                cmdDropTable.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }
            finally
            {
                aConnection.Close();
            }
        }
    }
}
