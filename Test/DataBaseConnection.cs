using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class DataBaseConnection
    {
        private string connectionString;
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader reader;

        public DataBaseConnection()
        {
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bdTest.accdb";
            connection = new OleDbConnection(connectionString);
        }

       /* public string selectRequest(string cmd)
        {
            connection.Open();
            command = new OleDbCommand(cmd, connection);
            reader = command.ExecuteReader();
            reader.Read();
            string request = reader[0].ToString();
            connection.Close();
            return request;
        }*/

        public List<string> severalSelectRequest(string cmd)
        {
            connection.Open();
            command = new OleDbCommand(cmd, connection);
            reader = command.ExecuteReader();
            List<string> request = new List<string>();
            while (reader.Read())
            {
                request.Add(reader[0].ToString());
            }
            connection.Close();
            return request;
        }
    }
}
