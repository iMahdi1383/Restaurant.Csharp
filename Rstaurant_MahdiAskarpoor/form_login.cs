using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rstaurant_MahdiAskarpoor
{
    public partial class form_login : Form
    {
        //variables
        public static string username = "";
        string password = "";
        public form_login()
        {
            InitializeComponent();
        }
        private void pnl_username_Click(object sender, EventArgs e)
        {
            input_username.Focus();
        }

        private void pnl_password_Click(object sender, EventArgs e)
        {
            input_password.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            username = input_username.Text;
            password = input_password.Text;
            employeeTableAdapter.FillBy_employee(akoladResturantDataSet_employee.employee, username, password);
            if (input_username.Text == "" || input_password.Text == "")
                MessageBox.Show("نام کاربری یا رمز عبور وارد نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (akoladResturantDataSet_employee.employee.Rows.Count > 0)
            {
                MessageBox.Show("به سیستم مدیریت سفارش گارسون خوش آمدید", "خوش آمدید", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                form_main form_main = new form_main();
                form_main.FormClosed += (s, args) => this.Close();
                form_main.Show();
            }
            else
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "خطا", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btn_showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            input_password.PasswordChar = char.Parse("\0");
            input_password.Top -= 2;
            input_password.MaximumSize = new System.Drawing.Size(200, 30);
            input_password.MinimumSize = new System.Drawing.Size(200, 30);
            input_password.Font = new Font("Vazir Medium", 11);
        }

        private void btn_showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            input_password.PasswordChar = char.Parse("●");
            input_password.Top += 2;
            input_password.MaximumSize = new System.Drawing.Size(200, 15);
            input_password.MinimumSize = new System.Drawing.Size(200, 15);
            input_password.Font = new Font("Vazir Light", 8);
            input_password.Focus();
        }

        private void Input_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(this, new EventArgs());
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.akoladResturantDataSet_employee.employee);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_intro form_intro = new form_intro();
            form_intro.FormClosed += (s, args) => this.Close();
            form_intro.Show();
        }
        // todo

        private void btn_showPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_showPassword_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }
        private void btn_showPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_showPassword_MouseUp(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }
    }
}
