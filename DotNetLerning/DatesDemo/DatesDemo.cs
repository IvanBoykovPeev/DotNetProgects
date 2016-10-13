using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDemo
{
    class DatesDemo
    {
        const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = SportsStore; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static SqlConnection mDbCon;

        static void Main()
        {
            DatesDemo demo = new DatesDemo();
            demo.ConnectToSqlServer();


            demo.DisconnectFromSqlServer();
        }

        

        private void ConnectToSqlServer()
        {
            mDbCon = new SqlConnection(CONNECTION_STRING);
            mDbCon.Open();
            Console.WriteLine("Connected to database");
        }

        private void DisconnectFromSqlServer()
        {
            mDbCon.Close();
            Console.WriteLine("Disconnected from database");
        }
    }
}
