using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectWithDataBase
{
    class ConnectWithDataBase
    {
        const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsStore;" + "Integrated Security=True;";

        static void Main()
        {
            //Create the conection
            SqlConnection con = new SqlConnection(CONNECTION_STRING);

            string qurryString = "SELECT Name, Price, Description FROM dbo.Products";

            
            using (con)
            {
                SqlCommand command = new SqlCommand(qurryString, con);
                //Open the conection
                con.Open();                
                try
                {
                    Console.WriteLine("--------------------------");
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} - {1} - {2}", reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                    Console.WriteLine("--------------------------");                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //Close the colection
                    con.Close();
                }                
            }            
        }
    }
}
