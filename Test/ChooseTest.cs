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
    public partial class ChooseTest : Form
    {
        public string testName;
        public string name;
        public string surname;
        public string fatherName;
        public int keyQuetion;
        private int key;
        private string type;

        private List<string> questionKeyList;
        private DataBaseConnection db;
        private List<string> request;

        public ChooseTest()
        {
            InitializeComponent();
            db = new DataBaseConnection();
            GetFromBDTopic();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            /*try
            {*/
            if (tbName.Text == "" || tbSurname.Text == "" || tbFathername.Text == "" || CBchooseTopic.Text == "" || lbTestName.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Не все поля были заполнены");
                }
                else
                {
                    testName = lbTestName.SelectedItem.ToString();
                    request = new List<string>();
                    request = db.severalSelectRequest("Select id From Тест Where название ='" + testName + "'");
                    key = Convert.ToInt16(request[0]);

                    //  db.insertRequest("insert into Пользователь (имя,фамилия,отчество) values ('" + tbCreateTopic.Text + "')");
                   
                    name = tbName.Text;
                    surname = tbSurname.Text;
                    fatherName = tbSurname.Text;



                    request = new List<string>();
                  //  request = db.severalSelectRequest("Select Вопрос.id From Тест,Вопрос,Вопросы Where Тест.название ='" + testName + "' and Тест.id = Вопросы.id_тест and Вопросы.id_вопрос = Вопрос.id");
                    request = db.severalSelectRequest("Select Вопрос.id From Тест,Вопрос,Вопросы Where Тест.id =" + key + " and Тест.id = Вопросы.id_тест and Вопросы.id_вопрос = Вопрос.id");
                   
                    string i1 = request[0];
                    string i2 = request[1];
                    string i3 = request[2];
                    questionKeyList = request;

                    for (int i = 0; i < questionKeyList.Count(); i++)
                    {
                        // keyQuetion = Convert.ToInt16(questionKeyList[0]);
                        keyQuetion = Convert.ToInt16(questionKeyList[i]);

                        request = new List<string>();
                        request = db.severalSelectRequest("Select тип_вопроса From Тип_вопроса,Вопрос Where вопрос.id =" + keyQuetion + " and Тип_вопроса.id = Вопрос.id_типа_вопроса");
                        type = request[0].ToString();

                        switch (type)
                        {
                            case "Написать ответ":
                                {
                                    TemplateWrite TWrite = new TemplateWrite();
                                    TWrite.Owner = this;
                                    TWrite.ShowDialog();
                                    break;
                                }
                            case "Выбрать один из вариантов ответов":
                                {
                                    TemplateChoose TChoose = new TemplateChoose();
                                    TChoose.Owner = this;
                                    TChoose.ShowDialog();
                                    break;
                                }
                            case "Выбрать один ответ":
                                {
                                    TemplateChoose TChoose = new TemplateChoose();
                                    TChoose.Owner = this;
                                    TChoose.ShowDialog();
                                    break;
                                }
                        }

                    }

                    Results Res = new Results();
                    Res.Owner = this;
                    Res.ShowDialog();
                }

            /* }
             catch
             {
                 MessageBox.Show("Не все поля были заполнены");
             }*/
        }

        private void CBchooseTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTestName.Items.Clear();
            request = new List<string>();
            request = db.severalSelectRequest("Select название From Тест,Тема Where тема='" + CBchooseTopic.Text + "'and  Тест.id_тема=Тема.id");
            for (int i = 0; i < request.Count(); i++)
            lbTestName.Items.Add(request[i].ToString());
        }

        private void GetFromBDTopic()
        {
            request = new List<string>();
            request = db.severalSelectRequest("Select тема From Тема");
            for (int i = 1; i < request.Count(); i++)
            CBchooseTopic.Items.Add(request[i].ToString());
        }
    }
}
