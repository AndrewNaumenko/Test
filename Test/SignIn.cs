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
    public partial class SignIn : Form
    {
        private string login;
        private string password;

        public SignIn()
        {
            InitializeComponent();
        }

        private void GetFromBDLoginPassword()
        {
            try
            {
                DataBaseConnection db = new DataBaseConnection();
                login = db.returnValue("Select логин From Авторизация");
                password = db.returnValue("Select пароль From Авторизация");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            try
            {
                GetFromBDLoginPassword();
                if (Form1.admin == true)
                {
                    MessageBox.Show("Вы уже авторизировались");
                }
                else
                {
                    if ((tbLogin.Text == login) && (tbPassword.Text == password))
                    {
                        MessageBox.Show("Вы успешно авторизировались");
                        Form1.admin = true;
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели неправильный логин или пароль");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Не все поля были заполнены");
            }

        }
    }
}
