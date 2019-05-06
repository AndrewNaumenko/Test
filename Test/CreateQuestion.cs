/*using System;
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
using System.Windows.Forms;*/

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
    public partial class CreateQuestion : Form
    {
        public CreateQuestion()
        {
            InitializeComponent();
            cbTemplate.SelectedIndex = 0;
        }

        private void cbTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTemplate.Text=="Написать ответ")
            {
                lWrongAnswers.Visible = false;
                tbWrong1.Visible = false;
                tbWrong2.Visible = false;
                tbWrong3.Visible = false;
            }
            else
            {
                lWrongAnswers.Visible = true;
                tbWrong1.Visible = true;
                tbWrong2.Visible = true;
                tbWrong3.Visible = true;
            } 
        }
    }
}
