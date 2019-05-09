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
    public partial class TeplateFewChoose : Form
    {
        private List<string> questionKeyList;
        private DataBaseConnection db;
        private List<string> request;
        private string rightAnswer;
        private int score;

        public TeplateFewChoose()
        {
            InitializeComponent();
            db = new DataBaseConnection();
            request = new List<string>();
            request = db.severalSelectRequest("Select вопрос From Вопрос Where id =" + ChooseTest.keyQuetion + "");
            // key = Convert.ToInt16(request[0]);
            tbQuestion.Text = request[0];

            request = new List<string>();
            request = db.severalSelectRequest("Select ответ_правильный From Вопрос Where id =" + ChooseTest.keyQuetion + "");
            rightAnswer = request[0];

            request = new List<string>();
            request = db.severalSelectRequest("Select балл From Вопрос Where id =" + ChooseTest.keyQuetion + "");
            score = Convert.ToInt16(request[0]);
        }

        private void bAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
