using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTransactions
{
    class TestTransactions
    {
        const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = SportsStore; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static void Main()
        {
            SqlConnection dbCon = new SqlConnection(CONNECTION_STRING);
            dbCon.Open();
            try
            {
                SqlTransaction trans = dbCon.BeginTransaction(IsolationLevel.ReadCommitted);
                Console.WriteLine("Transaction started.");

                SqlCommand cmd = dbCon.CreateCommand();
                cmd.Transaction = trans;
                try
                {
                    cmd.CommandText = "INSERT INTO Products(Name, Description, Category, Price)" + "VALUES('New Record', 'New Description', 'New Category', '20.00')";
                    int affectedRows = (int)cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted a new record.");

                    cmd.CommandText = "INSERT INTO Products(Name, Description, Category, Price)" + "VALUES('New Record1', 'New Description1', 'New Category1', '20.00')";
                    affectedRows += (int)cmd.ExecuteNonQuery();
                    Console.WriteLine("Inserted a new record.");

                    Console.WriteLine("Affected rows {0}.", affectedRows);

                    trans.Commit();
                    Console.WriteLine("Transaction comitted.");

                    

                    Console.WriteLine("------------------------------");
                    cmd.CommandText = "SELECT Name, Price, Description FROM dbo.Products";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} - {1} - {2}", reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                    Console.WriteLine("--------------------------");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Transaction cancelled.");
                }
            }            
            finally
            {
                dbCon.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
