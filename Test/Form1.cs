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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butChooseTest_Click(object sender, EventArgs e)
        {
            ChooseTest ChooseTest = new ChooseTest();
            ChooseTest.Owner = this;
            ChooseTest.ShowDialog();
        }

        private void butCreateTest_Click(object sender, EventArgs e)
        {
            if (labAdminUser.Text == "Вы вошли как: Пользователь")
            {
                MessageBox.Show("Авторизируйтесь");
            }
            else
            {
                CreateTest CreateTest = new CreateTest();
                CreateTest.Owner = this;
                CreateTest.ShowDialog();
            }
        }

        private void butDB_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.Owner = this;
            DB.ShowDialog();
        }

        private void labAdminUser_Click(object sender, EventArgs e)
        {
            SignIn SignIn = new SignIn();
            SignIn.Owner = this;
            SignIn.ShowDialog();
        }

    }
}
