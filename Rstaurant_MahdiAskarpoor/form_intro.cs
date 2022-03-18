using System;
using System.Windows.Forms;

namespace Rstaurant_MahdiAskarpoor
{
    public partial class form_intro : Form
    {
        public form_intro()
        {
            InitializeComponent();
        }


        private void form_intro_Load(object sender, EventArgs e)
        {
            // ? Change chk_hide status
            if (System.IO.File.Exists("hide_intro"))
                chk_hide_form.Checked = true;
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            // ? 
            if (chk_hide_form.Checked && !System.IO.File.Exists("hide_intro"))
            {
                string hide_form_message =
                    "صفحه خوش آمدگویی مخفی است.\nبرای نمایش دوباره صفحه خوض آمدگویی هنگام شروع نرم افزار، میتوانید این فایل را حذف کنید.";
                System.IO.File.WriteAllText("hide_intro", hide_form_message);
            }
            else
            {
                System.IO.File.Delete("hide_intro");
            }

            this.Hide();
            form_login form_login = new form_login();
            form_login.FormClosed += (s, args) => this.Close();
            form_login.Show();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            string help_pdf = "help.pdf";
            System.Diagnostics.Process.Start(help_pdf);
        }

        private void chk_hide_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chk_hide_form.Checked)
                    chk_hide_form.Checked = false;
                else
                    chk_hide_form.Checked = true;
            }
        }
    }
}