using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rstaurant_MahdiAskarpoor
{
    public partial class form_intro : Form
    {
        public form_intro()
        {
            InitializeComponent();
        }

        private void Btn_intro_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_login form_login = new form_login();
            form_login.FormClosed += (s, args) => this.Close();
            form_login.Show();
        }
    }
}
