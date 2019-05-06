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
    public partial class SignIn : Form
    {
        private string connectionString;
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader reader;

        public SignIn()
        {
            InitializeComponent();
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bdTest.accdb";
            connection = new OleDbConnection(connectionString);
        }

        public void GetFromBDLoginPassword()
        {
            connection.Open();
            command = new OleDbCommand("Select логин,пароль From Авторизация", connection);
            reader = command.ExecuteReader();
            reader.Read();
            connection.Close();
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (Form1.admin == true)
            {
                MessageBox.Show("Вы уже авторизировались"); 
            }
            else 
            {
                if ((tbLogin.Text == reader[0].ToString()) && (tbPassword.Text == reader[1].ToString()))
                {
                    MessageBox.Show("Вы успешно авторизировались");
                    Form1.admin = true;
                }
                else
                {
                    MessageBox.Show("Вы ввели неправильный логин или пароль");
                }
            }
           
        }
    }
}
