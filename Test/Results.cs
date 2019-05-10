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
    public partial class Results : Form
    {
        private DataBaseConnection db;
        private List<string> request;
        private int keyResult;
        private int keyUser;

        public Results()
        {
            InitializeComponent();
            db = new DataBaseConnection();
            lResulteRightAnswers.Text =  Convert.ToString(ChooseTest.countRightAnswers);
            lResulteScores.Text =  Convert.ToString(ChooseTest.result);
            lResulteTime.Text = Convert.ToString(ChooseTest.min) + ':' + Convert.ToString(ChooseTest.sec);
            lResulteWrongAnswers.Text =  Convert.ToString(ChooseTest.countWrongAnswers);

            db.insertRequest("insert into Результат (количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста) values ('" + lResulteRightAnswers.Text + "','" + lResulteWrongAnswers.Text + "','" + lResulteTime.Text + "','" + lResulteScores.Text + "','" + DateTime.Now.ToLongDateString() + "')");

            request = new List<string>();
            //request = db.severalSelectRequest("Select id From Результат Where количество_правильных_ответов ='" + lResulteRightAnswers.Text + "', количество_неправильных_ответов ='" + lResulteWrongAnswers.Text + "',время_прохождения_теста ='" + lResulteTime.Text + "',оценка ='" + lResulteScores.Text + "',дата_прохождения_теста ='" + DateTime.Now.ToLongDateString() + "'");
           //SELECT MAX(id) FROM City
            request = db.severalSelectRequest("Select MAX(id) From Результат");
            keyResult = Convert.ToInt16(request[0]);

            db.insertRequest("insert into Пользователь (имя,фамилия,отчество) values ('" + ChooseTest.name + "','" + ChooseTest.surname + "','" + ChooseTest.fatherName + "')");

            request = new List<string>();
            request = db.severalSelectRequest("Select MAX(id) From Пользователь");
            keyUser = Convert.ToInt16(request[0]);

            db.insertRequest("insert into Результаты (id_результата,id_пользователя) values ('" + keyResult + "','" + keyUser  + "')");

            db.insertRequest("insert into Пользователи (id_теста,id_пользователя) values ('" + ChooseTest.keyTest + "','" + keyUser + "')");

        }

        private void Results_Load(object sender, EventArgs e)
        {

        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
