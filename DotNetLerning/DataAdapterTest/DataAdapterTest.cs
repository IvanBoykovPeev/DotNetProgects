using System;
using System.Collections.Generic;
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

            

            CreateTable(cnSportStore);
            PopulatedTable(cnSportStore);
        }

        //Populates the created table the with some sample data
        private static void PopulatedTable(SqlConnection aConnection)
        {
            try
            {
                aConnection.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = aConnection;

                cmdInsert.CommandText = "INSERT INTO TestTable" + " VALUES(1 , 'Ivan')";
                cmdInsert.ExecuteNonQuery();
                cmdInsert.CommandText = "INSERT INTO TestTable" + " VALUES(2 , 'Pesho')";
                cmdInsert.ExecuteNonQuery();
                cmdInsert.CommandText = "INSERT INTO TestTable" + " VALUES(3 , 'Gosho')";
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {

                Console.WriteLine(sqlEx.Message);
            }
        }

        //Create the table, used in the example
        private static void CreateTable(SqlConnection aConnection)
        {
            try
            {
                aConnection.Open();
                string strCreate = "CREATE TABLE TestTable" + "(Id int primary key, Name nvarchar(15))";
                SqlCommand cmdCreate = new SqlCommand(strCreate, aConnection);
                cmdCreate.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
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
