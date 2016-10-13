using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
            demo.AddMessage("Test message 1", DateTime.Now);
            demo.AddMessage("Test message 2", DateTime.Now);
            demo.AddMessage("Test message 3", DateTime.Now);
            CultureInfo cultureBulgaria = new CultureInfo("bg-BG");
            demo.DisplayAllMessages(cultureBulgaria, "dd-MMMMMMM-yyyy HH:mm:ss");
            demo.DropMessageTable();
            demo.DisconnectFromSqlServer();
        }

        private void DisplayAllMessages(CultureInfo aCultureInfo, string aFormat)
        {
            SqlCommand cmdSelectMsgs = new SqlCommand("SELECT MsgText, MsgDate FROM Message", mDbCon);
            SqlDataReader reader = cmdSelectMsgs.ExecuteReader();
            using (reader)
            {
                
                while (reader.Read())
                {
                    string msgText = (string)reader["MsgText"];
                    DateTime msgDate = (DateTime)reader["MsgDate"];
                    string msgDateFormatted = msgDate.ToString(aFormat, aCultureInfo);
                    Console.WriteLine("{0} - {1}", msgDateFormatted, msgText);
                }
            }
        }

        private void AddMessage(string aMsgText, DateTime aMsgDate)
        {
            SqlCommand cmdInsertMsg = new SqlCommand(
                "INSERT INTO Message(MsgText, MsgDate) " +
                "VALUES (@MsgText, @MsgDate)", mDbCon);

            SqlParameter paramMsgText = new SqlParameter("@MsgText", SqlDbType.NVarChar);
            paramMsgText.Value = aMsgText;
            cmdInsertMsg.Parameters.Add(paramMsgText);

            SqlParameter paramMsgDate = new SqlParameter("@MsgDate", SqlDbType.DateTime);
            paramMsgDate.Value = aMsgDate;
            cmdInsertMsg.Parameters.Add(paramMsgDate);

            cmdInsertMsg.ExecuteNonQuery();

            Console.WriteLine("Inserted record in Messages table.");
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
                    MsgId int identity not null primary key,
                    MsgText nvarchar(1000),
                    MsgDate datetime
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
