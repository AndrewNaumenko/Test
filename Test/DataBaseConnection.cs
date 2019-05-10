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

        public void DeleteRequest(string cmd)
        {
            connection.Open();
            command = new OleDbCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

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

        public void insertRequest(string cmd)
        {
            connection.Open();
            command = new OleDbCommand(cmd, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<List<string>> severalListSelectRequest(string cmd)
        {
            connection.Open();
            command = new OleDbCommand(cmd, connection);
            reader = command.ExecuteReader();
            List<List<string>> request = new List<List<string>>();
           // int i = 0;
           // while (reader.Read())
            for (int i = 0; reader.Read(); i++)
            {
                request.Add(new List<string>());
              //  string t = reader[0].ToString();
               // string t2 = reader[1].ToString();
                request[i].Add(reader[0].ToString());
                request[i].Add(reader[1].ToString());
                request[i].Add(reader[2].ToString());
                // i++;

            }
            connection.Close();
            return request;
        }

        public List<List<string>> severalListSelectRequest2(string cmd)
        {
            connection.Open();
            command = new OleDbCommand(cmd, connection);
            reader = command.ExecuteReader();
            List<List<string>> request = new List<List<string>>();
            // int i = 0;
            // while (reader.Read())
            for (int i = 0; reader.Read(); i++)
            {
                request.Add(new List<string>());
                //  string t = reader[0].ToString();
                // string t2 = reader[1].ToString();
                request[i].Add(reader[0].ToString());
                request[i].Add(reader[1].ToString());
                request[i].Add(reader[2].ToString());
                request[i].Add(reader[3].ToString());
                request[i].Add(reader[4].ToString());
                // i++;

            }
            connection.Close();
            return request;
        }
    }
}
