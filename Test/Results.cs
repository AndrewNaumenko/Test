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
            ChooseTest.sec = ChooseTest.date1.Second;
            ChooseTest.min = ChooseTest.date1.Minute;
            lResulteRightAnswers.Text = Convert.ToString(ChooseTest.countRightAnswers);
            lResulteScores.Text = Convert.ToString(ChooseTest.result);
            lResulteTime.Text = Convert.ToString(ChooseTest.date1.Minute) + ':' + Convert.ToString(ChooseTest.date1.Second);
            lResulteWrongAnswers.Text = Convert.ToString(ChooseTest.countWrongAnswers);
            db.Request("insert into Результат (количество_правильных_ответов,количество_неправильных_ответов,время_прохождения_теста,оценка,дата_прохождения_теста) values ('" + lResulteRightAnswers.Text + "','" + lResulteWrongAnswers.Text + "','" + lResulteTime.Text + "','" + lResulteScores.Text + "','" + DateTime.Now.ToLongDateString() + "')");
            keyResult = Convert.ToInt16(db.returnValue("Select MAX(id) From Результат"));
            request = new List<string>();
            request = db.severalSelectRequest("Select Пользователь.id From Пользователь Where имя = '" + ChooseTest.name + "' and фамилия = '" + ChooseTest.surname + "' and отчество ='" + ChooseTest.fatherName + "' ");
            if (request.Count!=0)
            {
                keyUser = Convert.ToInt16(request[0]);
            }
            else
            {
                db.Request("insert into Пользователь (имя,фамилия,отчество) values ('" + ChooseTest.name + "','" + ChooseTest.surname + "','" + ChooseTest.fatherName + "')");
                keyUser = Convert.ToInt16(db.returnValue("Select MAX(id) From Пользователь"));
            }
            
            db.Request("insert into Результаты (id_результата,id_пользователя) values ('" + keyResult + "','" + keyUser + "')");
            db.Request("insert into Пользователи (id_теста,id_пользователя) values ('" + ChooseTest.keyTest + "','" + keyUser + "')");
            ChooseTest.countRightAnswers = 0;
            ChooseTest.countWrongAnswers = 0;
            ChooseTest.result = 0;
            ChooseTest.min = 0;
            ChooseTest.sec = 0;
            ChooseTest.date1 = new DateTime(0, 0);
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
