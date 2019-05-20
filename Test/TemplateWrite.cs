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
    public partial class TemplateWrite : Form
    {
        private DataBaseConnection db;
        private string rightAnswer;
        private int score;

        public TemplateWrite()
        {
            InitializeComponent();
            db = new DataBaseConnection();
            tbQuestion.Text =db.returnValue("Select вопрос From Вопрос Where id =" + ChooseTest.keyQuetion + "");
            rightAnswer =db.returnValue("Select ответ_правильный From Вопрос Where id =" + ChooseTest.keyQuetion + "");
            score = Convert.ToInt16(db.returnValue("Select балл From Вопрос Where id =" + ChooseTest.keyQuetion + ""));
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if (tbAnswer.Text == rightAnswer)
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
