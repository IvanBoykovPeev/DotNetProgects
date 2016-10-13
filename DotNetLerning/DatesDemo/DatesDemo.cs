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
            demo.DropMessageTable();
            demo.CreateMessageTable();
            demo.DisconnectFromSqlServer();
        }

        private void DropMessageTable()
        {
            SqlCommand cmdDropMessageTable = new SqlCommand(
                @"IF OBJECT_ID('Message') IS NOT NULL
                  DROP TABLE Message", 
                mDbCon);
            cmdDropMessageTable.ExecuteNonQuery();
            Console.WriteLine("Table Messages deleted (if existed).");
        }

        private void CreateMessageTable()
        {
            SqlCommand cmdCreateMsgTable = new SqlCommand(
                @"CREATE TABLE Message
                (
                    MsgId int identity not null primary key
                )",
                mDbCon);
            cmdCreateMsgTable.ExecuteNonQuery();
            Console.WriteLine("Created table Messages.");
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
