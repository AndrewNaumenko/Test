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
    public partial class DataBase : Form
    {
        private DataBaseConnection db;
        private List<string> request;
        private List<List<string>> request2;
        private string text;
        private string[] user;
        private string testName;
        private int keyUser;
        public static int keyTest;
        private List<string> keyQuestion;
        private List<string> keyWrongQuestion;
        private List<string> keyListUser;
        private List<string> keyResults;
        private List<string> questionKeyList;
        public static int keyQuetion;
        private string type;

        public DataBase()
        {
            InitializeComponent();
            db = new DataBaseConnection();
        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            usercb();
        }

        private void rbTest_CheckedChanged(object sender, EventArgs e)
        {
            testcb();
        }

        private void usercb()
        {
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                request2 = new List<List<string>>();
                request2 = db.severalListSelectRequest("Select имя,фамилия,отчество From Пользователь");
                for (int i = 0; i < request2.Count; i++)
                {
                    text = request2[i][0] + ' ' + request2[i][1] + ' ' + request2[i][2];
                    listBox1.Items.Add(text);
                }
            }
            catch
            {
                MessageBox.Show("Не найдено");
            }
        }

        private void testcb()
        {
            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                request = new List<string>();
                request = db.severalSelectRequest("Select название From Тест");
                for (int i = 0; i < request.Count; i++)
                    listBox1.Items.Add(request[i]);
            }
            catch
            {
                MessageBox.Show("Не найдено");
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbUser.Checked)
                {
                    listBox2.Items.Clear();
                    request = new List<string>();
                    user = listBox1.SelectedItem.ToString().Split(new char[] { ' ' });
                    request = db.severalSelectRequest("Select название From Тест,Пользователь,Пользователи Where имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "' and Пользователь.id = Пользователи.id_пользователя and id_теста = Тест.id");
                    for (int i = 0; i < request.Count; i++)
                        listBox2.Items.Add(request[i]);
                }
                if (rbTest.Checked)
                {
                    listBox2.Items.Clear();
                    request2 = new List<List<string>>();
                    request2 = db.severalListSelectRequest("Select имя,фамилия,отчество From Пользователи,Пользователь,Тест Where Пользователь.id = Пользователи.id_пользователя and Пользователи.id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");
                    for (int i = 0; i < request2.Count; i++)
                    {
                        text = request2[i][0] + ' ' + request2[i][1] + ' ' + request2[i][2];
                        listBox2.Items.Add(text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не найдено");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                request = new List<string>();
                if (rbTest.Checked)
                {
                    testName = listBox1.SelectedItem.ToString();
                    user = listBox2.SelectedItem.ToString().Split(new char[] { ' ' });
                }

                if (rbUser.Checked)
                {
                    testName = listBox2.SelectedItem.ToString();
                    user = listBox1.SelectedItem.ToString().Split(new char[] { ' ' });
                }
                request2 = new List<List<string>>();
                if (rbTest.Checked)
                    request2 = db.severalListSelectRequest2("Select DISTINCT количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста From Тест,Пользователь,Пользователи,Результаты,Результат Where   имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "' and Результат.id = Результаты.id_результата and Результаты.id_пользователя = Пользователь.id and Пользователь.id = Пользователи.id_пользователя and Пользователи.id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");
                    if (rbUser.Checked)
                request2 = db.severalListSelectRequest2("Select DISTINCT количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста From Тест,Пользователь,Пользователи,Результаты,Результат Where   имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "' and Результат.id = Результаты.id_результата and Результаты.id_пользователя = Пользователь.id and Пользователь.id = Пользователи.id_пользователя and Пользователи.id_теста = Тест.id and Тест.название = '" + listBox2.SelectedItem.ToString() + "'");

                    lResulteRightAnswers.Text = request2[0][0];
                    lResulteScores.Text = request2[0][3];
                    lResulteTime.Text = request2[0][2];
                    lResulteWrongAnswers.Text = request2[0][1];
                    lResultDate.Text = request2[0][4];
            }
            catch
            {
                MessageBox.Show("Не найдено");
            }
        }

        private void bdelTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbTest.Checked)
                {
                    testName = listBox1.SelectedItem.ToString();
                }
                if (rbUser.Checked)
                {
                    testName = listBox2.SelectedItem.ToString();
                }
                keyTest = Convert.ToInt16(db.returnValue("Select id From Тест Where название = '" + testName + "'"));
                keyQuestion = db.severalSelectRequest("Select Вопрос.id From Тест,Вопрос,Вопросы Where Тест.id = " + keyTest + " and Тест.id = Вопросы.id_тест and Вопросы.id_вопрос=Вопрос.id");
                for (int i = 0; i < keyQuestion.Count; i++)
                {
                    keyWrongQuestion = db.severalSelectRequest("Select DISTINCT Неправильный_ответ.id From Неправильный_ответ,Неправильные_ответы,Вопрос Where Неправильные_ответы.id_вопроса = " + keyQuestion[i] + " and  Неправильные_ответы.id_неправильные_ответы = Неправильный_ответ.id");
                    for (int j = 0; j < keyWrongQuestion.Count(); j++)
                    {
                        db.Request("delete from Неправильный_ответ Where id = " + keyWrongQuestion[j] + "");
                        db.Request("delete from Неправильные_ответы Where id_неправильные_ответы = " + keyWrongQuestion[j] + "");
                    }
                }

                for (int j = 0; j < keyQuestion.Count(); j++)
                {
                    db.Request("delete from Вопрос Where id = " + keyQuestion[j] + "");
                    db.Request("delete from Вопросы Where id_вопрос = " + keyQuestion[j] + "");
                }
                keyListUser = db.severalSelectRequest("Select Пользователи.id_пользователя From Тест,Пользователи Where Тест.id = " + keyTest + " and Тест.id = Пользователи.id_теста");

                for (int i = 0; i < keyListUser.Count(); i++)
                {
                    request = new List<string>();
                    request = db.severalSelectRequest("Select Результат.id From Результат,Результаты Where Результаты.id_пользователя = " + keyListUser[i] + " and Результаты.id_результата = Результат.id");
                    keyResults = request;

                    for (int j = 0; j < keyResults.Count(); j++)
                    {
                        db.Request("delete from Результат Where id = " + keyResults[j] + "");
                        db.Request("delete from Результаты Where id_результата = " + keyResults[j] + "");
                    }
                }

                for (int j = 0; j < keyListUser.Count(); j++)
                {
                    db.Request("delete from Пользователи Where id_пользователя = " + keyListUser[j] + " and id_теста = " + keyTest + "");
                }
                db.Request("delete from Тест Where id = " + keyTest + "");

                updatelist();

            }
            catch
            {
                MessageBox.Show("Не найдено");
            }
        }

        private void updatelist()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if (rbTest.Checked)
            {
                testcb();
            }
            if (rbUser.Checked)
            {
                usercb();
            }
        }

        private void bdelUser_Click(object sender, EventArgs e)
        {
            try
            {
                keyUser = Convert.ToInt16(db.returnValue("Select Пользователь.id From Пользователь Where имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "'"));
                keyResults = db.severalSelectRequest("Select Результат.id From Пользователь,Результат,Результаты,Пользователи Where  Результат.id = Результаты.id_результата and Результаты.id_пользователя = Пользователь.id and Пользователь.id=" + keyUser + "");

                for (int j = 0; j < keyResults.Count(); j++)
                {
                    db.Request("delete from Результат Where id = " + keyResults[j] + "");
                    db.Request("delete from Результаты Where id_результата = " + keyResults[j] + "");
                }
                db.Request("delete from Пользователь Where Пользователь.id=" + keyUser + "");
                db.Request("delete from Пользователи Where Пользователи.id_пользователя=" + keyUser + "");

                updatelist();

            }
            catch
            {
                MessageBox.Show("Не найдено");
            }

        }

        private void bEditTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbTest.Checked)
                {
                    testName = listBox1.SelectedItem.ToString();
                }
                if (rbUser.Checked)
                {
                    testName = listBox2.SelectedItem.ToString();
                }
                keyTest = Convert.ToInt16(db.returnValue("Select id From Тест Where название = '" + testName + "'"));
                questionKeyList = db.severalSelectRequest("Select Вопрос.id From Тест,Вопрос,Вопросы Where Тест.id =" + DataBase.keyTest + " and Тест.id = Вопросы.id_тест and Вопросы.id_вопрос = Вопрос.id");
                for (int i = 0; i < questionKeyList.Count(); i++)
                {
                    keyQuetion = Convert.ToInt16(questionKeyList[i]);
                    type = db.returnValue("Select тип_вопроса From Тип_вопроса,Вопрос Where вопрос.id =" + keyQuetion + " and Тип_вопроса.id = Вопрос.id_типа_вопроса");
                    switch (type)
                    {
                        case "Написать ответ":
                            {
                                CreateQuestion CQuestion = new CreateQuestion(true, "Написать ответ");
                                CQuestion.Owner = this;
                                CQuestion.ShowDialog();
                                break;
                            }
                        case "Выбрать один из вариантов ответов":
                            {
                                CreateQuestion CQuestion = new CreateQuestion(true, "Выбрать один из вариантов ответов");
                                CQuestion.Owner = this;
                                CQuestion.ShowDialog();
                                break;
                            }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не найдено");
            }
        }

    }

}
