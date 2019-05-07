/*using System;
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
using System.Windows.Forms;*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class CreateTest : Form
    {
       /* private string connectionString;
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader reader;*/
        public  static string testName;
        private string topic;
        private int key;
        private DataBaseConnection db;
        private List<string> request;

        public CreateTest()
        {
            InitializeComponent();
            db = new DataBaseConnection();
          //  connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bdTest.accdb";
            //connection = new OleDbConnection(connectionString);
            GetFromBDTopic();
            CBchooseTopic.SelectedIndex = 0;
        }

        private void GetFromBDTopic()
        {
           /* connection.Open();
            command = new OleDbCommand("Select тема From Тема", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                CBchooseTopic.Items.Add(reader[0].ToString());
            }
            connection.Close();*/

            request = new List<string>();
            request = db.severalSelectRequest("Select тема From Тема");
            for (int i = 0; i < request.Count();i++)
            CBchooseTopic.Items.Add(request[i].ToString());
        }

        private void CBchooseTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBchooseTopic.Text=="Новая")
            {
                lCreateTopic.Visible = true;
                tbCreateTopic.Visible = true; 
            }
            else
            {
                lCreateTopic.Visible = false;
                tbCreateTopic.Visible = false;
            }
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
              if (tbNameTest.Text == "")
              {
                  MessageBox.Show("Введите название теста");
              }
              else
              {
                  if (CBchooseTopic.Text == "Новая")
                  {
                      db.insertRequest("insert into Тема (тема) values ('" + tbCreateTopic.Text + "')");
                      topic = tbCreateTopic.Text;
                  }
                  else
                  {
                      topic = CBchooseTopic.Text;
                  }
              }
              request = new List<string>();
              request = db.severalSelectRequest("Select id From Тема Where тема ='" + topic + "'");
              key = Convert.ToInt16(request[0]);
              testName = tbNameTest.Text;
              db.insertRequest("insert into Тест (название,id_тема) values ('" + tbNameTest.Text + "','" + key + "')");

            

            CreateQuestion CQuestion = new CreateQuestion();
            CQuestion.Owner = this;
            CQuestion.ShowDialog();

            this.Close();
            
            /*connection.Open();
            if (CBchooseTopic.Text == "Новая")
            {
                command = new OleDbCommand("insert into Тема (тема) values ('" + tbCreateTopic.Text + "')", connection);
                command.ExecuteNonQuery();
                topic = tbCreateTopic.Text;
            }
            else
            {
                topic = CBchooseTopic.SelectedIndex.ToString();
            }

            connection.Close();*/

        }
    }
}
