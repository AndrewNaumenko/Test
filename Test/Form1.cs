using System;
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
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public static bool admin = false;
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            timer = new Timer() { Interval = 100 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void butChooseTest_Click(object sender, EventArgs e)
        {
            ChooseTest ChooseTest = new ChooseTest();
            ChooseTest.Owner = this;
            ChooseTest.ShowDialog();
        }

        private void butCreateTest_Click(object sender, EventArgs e)
        {
            CreateTest CreateTest = new CreateTest();
            CreateTest.Owner = this;
            CreateTest.ShowDialog();

           /* if (labAdminUser.Text == "Вы вошли как: Пользователь")
            {
                MessageBox.Show("Авторизируйтесь");
            }
            else
            {
                CreateTest CreateTest = new CreateTest();
                CreateTest.Owner = this;
                CreateTest.ShowDialog();
            }*/
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

        private void labAdminUser_TextChanged(object sender, EventArgs e)
        {
            if (labAdminUser.Text == "Вы вошли как: Пользователь")
            {
                lQuitAdmin.Visible = false;
            }
            else 
            {
                lQuitAdmin.Visible = true;
            }
        }

        private void lQuitAdmin_Click(object sender, EventArgs e)
        {
            admin = false;
        }

        void timer_Tick(object sender, EventArgs e)
        {

            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            
            if (admin == true)
            {
                labAdminUser.Text = "Вы вошли как: Администратор";
            }
            else
            {
                labAdminUser.Text = "Вы вошли как: Пользователь";
            }
        }

    }
}
