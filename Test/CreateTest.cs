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
        public static string testName;
        private string topic;
        private int key;
        private DataBaseConnection db;
        private List<string> request;

        public CreateTest()
        {
            InitializeComponent();
            db = new DataBaseConnection();
            GetFromBDTopic();
            CBchooseTopic.SelectedIndex = 0;
        }

        private void GetFromBDTopic()
        {
            try
            {
                request = new List<string>();
                request = db.severalSelectRequest("Select тема From Тема");
                for (int i = 0; i < request.Count(); i++)
                    CBchooseTopic.Items.Add(request[i].ToString());
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void CBchooseTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBchooseTopic.Text == "Новая")
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
            try
            {
                if (tbNameTest.Text == "")
                {
                    MessageBox.Show("Введите название теста");
                }
                else
                {
                    if (CBchooseTopic.Text == "Новая")
                    {
                        request = new List<string>();
                        request = db.severalSelectRequest("Select тема From Тема Where тема ='" + tbCreateTopic.Text + "'");
                        if (request.Count != 0)
                        {
                            topic = request[0];
                        }
                        else
                        {
                            db.Request("insert into Тема (тема) values ('" + tbCreateTopic.Text + "')");
                            topic = tbCreateTopic.Text;
                        }
                    }
                    else
                    {
                        topic = CBchooseTopic.Text;
                    }
                }
                key = Convert.ToInt16(db.returnValue("Select id From Тема Where тема ='" + topic + "'"));
                testName = tbNameTest.Text;
                request = new List<string>();
                request = db.severalSelectRequest("Select название From Тест Where название ='" + testName  + "'");
                if (request.Count != 0)
                {
                    MessageBox.Show("Данный тест уже есть");
                }
                else
                {
                    db.Request("insert into Тест (название,id_тема) values ('" + tbNameTest.Text + "','" + key + "')");
                    CreateQuestion CQuestion = new CreateQuestion(false,"");
                    CQuestion.Owner = this;
                    CQuestion.ShowDialog();
                    this.Close();
                }
               
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
