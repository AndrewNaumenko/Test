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
        //private List<string> user;
        private string text;
        private string [] user;
        private string testName;
        private int keyUser;
        private int key;

        public DataBase()
        {
            InitializeComponent();
            db = new DataBaseConnection();
        }

        private void rbUser_CheckedChanged(object sender, EventArgs e)
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

        private void rbTest_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            request = new List<string>();
            request = db.severalSelectRequest("Select название From Тест");
            for (int i = 0; i < request.Count; i++)
            listBox1.Items.Add(request[i]);
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (rbUser.Checked)
            {
                listBox2.Items.Clear();

                request = new List<string>();
               // request = db.severalSelectRequest("Select количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста From Тест");
              // text = listBox1.SelectedItem.ToString();
               user = listBox1.SelectedItem.ToString().Split(new char[] { ' ' });

                request = db.severalSelectRequest("Select название From Тест,Пользователь,Пользователи Where имя = '" + user[0] + "' and фамилия= '" + user [1] + "' and  отчество= '" + user [2] + "' and Пользователь.id = Пользователи.id_пользователя and id_теста = Тест.id");
                for (int i = 0; i < request.Count; i++)
                    listBox2.Items.Add(request[i]);

            }
            if (rbTest.Checked)
            {
                listBox2.Items.Clear();

                request2 = new List<List<string>>();
               // request = new List<string>();
               // request = db.severalSelectRequest("Select имя,фамилия,отчество From Пользователи,Пользователь,Тест Where Пользователь.id = Пользователи.id_пользователя and Пользователи id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");

                request2 = db.severalListSelectRequest("Select имя,фамилия,отчество From Пользователи,Пользователь,Тест Where Пользователь.id = Пользователи.id_пользователя and Пользователи.id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");
                for (int i = 0; i < request2.Count; i++)
                {
                    text = request2[i][0] + ' ' + request2[i][1] + ' ' + request2[i][2];
                    listBox2.Items.Add(text);
                }
               // for (int i = 0; i < request.Count; i++)
                //    listBox2.Items.Add(request[i]);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            request = new List<string>();
            if (rbTest.Checked)
            {
               // user = listBox2.SelectedItem.ToString().Split(new char[] { ' ' });
                testName = listBox1.SelectedItem.ToString();

               /* request = new List<string>();
                request = db.severalSelectRequest("Select имя,фамилия,отчество From Пользователи,Пользователь,Тест Where Пользователь.id = Пользователи.id_пользователя and Пользователи.id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");
                for (int i = 0; i < request.Count; i++)
                    listBox2.Items.Add(request[i]);*/
                user = listBox2.SelectedItem.ToString().Split(new char[] { ' ' });

               /* request = new List<string>();
                request = db.severalSelectRequest("Select имя,фамилия,отчество From Пользователи Where Пользователь.id = Пользователи.id_пользователя and Пользователи id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");
                for (int i = 0; i < request.Count; i++)
                    listBox2.Items.Add(request[i]);*/
            }

            if (rbUser.Checked)
            {
              //  user = listBox1.SelectedItem.ToString().Split(new char[] { ' ' });
                testName = listBox2.SelectedItem.ToString();

                /*request = new List<string>();
                request = db.severalSelectRequest("Select имя,фамилия,отчество From Пользователи,Пользователь,Тест Where Пользователь.id = Пользователи.id_пользователя and Пользователи.id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");
                for (int i = 0; i < request.Count; i++)
                    listBox2.Items.Add(request[i]);*/
                user = listBox1.SelectedItem.ToString().Split(new char[] { ' ' });
            }


           /* request = new List<string>();
            request = db.severalSelectRequest("Select имя,фамилия,отчество From Пользователи Where Пользователь.id = Пользователи.id_пользователя and Пользователи id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");
            for (int i = 0; i < request.Count; i++)
                listBox2.Items.Add(request[i]);*/

               // request = new List<string>();
                // request = db.severalSelectRequest("Select количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста From Тест");
                // text = listBox1.SelectedItem.ToString();
             //   user = listBox1.SelectedItem.ToString().Split(new char[] { ' ' });




               // не работает request = db.severalSelectRequest("Select количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста From Тест,Пользователь,Пользователи,Результаты,Результат Where Тест.название = '" + listBox2.SelectedItem.ToString() + "' and Тест.id = Пользователи.id_теста and Пользователи.id_пользователя = Пользователь.id and  имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "' and Пользователь.id_результат = Результаты.id_результата and Результаты.id_пользователя = Результат.id");
             //   request = db.severalSelectRequest("Select DISTINCT количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста From Тест,Пользователь,Пользователи,Результаты,Результат Where   имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "' and Результат.id = Результаты.id_результата and Результаты.id_пользователя = Пользователь.id");
            ////////tyutj

                request2 = new List<List<string>>();
               // request2 = db.severalListSelectRequest("Select имя,фамилия,отчество From Пользователь");
                if (rbTest.Checked) request2 = db.severalListSelectRequest2("Select DISTINCT количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста From Тест,Пользователь,Пользователи,Результаты,Результат Where   имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "' and Результат.id = Результаты.id_результата and Результаты.id_пользователя = Пользователь.id and Пользователь.id = Пользователи.id_пользователя and Пользователи.id_теста = Тест.id and Тест.название = '" + listBox1.SelectedItem.ToString() + "'");
                if (rbUser.Checked) request2 = db.severalListSelectRequest2("Select DISTINCT количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста From Тест,Пользователь,Пользователи,Результаты,Результат Where   имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "' and Результат.id = Результаты.id_результата and Результаты.id_пользователя = Пользователь.id and Пользователь.id = Пользователи.id_пользователя and Пользователи.id_теста = Тест.id and Тест.название = '" + listBox2.SelectedItem.ToString() + "'");

          //  for (int i = 0; i < request.Count; i++)
                   // listBox2.Items.Add(request[i]);
                lResulteRightAnswers.Text = request2[0][0];
                lResulteScores.Text = request2[0][1];
                lResulteTime.Text = request2[0][2];
                lResulteWrongAnswers.Text = request2[0][3];
                lResultDate.Text = request2[0][4];

        }

        
        private void bdelTest_Click(object sender, EventArgs e)
        {
           /* if (rbTest.Checked)
            {
                request = new List<string>();
                request = db.severalSelectRequest("Select Пользователь.id From Пользователь Where имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "'");
                keyUser = Convert.ToInt16(request[0]);

                db.DeleteRequest("delete from Пользователь Where id='" + keyUser + "'");
            }

            if (rbUser.Checked)
            {

            }*/

        }

        private void bdelUser_Click(object sender, EventArgs e)
        {
          //  if (rbTest.Checked)
           // {
                request = new List<string>();
                request = db.severalSelectRequest("Select Пользователь.id From Пользователь Where имя = '" + user[0] + "' and фамилия= '" + user[1] + "' and  отчество= '" + user[2] + "'");
                keyUser = Convert.ToInt16(request[0]);

               // keyUser = 1;
               // db.DeleteRequest("delete from Результат Where Результат.id = " + keyUser + "");
               
            // db.DeleteRequest("delete from Результат Where Результат.id = Результаты.id_результата and Результаты.id_пользователя=" + keyUser + "");
               

               // db.DeleteRequest("delete from Пользователь Where id='" + keyUser + "'");


            request = new List<string>();
            request = db.severalSelectRequest("Select Результат.id From Пользователь,Результат,Результаты,Пользователи Where  Результат.id = Результаты.id_результата and Результаты.id_пользователя = Пользователь.id and Пользователь.id=" + keyUser + "");
            key = Convert.ToInt16(request[0]);

            db.DeleteRequest("delete from Результат Where Результат.id = " + key + "");



                db.DeleteRequest("delete from Результаты Where Результаты.id_результата=" + key + "");

                db.DeleteRequest("delete from Пользователь Where Пользователь.id=" + keyUser + "");

                db.DeleteRequest("delete from Пользователи Where Пользователи.id_пользователя=" + keyUser + "");

           // }

           // if (rbUser.Checked)
           // {

           // }
        }
    }
}
