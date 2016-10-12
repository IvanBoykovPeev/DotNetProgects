﻿using System;
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
            con.StateChange += new StateChangeEventHandler(ConnStateChanche);
            con.InfoMessage += new SqlInfoMessageEventHandler(InfoMessage);

            string qurryString = "SELECT Name, Price FROM dbo.Products";

            
            using (con)
            {
                SqlCommand command = new SqlCommand(qurryString, con);

                try
                {
                    //Open the conection
                    con.Open();
                    Console.WriteLine("--------------------------");

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} - {1}", reader[0], reader[1]);
                    }
                    reader.Close();
                    Console.WriteLine("--------------------------");
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                con.Close();
            }            
        }

        private static void InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(e.Errors);
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Source);
        }

        private static void ConnStateChanche(object sender, StateChangeEventArgs e)
        {
            //Console.WriteLine(e.OriginalState);
            Console.WriteLine(e.CurrentState);
        }
    }
}
