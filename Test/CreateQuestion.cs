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
        private string type;
        private DataBaseConnection db;
        private int key;
        private int keyTest;
        private int keyQuestion;
        private List<string> request;
        private string rightAnswer;

        public CreateQuestion(Boolean edit,string type)
        {
            InitializeComponent();
            this.type = type;
            db = new DataBaseConnection();
            cbTemplate.SelectedIndex = 0;
            cbScore.SelectedIndex = 0;
            if (edit==true)
            {
                bSave.Visible = true;
                bCreateQuestion.Visible = false;
                button1.Visible = false;
                lTemplate.Visible = false;
                cbTemplate.Visible = false;
                switch (type)
                {
                    case "Написать ответ":
                        {
                            lWrongAnswers.Visible = false;
                            tbWrong1.Visible = false;
                            tbWrong2.Visible = false;
                            tbWrong3.Visible = false;
                            break;
                        }
                    case "Выбрать один из вариантов ответов":
                        {
                          //  CreateQuestion CQuestion = new CreateQuestion(true, "Выбрать один из вариантов ответов");
                          //  CQuestion.Owner = this;
                           // CQuestion.ShowDialog();
                            request = new List<string>();
                            request = db.severalSelectRequest("Select DISTINCT неправильный_ответ From Неправильный_ответ,Неправильные_ответы,Вопрос,Вопросы,Тест Where Вопрос.id =" + DataBase.keyQuetion + " and Вопрос.id = Неправильные_ответы.id_вопроса and Неправильные_ответы.id_неправильные_ответы = Неправильный_ответ.id");
                            request.Add(rightAnswer);
                            tbWrong1.Text = request[0];
                            tbWrong2.Text = request[1];
                            tbWrong3.Text = request[2];
                            tbWrong1.Visible = true;
                            tbWrong2.Visible = true;
                            tbWrong3.Visible = true;
                            break;
                        }
                }
                tbQuestion.Text = db.returnValue("Select вопрос From Вопрос Where id =" + DataBase.keyQuetion + "");
                tbRightAnswer.Text = db.returnValue("Select ответ_правильный From Вопрос Where id =" + DataBase.keyQuetion + "");
                cbScore.Text = (db.returnValue("Select балл From Вопрос Where id =" + DataBase.keyQuetion + ""));

            }
            if (edit == false)
            {
                bSave.Visible = false;
                bCreateQuestion.Visible =  true;
                button1.Visible = true;
                lTemplate.Visible = true;
                cbTemplate.Visible = true;
            }
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTemplate.Text == "Написать ответ")
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
            try
            {
                if (tbQuestion.Text != "" && tbRightAnswer.Text != "")
                {
                    key = Convert.ToInt16(db.returnValue("Select id From Тип_вопроса Where тип_вопроса ='" + cbTemplate.Text + "'"));
                    db.Request("insert into Вопрос (вопрос,ответ_правильный,id_типа_вопроса,балл) values ('" + tbQuestion.Text + "','" + tbRightAnswer.Text + "','" + key + "','" + cbScore.Text + "')");
                    keyTest = Convert.ToInt16(db.returnValue("Select id From Тест Where название ='" + CreateTest.testName + "'"));
                    keyQuestion = Convert.ToInt16(db.returnValue("Select Вопрос.id From Вопрос Where Вопрос.вопрос = '" + tbQuestion.Text + "' and Вопрос.ответ_правильный = '" + tbRightAnswer.Text + "' "));
                    db.Request("insert into Вопросы (id_тест,id_вопрос) values ('" + keyTest + "','" + keyQuestion + "')");
                    if (cbTemplate.Text != "Написать ответ")
                    {
                        wrongAnswer(tbWrong1.Text);
                        wrongAnswer(tbWrong2.Text);
                        wrongAnswer(tbWrong3.Text);
                    }
                    MessageBox.Show("Вопрос успешно создан");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void wrongAnswer(string answer)
        {
            try
            {
                db.Request("insert into Неправильный_ответ (неправильный_ответ) values ('" + answer + "')");
                key = Convert.ToInt16(db.returnValue("Select id From Неправильный_ответ Where неправильный_ответ ='" + answer + "'"));
                db.Request("insert into Неправильные_ответы (id_вопроса,id_неправильные_ответы) values ('" + keyQuestion + "','" + key + "')");
            }
            catch
            {
                MessageBox.Show("Не все поля были заполнены");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тест успешно создан");
            this.Close();
        }

        private void testCreatingEnd()
        {
            MessageBox.Show("Тест успешно создан");
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            db.Request("Update Вопрос Set вопрос = '" + tbQuestion.Text + "' Where id = " + DataBase.keyQuetion + "");
            db.Request("Update Вопрос Set ответ_правильный = '" + tbRightAnswer.Text + "' Where id = " + DataBase.keyQuetion + "");
            db.Request("Update Вопрос Set балл = '" + cbScore.Text + "' Where id = " + DataBase.keyQuetion + "");
            if (type == "Выбрать один из вариантов ответов")
            {
                db.Request("Update Неправильный_ответ Set неправильный_ответ = '" + tbWrong1.Text + "' Where неправильный_ответ = '" + request[0] + "'");
                db.Request("Update Неправильный_ответ Set неправильный_ответ = '" + tbWrong2.Text + "' Where неправильный_ответ = '" + request[1] + "'");
                db.Request("Update Неправильный_ответ Set неправильный_ответ = '" + tbWrong3.Text + "' Where неправильный_ответ = '" + request[2] + "'");
                
            }
            this.Close();
            
        }
    }
}
