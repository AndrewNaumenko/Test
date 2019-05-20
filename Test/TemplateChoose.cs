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
    public partial class TemplateChoose : Form
    {
        private DataBaseConnection db;
        private List<string> request;
        private string rightAnswer;
        private int score;

        public TemplateChoose()
        {
            InitializeComponent();
            db = new DataBaseConnection();
            tbQuestion.Text = db.returnValue("Select вопрос From Вопрос Where id =" + ChooseTest.keyQuetion + "");
            rightAnswer = db.returnValue("Select ответ_правильный From Вопрос Where id =" + ChooseTest.keyQuetion + "");
            score = Convert.ToInt16(db.returnValue("Select балл From Вопрос Where id =" + ChooseTest.keyQuetion + ""));
            request = new List<string>();
            request = db.severalSelectRequest("Select DISTINCT неправильный_ответ From Неправильный_ответ,Неправильные_ответы,Вопрос,Вопросы,Тест Where Вопрос.id =" + ChooseTest.keyQuetion + " and Вопрос.id = Неправильные_ответы.id_вопроса and Неправильные_ответы.id_неправильные_ответы = Неправильный_ответ.id");
            request.Add(rightAnswer);
            Random rnd = new Random();
            List<int> rndnum = new List<int>();
            int r = rnd.Next(1, 5);
            rndnum.Add(r);
            for (int i = 0; i < 3; )
            {
                r = rnd.Next(1, 5);
                for (int j = 0; j < rndnum.Count(); j++)
                {
                    if (rndnum[j] == r)
                    {
                        break;
                    }
                    else if (j == rndnum.Count() - 1)
                    {
                        rndnum.Add(r);
                        i++;
                        break;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                switch (rndnum[i])
                {
                    case 1:
                        {
                            radioButton1.Text = request[i];
                            break;
                        }
                    case 2:
                        {
                            radioButton2.Text = request[i];
                            break;
                        }
                    case 3:
                        {
                            radioButton3.Text = request[i];
                            break;
                        }
                    case 4:
                        {
                            radioButton4.Text = request[i];
                            break;
                        }
                }

            }
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (radioButton1.Text == rightAnswer && radioButton1.Checked)
            {
                ChooseTest.countRightAnswers++;
                ChooseTest.result += score;
            }
            else if (radioButton2.Text == rightAnswer && radioButton2.Checked)
            {
                ChooseTest.countRightAnswers++;
                ChooseTest.result += score;
            }
            else if (radioButton3.Text == rightAnswer && radioButton3.Checked)
            {
                ChooseTest.countRightAnswers++;
                ChooseTest.result += score;
            }
            else if (radioButton4.Text == rightAnswer && radioButton4.Checked)
            {
                ChooseTest.countRightAnswers++;
                ChooseTest.result += score;
            }
            else
            {
                ChooseTest.countWrongAnswers++;
            }

            this.Close();
        }
    }
}
