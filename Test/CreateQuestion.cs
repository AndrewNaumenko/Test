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
    public partial class CreateQuestion : Form
    {
        private DataBaseConnection db;
        private List<string> request;
        private int key;
        private int keyTest;
        private int keyQuestion;
        //private CreateTest CTest;

        public CreateQuestion()
        {
            InitializeComponent();
            db = new DataBaseConnection();
            cbTemplate.SelectedIndex = 0;
            cbScore.SelectedIndex = 0;
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTemplate.Text=="Написать ответ")
            {
                lWrongAnswers.Visible = false;
                tbWrong1.Visible = false;
                tbWrong2.Visible = false;
                tbWrong3.Visible = false;
            }
            else
            {
                lWrongAnswers.Visible = true;
                tbWrong1.Visible = true;
                tbWrong2.Visible = true;
                tbWrong3.Visible = true;
            } 
        }

        private void bCreateQuestion_Click(object sender, EventArgs e)
        {
         /*   db.insertRequest("insert into Неправильный_ответ (неправильный_ответ) values ('" + tbWrong1.Text + "')");
            request = new List<string>();
            request = db.severalSelectRequest("Select id From Неправильный_ответ Where неправильный_ответ ='" + tbWrong1.Text + "'");
            key = Convert.ToInt16(request[0]);
            db.insertRequest("insert into Неправильные_ответы (id_неправильные_ответы) values ('" + key + "')");
            


            db.insertRequest("insert into Неправильный_ответ (неправильный_ответ) values ('" + tbWrong2.Text + "')");
            db.insertRequest("insert into Неправильный_ответ (неправильный_ответ) values ('" + tbWrong3.Text + "')");*/
           // try 
           // { 
            if (tbQuestion.Text != "" && tbRightAnswer.Text != "")
            {

            //string q = CreateTest.testName;

            request = new List<string>();
            request = db.severalSelectRequest("Select id From Тип_вопроса Where тип_вопроса ='" + cbTemplate.Text + "'");
            key = Convert.ToInt16(request[0]);
            db.insertRequest("insert into Вопрос (вопрос,ответ_правильный,id_типа_вопроса,балл) values ('" + tbQuestion.Text + "','" + tbRightAnswer.Text + "','" + key + "','" + cbScore.Text + "')");
            request = new List<string>();
            request = db.severalSelectRequest("Select id From Тест Where название ='" + CreateTest.testName + "'");
            keyTest = Convert.ToInt16(request[0]);

            request = new List<string>();
            request = db.severalSelectRequest("Select Вопрос.id From Вопрос Where Вопрос.вопрос = '" + tbQuestion.Text + "' and Вопрос.ответ_правильный = '" + tbRightAnswer.Text + "' ");
            keyQuestion = Convert.ToInt16(request[0]);

            db.insertRequest("insert into Вопросы (id_тест,id_вопрос) values ('" + keyTest + "','" + keyQuestion + "')");

            if (cbTemplate.Text != "Написать ответ")
            {
                wrongAnswer(tbWrong1.Text);
                wrongAnswer(tbWrong2.Text);
                wrongAnswer(tbWrong3.Text);
            }

            MessageBox.Show("Вопрос успешно создан");
           /* db.insertRequest("insert into Неправильный_ответ (неправильный_ответ) values ('" + tbWrong1.Text + "')");
            request = new List<string>();
            request = db.severalSelectRequest("Select id From Неправильный_ответ Where неправильный_ответ ='" + tbWrong1.Text + "'");
            key = Convert.ToInt16(request[0]);
            request = new List<string>();
            request = db.severalSelectRequest("Select Вопрос.id From Вопрос, Вопросы, Тест Where Тест.название = '" + CTest.testName + "' and Тест.id = Вопросы.id_тест and Вопросы.id_вопрос = Вопрос.and Тест.id");
            keyTest = Convert.ToInt16(request[0]);
            db.insertRequest("insert into Неправильные_ответы (id_вопроса,id_неправильные_ответы) values ('" + keyTest + "','" + key + "')");

            db.insertRequest("insert into Неправильный_ответ (неправильный_ответ) values ('" + tbWrong2.Text + "')");
            request = new List<string>();
            request = db.severalSelectRequest("Select id From Неправильный_ответ Where неправильный_ответ ='" + tbWrong2.Text + "'");
            key = Convert.ToInt16(request[0]);
            db.insertRequest("insert into Неправильные_ответы (id_вопроса,id_неправильные_ответы) values ('" + keyTest + "','" + key + "')");

            db.insertRequest("insert into Неправильный_ответ (неправильный_ответ) values ('" + tbWrong3.Text + "')");
            request = new List<string>();
            request = db.severalSelectRequest("Select id From Неправильный_ответ Where неправильный_ответ ='" + tbWrong3.Text + "'");
            key = Convert.ToInt16(request[0]);
            db.insertRequest("insert into Неправильные_ответы (id_вопроса,id_неправильные_ответы) values ('" + keyTest + "','" + key + "')");*/
            
            }
          /*  }
            catch
            {
                MessageBox.Show("Не все поля были заполнены");
            }*/
        }

        private void wrongAnswer(string answer)
        {
           // try
           // {
            db.insertRequest("insert into Неправильный_ответ (неправильный_ответ) values ('" + answer + "')");
            request = new List<string>();
            request = db.severalSelectRequest("Select id From Неправильный_ответ Where неправильный_ответ ='" + answer + "'");
            key = Convert.ToInt16(request[0]);
            db.insertRequest("insert into Неправильные_ответы (id_вопроса,id_неправильные_ответы) values ('" + keyQuestion + "','" + key + "')");
           /* }
             catch
             {
                 MessageBox.Show("Не все поля были заполнены");
             }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // testCreatingEnd();
            MessageBox.Show("Тест успешно создан");
            this.Close();
        }

        private void testCreatingEnd()
        {
            MessageBox.Show("Тест успешно создан");
            this.Close();
        }
    }
}
