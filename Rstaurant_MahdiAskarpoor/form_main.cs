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
    public partial class form_main : Form
    {

        string employee_username = form_login.username;

        public form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
/*            try
            {*/
                this.employeeTableAdapter.FillBy_employee_private(this.akoladResturantDataSet_employee.employee,employee_username);
                this.customerTableAdapter.Fill(this.akoladResturantDataSet_customer.customer);
                this.foodTableAdapter.Fill(this.akoladResturantDataSet_food.food);
                this.factorTableAdapter.Fill(this.akoladResturantDataSet_order.factor);
                this.orderTableAdapter.Fill(this.akoladResturantDataSet_order.order);
/*            }
            catch
            {
                MessageBox.Show("به نظر میرسد خطایی در ارتباط با پایگاه داده وجود دارد\nلطفا با توسعه دهنده تماس بگیرید :\n09103291436", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }*/

            lbl_employee_name.Text = "سلام " + dgv_employee.Rows[0].Cells[2].Value.ToString();
            if (Convert.ToBoolean(dgv_employee.Rows[0].Cells[5].Value))
            {
                lbl_employee_type.Text = "کاربر مدیر";
                this.employeeTableAdapter.Fill(this.akoladResturantDataSet_employee.employee);
                pnl_employee.Show();
            }
            else {
                lbl_employee_type.Text = "کاربر عادی";
                pnl_employee.Hide();
            }

            // time greeting (shab bekheir)
            string timeStr = DateTime.Now.Hour.ToString();
            byte timeInt = Convert.ToByte(timeStr);
            if (timeInt >= 5 && timeInt < 11)
                lbl_greeting.Text = "صبح بخیر";
            else if (timeInt >= 11 && timeInt < 15)
                lbl_greeting.Text = "ظهر بخیر";
            else if (timeInt >= 15 && timeInt < 20)
                lbl_greeting.Text = "عصر بخیر";
            else if (timeInt >= 20 || timeInt < 5)
                lbl_greeting.Text = "شب بخیر";
            lbl_welcome.Text = tabs.SelectedTab.Text;


            tabs.SelectedTab = tab_dashboard;
            btn_home.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            ico_home.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;

            // login Date & Time (تاریخ ورود)
            string shortDate = DateTime.Now.ToShortDateString();
            List<string> ListString_shortDate = shortDate.Split('/').Select(p => p.Trim()).ToList();
            ListString_shortDate.Reverse();
            lbl_login_date.Text = "تاریخ امروز : " + string.Join("/", ListString_shortDate.ToArray());
            lbl_login_time.Text = "ساعت ورود : " + DateTime.Now.ToShortTimeString();

        }

        // menu mouse hover
        private void Btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
            ico_home.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
        }
        private void Btn_factor_MouseHover(object sender, EventArgs e)
        {
            btn_factor.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
            ico_factor.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
        }
        private void Btn_order_MouseHover(object sender, EventArgs e)
        {
            btn_order.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
            ico_order.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
        }
        private void Btn_food_MouseHover(object sender, EventArgs e)
        {
            btn_food.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
            ico_food.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
        }
        private void Btn_customer_MouseHover(object sender, EventArgs e)
        {
            btn_customer.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
            ico_customer.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
        }
        private void Btn_setting_MouseHover(object sender, EventArgs e)
        {
            btn_setting.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
            ico_setting.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.white_30;
        }
        private void Btn_add_food_MouseHover(object sender, EventArgs e)
        {
            btn_add_food.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.orange_gradient;
        }

        private void Btn_add_food_MouseLeave(object sender, EventArgs e)
        {
            btn_add_food.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.orange_plus;
        }


        // menu mouse leave
        private void Btn_home_MouseLeave(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tab_dashboard)
            {
                btn_home.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
                ico_home.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            }
            else
            {
                btn_home.BackgroundImage = null;
                ico_home.BackgroundImage = null;
            }
        }
        private void Btn_factor_MouseLeave(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tab_factor)
            {
                btn_factor.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
                ico_factor.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            }
            else
            {
                btn_factor.BackgroundImage = null;
                ico_factor.BackgroundImage = null;
            }
        }
        private void Btn_order_MouseLeave(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tab_order)
            {
                btn_order.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
                ico_order.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            }
            else
            {
                btn_order.BackgroundImage = null;
                ico_order.BackgroundImage = null;
            }
        }
        private void Btn_food_MouseLeave(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tab_food)
            {
                btn_food.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
                ico_food.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            }
            else
            {
                btn_food.BackgroundImage = null;
                ico_food.BackgroundImage = null;
            }
        }
        private void Btn_customer_MouseLeave(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tab_customer)
            {
                btn_customer.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
                ico_customer.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            }
            else
            {
                btn_customer.BackgroundImage = null;
                ico_customer.BackgroundImage = null;
            }
        }
        private void Btn_setting_MouseLeave(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == tab_setting)
            {
                btn_setting.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
                ico_setting.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            }
            else
            {
                btn_setting.BackgroundImage = null;
                ico_setting.BackgroundImage = null;
            }
        }





        // tab dashboard
        private void Btn_add_customer_MouseHover(object sender, EventArgs e)
        {
            btn_add_customer.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.purple_gradient;
        }

        private void Btn_add_customer_MouseLeave(object sender, EventArgs e)
        {
            btn_add_customer.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.purple_plus;
        }




        // menu
        private void Btn_home_Click(object sender, EventArgs e)
        {
            lbl_welcome.Text = tab_dashboard.Text;
            tabs.SelectedTab = tab_dashboard;
            btn_home.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            ico_home.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            btn_factor.BackgroundImage = null;
            ico_factor.BackgroundImage = null;
            btn_order.BackgroundImage = null;
            ico_order.BackgroundImage = null;
            btn_food.BackgroundImage = null;
            ico_food.BackgroundImage = null;
            btn_customer.BackgroundImage = null;
            ico_customer.BackgroundImage = null;
            btn_setting.BackgroundImage = null;
            ico_setting.BackgroundImage = null;
        }
        private void Btn_factor_Click(object sender, EventArgs e)
        {
            lbl_welcome.Text = tab_factor.Text;
            tabs.SelectedTab = tab_factor;
            btn_home.BackgroundImage = null;
            ico_home.BackgroundImage = null;
            btn_factor.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            ico_factor.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            btn_order.BackgroundImage = null;
            ico_order.BackgroundImage = null;
            btn_food.BackgroundImage = null;
            ico_food.BackgroundImage = null;
            btn_customer.BackgroundImage = null;
            ico_customer.BackgroundImage = null;
            btn_setting.BackgroundImage = null;
            ico_setting.BackgroundImage = null;
        }
        private void Btn_order_Click(object sender, EventArgs e)
        {
            lbl_welcome.Text = tab_order.Text;
            tabs.SelectedTab = tab_order;
            btn_home.BackgroundImage = null;
            ico_home.BackgroundImage = null;
            btn_factor.BackgroundImage = null;
            ico_factor.BackgroundImage = null;
            btn_order.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            ico_order.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            btn_food.BackgroundImage = null;
            ico_food.BackgroundImage = null;
            btn_customer.BackgroundImage = null;
            ico_customer.BackgroundImage = null;
            btn_setting.BackgroundImage = null;
            ico_setting.BackgroundImage = null;
        }

        private void Btn_food_Click(object sender, EventArgs e)
        {
            lbl_welcome.Text = tab_food.Text;
            tabs.SelectedTab = tab_food;
            Btn_food_empty_Click(this,new EventArgs());
            input_food_name.Focus();
            btn_home.BackgroundImage = null;
            ico_home.BackgroundImage = null;
            btn_factor.BackgroundImage = null;
            ico_factor.BackgroundImage = null;
            btn_order.BackgroundImage = null;
            ico_order.BackgroundImage = null;
            btn_food.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            ico_food.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            btn_customer.BackgroundImage = null;
            ico_customer.BackgroundImage = null;
            btn_setting.BackgroundImage = null;
            ico_setting.BackgroundImage = null;
        }

        private void Btn_customer_Click(object sender, EventArgs e)
        {
            lbl_welcome.Text = tab_customer.Text;
            tabs.SelectedTab = tab_customer;
            Btn_customer_empty_Click(this, new EventArgs());
            input_customer_name.Focus();
            btn_home.BackgroundImage = null;
            ico_home.BackgroundImage = null;
            btn_factor.BackgroundImage = null;
            ico_factor.BackgroundImage = null;
            btn_order.BackgroundImage = null;
            ico_order.BackgroundImage = null;
            btn_food.BackgroundImage = null;
            ico_food.BackgroundImage = null;
            btn_customer.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            ico_customer.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            btn_setting.BackgroundImage = null;
            ico_setting.BackgroundImage = null;
        }

        private void Btn_setting_Click(object sender, EventArgs e)
        {
            lbl_welcome.Text = tab_setting.Text;
            tabs.SelectedTab = tab_setting;
            btn_home.BackgroundImage = null;
            ico_home.BackgroundImage = null;
            btn_factor.BackgroundImage = null;
            ico_factor.BackgroundImage = null;
            btn_order.BackgroundImage = null;
            ico_order.BackgroundImage = null;
            btn_food.BackgroundImage = null;
            ico_food.BackgroundImage = null;
            btn_customer.BackgroundImage = null;
            ico_customer.BackgroundImage = null;
            btn_setting.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
            ico_setting.BackgroundImage = global::Rstaurant_MahdiAskarpoor.Properties.Resources.black_30;
        }






        // tab food
        private void Pnl_food_search_Click(object sender, EventArgs e)
        {
            input_food_search.Focus();
            if (input_food_search.Text == "جست و جو")
                input_food_search.Text = "";
        }
        private void Input_food_search_Enter(object sender, EventArgs e)
        {
            input_food_search.Focus();
            if (input_food_search.Text == "جست و جو")
                input_food_search.Text = "";
        }

        private void Input_food_search_Leave(object sender, EventArgs e)
        {
            if (input_food_search.Text == "")
            {
                input_food_search.Text = "جست و جو";
                try
                {
                    foodTableAdapter.Fill(akoladResturantDataSet_food.food);
                }
                catch
                {
                    MessageBox.Show("متاسفانه ارتباط با جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_food_search_Click(object sender, EventArgs e)
        {
            int food_int = -1; string food_string = ""; decimal food_decimal = -1;
            food_string = input_food_search.Text;
            bool is_int = Int32.TryParse(input_food_search.Text, out food_int);
            bool is_decimal = Decimal.TryParse(input_food_search.Text, out food_decimal);
            if (input_food_search.Text != "" && input_food_search.Text != "جست و جو")
                try
                {
                    foodTableAdapter.FillBy_search_food(akoladResturantDataSet_food.food, food_int, food_string, food_decimal);
                }
                catch
                {
                    MessageBox.Show("متاسفانه جست و جو در جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            else
                try
                {
                    foodTableAdapter.Fill(akoladResturantDataSet_food.food);
                }
                catch
                {
                    MessageBox.Show("متاسفانه ارتباط با جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void Input_food_search_TextChanged(object sender, EventArgs e)
        {
            Btn_food_search_Click(this, new EventArgs());
        }
        private void Btn_food_empty_Click(object sender, EventArgs e)
        {
            input_food_code.Text = "";
            input_food_name.Text = "";
            input_food_price.Text = "";
        }
        private void Dgv_food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_food.Rows.Count > 0)
            {
                int food_RowIndex = dgv_food.CurrentCell.RowIndex;
                dgv_food.Rows[food_RowIndex].Selected = true;
                input_food_code.Text = dgv_food.Rows[food_RowIndex].Cells[0].Value.ToString();
                input_food_name.Text = dgv_food.Rows[food_RowIndex].Cells[1].Value.ToString();
                input_food_price.Text = dgv_food.Rows[food_RowIndex].Cells[2].Value.ToString();
            }
        }
        private void Pnl_food_name_Click(object sender, EventArgs e)
        {
            input_food_name.Focus();
        }
        private void Pnl_food_price_Click(object sender, EventArgs e)
        {
            input_food_price.Focus();
        }
        private void Input_food_name_Enter(object sender, EventArgs e)
        {
            pnl_food_name.FlatAppearance.BorderSize = 2;
            pnl_food_name.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            lbl_food_name.ForeColor = Color.FromArgb(0, 128, 255);
            lbl_food_name.Font = new Font("Vazir Medium", 11);
        }

        private void Input_food_price_Enter(object sender, EventArgs e)
        {
            pnl_food_price.FlatAppearance.BorderSize = 2;
            pnl_food_price.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            lbl_food_price.ForeColor = Color.FromArgb(0, 128, 255);
            lbl_food_price.Font = new Font("Vazir Medium", 11);
        }
        private void Input_food_name_Leave(object sender, EventArgs e)
        {
            pnl_food_name.FlatAppearance.BorderSize = 1;
            pnl_food_name.FlatAppearance.BorderColor = Color.FromArgb(141, 152, 156);
            lbl_food_name.ForeColor = Color.FromArgb(99, 110, 114);
            lbl_food_name.Font = new Font("Vazir Light", 11);
        }

        private void Input_food_price_Leave(object sender, EventArgs e)
        {
            pnl_food_price.FlatAppearance.BorderSize = 1;
            pnl_food_price.FlatAppearance.BorderColor = Color.FromArgb(141, 152, 156);
            lbl_food_price.ForeColor = Color.FromArgb(99, 110, 114);
            lbl_food_price.Font = new Font("Vazir Light", 11);
        }

        private void Btn_food_submit_MouseHover(object sender, EventArgs e)
        {
            ico_food_submit.BackColor = Color.FromArgb(7, 107, 182);
            btn_food_submit.BackColor = Color.FromArgb(7, 107, 182);
        }
        private void Btn_food_submit_MouseLeave(object sender, EventArgs e)
        {
            ico_food_submit.BackColor = Color.FromArgb(0, 128, 255);
            btn_food_submit.BackColor = Color.FromArgb(0, 128, 255);
        }
        private void Btn_food_submit_MouseDown(object sender, MouseEventArgs e)
        {
            ico_food_submit.BackColor = Color.FromArgb(5, 86, 146);
            btn_food_submit.BackColor = Color.FromArgb(5, 86, 146);
        }

        private void Btn_food_submit_MouseUp(object sender, MouseEventArgs e)
        {
            ico_food_submit.BackColor = Color.FromArgb(7, 107, 182);
            btn_food_submit.BackColor = Color.FromArgb(7, 107, 182);
        }
        private void Btn_food_first_Click(object sender, EventArgs e)
        {
            foodBindingSource.MoveFirst();
            int food_RowIndex = dgv_food.CurrentCell.RowIndex;
            Dgv_food_CellClick(this, new DataGridViewCellEventArgs(1, food_RowIndex));
        }

        private void Btn_food_prev_Click(object sender, EventArgs e)
        {
            foodBindingSource.MovePrevious();
            int food_RowIndex = dgv_food.CurrentCell.RowIndex;
            Dgv_food_CellClick(this, new DataGridViewCellEventArgs(1, food_RowIndex));
        }

        private void Btn_food_next_Click(object sender, EventArgs e)
        {
            foodBindingSource.MoveNext();
            int food_RowIndex = dgv_food.CurrentCell.RowIndex;
            Dgv_food_CellClick(this, new DataGridViewCellEventArgs(1, food_RowIndex));
        }

        private void Btn_food_last_Click(object sender, EventArgs e)
        {
            foodBindingSource.MoveLast();
            int food_RowIndex = dgv_food.CurrentCell.RowIndex;
            Dgv_food_CellClick(this, new DataGridViewCellEventArgs(1, food_RowIndex));
        }






        // tab customer
        private void Pnl_customer_search_Click(object sender, EventArgs e)
        {
            input_customer_search.Focus();
            if (input_customer_search.Text == "جست و جو")
                input_customer_search.Text = "";
        }
        private void Input_customer_search_Enter(object sender, EventArgs e)
        {
            input_customer_search.Focus();
            if (input_customer_search.Text == "جست و جو")
                input_customer_search.Text = "";
        }

        private void Input_customer_search_Leave(object sender, EventArgs e)
        {
            if (input_customer_search.Text == "")
            {
                input_customer_search.Text = "جست و جو";
                try
                {
                    customerTableAdapter.Fill(akoladResturantDataSet_customer.customer);
                }
                catch
                {
                    MessageBox.Show("متاسفانه ارتباط با جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Btn_customer_search_Click(object sender, EventArgs e)
        {
            // todo fixme : customer search
            int customer_int = -1; string customer_string = "";
            bool is_int = Int32.TryParse(input_customer_search.Text, out customer_int);
            customer_string = input_customer_search.Text;
            if (input_customer_search.Text != "" && input_customer_search.Text != "جست و جو")
                try
                {
                    customerTableAdapter.FillBy_search_customer(akoladResturantDataSet_customer.customer, customer_int, customer_string, customer_string, customer_string);
                }
                catch
                {
                    MessageBox.Show("متاسفانه جست و جو در جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            else
                try
                {
                    customerTableAdapter.Fill(akoladResturantDataSet_customer.customer);
                }
                catch
                {
                    MessageBox.Show("متاسفانه ارتباط با جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void Input_customer_search_TextChanged(object sender, EventArgs e)
        {
            Btn_customer_search_Click(this, new EventArgs());
        }

        private void Btn_customer_empty_Click(object sender, EventArgs e)
        {
            input_customer_code.Text = "";
            input_customer_name.Text = "";
            input_customer_phone.Text = "";
            input_customer_address.Text = "";
        }
        private void Dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_customer.Rows.Count > 0)
            {
                int customer_RowIndex = dgv_customer.CurrentCell.RowIndex;
                dgv_customer.Rows[customer_RowIndex].Selected = true;
                input_customer_code.Text = dgv_customer.Rows[customer_RowIndex].Cells[0].Value.ToString();
                input_customer_name.Text = dgv_customer.Rows[customer_RowIndex].Cells[1].Value.ToString();
                input_customer_phone.Text = dgv_customer.Rows[customer_RowIndex].Cells[2].Value.ToString();
                input_customer_address.Text = dgv_customer.Rows[customer_RowIndex].Cells[3].Value.ToString();
            }
        }
        private void Pnl_customer_name_Click(object sender, EventArgs e)
        {
            input_customer_name.Focus();
        }
        private void Pnl_customer_phone_Click(object sender, EventArgs e)
        {
            input_customer_phone.Focus();
        }
        private void Pnl_customer_address_Click(object sender, EventArgs e)
        {
            input_customer_address.Focus();
        }
        private void Input_customer_name_Enter(object sender, EventArgs e)
        {
            pnl_customer_name.FlatAppearance.BorderSize = 2;
            pnl_customer_name.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            lbl_customer_name.ForeColor = Color.FromArgb(0, 128, 255);
            lbl_customer_name.Font = new Font("Vazir Medium", 11);
        }

        private void Input_customer_phone_Enter(object sender, EventArgs e)
        {
            pnl_customer_phone.FlatAppearance.BorderSize = 2;
            pnl_customer_phone.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            lbl_customer_phone.ForeColor = Color.FromArgb(0, 128, 255);
            lbl_customer_phone.Font = new Font("Vazir Medium", 11);
        }
        private void Input_customer_address_Enter(object sender, EventArgs e)
        {
            pnl_customer_address.FlatAppearance.BorderSize = 2;
            pnl_customer_address.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 255);
            lbl_customer_address.ForeColor = Color.FromArgb(0, 128, 255);
            lbl_customer_address.Font = new Font("Vazir Medium", 11);
        }
        private void Input_customer_name_Leave(object sender, EventArgs e)
        {
            pnl_customer_name.FlatAppearance.BorderSize = 1;
            pnl_customer_name.FlatAppearance.BorderColor = Color.FromArgb(141, 152, 156);
            lbl_customer_name.ForeColor = Color.FromArgb(99, 110, 114);
            lbl_customer_name.Font = new Font("Vazir Light", 11);
        }

        private void Input_customer_phone_Leave(object sender, EventArgs e)
        {
            pnl_customer_phone.FlatAppearance.BorderSize = 1;
            pnl_customer_phone.FlatAppearance.BorderColor = Color.FromArgb(141, 152, 156);
            lbl_customer_phone.ForeColor = Color.FromArgb(99, 110, 114);
            lbl_customer_phone.Font = new Font("Vazir Light", 11);
        }
        private void Input_customer_address_Leave(object sender, EventArgs e)
        {
            pnl_customer_address.FlatAppearance.BorderSize = 1;
            pnl_customer_address.FlatAppearance.BorderColor = Color.FromArgb(141, 152, 156);
            lbl_customer_address.ForeColor = Color.FromArgb(99, 110, 114);
            lbl_customer_address.Font = new Font("Vazir Light", 11);
        }

        private void Btn_customer_submit_MouseHover(object sender, EventArgs e)
        {
            ico_customer_submit.BackColor = Color.FromArgb(7, 107, 182);
            btn_customer_submit.BackColor = Color.FromArgb(7, 107, 182);
        }
        private void Btn_customer_submit_MouseLeave(object sender, EventArgs e)
        {
            ico_customer_submit.BackColor = Color.FromArgb(0, 128, 255);
            btn_customer_submit.BackColor = Color.FromArgb(0, 128, 255);
        }
        private void Btn_customer_submit_MouseDown(object sender, MouseEventArgs e)
        {
            ico_customer_submit.BackColor = Color.FromArgb(5, 86, 146);
            btn_customer_submit.BackColor = Color.FromArgb(5, 86, 146);
        }

        private void Btn_customer_submit_MouseUp(object sender, MouseEventArgs e)
        {
            ico_customer_submit.BackColor = Color.FromArgb(7, 107, 182);
            btn_customer_submit.BackColor = Color.FromArgb(7, 107, 182);
        }
        private void Btn_customer_first_Click(object sender, EventArgs e)
        {
            customerBindingSource.MoveFirst();
            int customer_RowIndex = dgv_customer.CurrentCell.RowIndex;
            Dgv_customer_CellClick(this, new DataGridViewCellEventArgs(1, customer_RowIndex));
        }

        private void Btn_customer_prev_Click(object sender, EventArgs e)
        {
            customerBindingSource.MovePrevious();
            int customer_RowIndex = dgv_customer.CurrentCell.RowIndex;
            Dgv_customer_CellClick(this, new DataGridViewCellEventArgs(1, customer_RowIndex));
        }

        private void Btn_customer_next_Click(object sender, EventArgs e)
        {
            customerBindingSource.MoveNext();
            int customer_RowIndex = dgv_customer.CurrentCell.RowIndex;
            Dgv_customer_CellClick(this, new DataGridViewCellEventArgs(1, customer_RowIndex));
        }

        private void Btn_customer_last_Click(object sender, EventArgs e)
        {
            customerBindingSource.MoveLast();
            int customer_RowIndex = dgv_customer.CurrentCell.RowIndex;
            Dgv_customer_CellClick(this, new DataGridViewCellEventArgs(1, customer_RowIndex));
        }



        // dgv codes

        private void Btn_food_add_Click(object sender, EventArgs e)
        {
            DialogResult isAdd = MessageBox.Show("آیا مطمئن هستید که میخواهید این غذا به منو افزوده شود؟", "افزودن به منو", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (isAdd == DialogResult.Yes)
            {
                string food_name = input_food_name.Text;
                if (food_name == "") MessageBox.Show("نام غذا وارد نشده است", "خطا", MessageBoxButtons.OK);
                else
                {
                    decimal food_price = 0;
                    bool check_price = Decimal.TryParse(input_food_price.Text, out food_price);
                    if (check_price != true)
                        MessageBox.Show("مقدار وارد شده برای قیمت غذا صحیح نمیباشد", "خطا", MessageBoxButtons.OK);
                    else
                    {
                        try
                        {
                            foodTableAdapter.FillBy_checkAdd_food(akoladResturantDataSet_food.food, food_name);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه عمل بررسی مقدار تکراری در جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (dgv_food.Rows.Count > 0)
                        {
                            int repeated_food_code = Convert.ToInt32(dgv_food.Rows[0].Cells[0].Value);
                            try
                            {
                                foodTableAdapter.Fill(akoladResturantDataSet_food.food);
                            }
                            catch
                            {
                                MessageBox.Show("متاسفانه ارتباط با جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            dgv_food.CurrentCell = dgv_food.Rows[repeated_food_code - 1].Cells[1];
                            Dgv_food_CellClick(this, new DataGridViewCellEventArgs(1, repeated_food_code - 1));
                            MessageBox.Show("غذایی با همین نام با کد « " + repeated_food_code + " » در منوی غذا وجود دارد\nمیتوانید آن را ویرایش کنید", "غذای تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                foodTableAdapter.InsertQuery_food(food_name, food_price);
                            }
                            catch
                            {
                                MessageBox.Show("متاسفانه اضافه کردن رکورد جدید به جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            try
                            {
                                foodTableAdapter.Fill(akoladResturantDataSet_food.food);
                            }
                            catch
                            {
                                MessageBox.Show("متاسفانه ارتباط با جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void Btn_customer_add_Click(object sender, EventArgs e)
        {
            DialogResult isAdd = MessageBox.Show("آیا مطمئن هستید که میخواهید این مشتری به لیست افزوده شود؟", "افزودن مشتری", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (isAdd == DialogResult.Yes)
            {
                string customer_name = input_customer_name.Text;
                if (customer_name == "") MessageBox.Show("نام مششتری وارد نشده است", "خطا", MessageBoxButtons.OK);
                else
                {
                    string customer_address = input_customer_address.Text;
                    long customer_phone = 0;
                    string customer_phone_string = input_customer_phone.Text;
                    bool check_phone = long.TryParse(customer_phone_string, out customer_phone);
                    if (check_phone != true || customer_phone_string.Length != 11 || customer_phone_string[0].ToString() != "0")
                        MessageBox.Show("شماره تلفن وارد شده صحیح نمیباشد", "خطا", MessageBoxButtons.OK);
                    else
                    {
                        try
                        {
                            customerTableAdapter.FillBy_checkAdd_customer(akoladResturantDataSet_customer.customer, customer_name, customer_phone_string);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه عمل بررسی مقدار تکراری در جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (dgv_customer.Rows.Count > 0)
                        {
                            int repeated_customer_code = Convert.ToInt32(dgv_customer.Rows[0].Cells[0].Value);
                            try
                            {
                                customerTableAdapter.Fill(akoladResturantDataSet_customer.customer);
                            }
                            catch
                            {
                                MessageBox.Show("متاسفانه ارتباط با جدول\n« customr »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            dgv_customer.CurrentCell = dgv_customer.Rows[repeated_customer_code - 1].Cells[1];
                            Dgv_customer_CellClick(this, new DataGridViewCellEventArgs(1, repeated_customer_code - 1));
                            MessageBox.Show("مشتری با نام یا تلفن تکراری با کد « " + repeated_customer_code + " » در لیست وجود دارد\nمیتوانید آن را ویرایش کنید", "مشتری تکراری", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                customerTableAdapter.InsertQuery_customer(customer_name, customer_phone_string, customer_address);
                            }
                            catch
                            {
                                MessageBox.Show("متاسفانه اضافه کردن رکورد جدید به جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            try
                            {
                                customerTableAdapter.Fill(akoladResturantDataSet_customer.customer);
                            }
                            catch
                            {
                                MessageBox.Show("متاسفانه ارتباط با جدول\n« customr »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void Btn_food_edit_Click(object sender, EventArgs e)
        {
            int food_code = Convert.ToInt32(dgv_food.Rows[dgv_food.CurrentCell.RowIndex].Cells[0].Value);
            string food_name_old = dgv_food.Rows[dgv_food.CurrentCell.RowIndex].Cells[1].Value.ToString();
            decimal food_price_old = Convert.ToDecimal(dgv_food.Rows[dgv_food.CurrentCell.RowIndex].Cells[2].Value);
            string food_name = input_food_name.Text;
            if (food_name == "") MessageBox.Show("نام غذا وارد نشده است", "خطا", MessageBoxButtons.OK);
            else
            {
                decimal food_price = 0;
                bool check_price = Decimal.TryParse(input_food_price.Text, out food_price);
                if (check_price != true)
                    MessageBox.Show("مقدار وارد شده برای قیمت غذا صحیح نمیباشد", "خطا", MessageBoxButtons.OK);
                else
                {
                    DialogResult isEdit = MessageBox.Show("غذای کد « " + food_code + " » ویرایش می شود\n\n" + food_name_old + " => " + food_name + "\n" + food_price + " <= " + food_price_old + "\n\nآیا مطمئن هستید؟", "ویرایش غذا", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (isEdit == DialogResult.Yes)
                    {
                        try
                        {
                            foodTableAdapter.UpdateQuery_food(food_name, food_price, food_code);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه ویرایش رکورد از جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        try
                        {
                            foodTableAdapter.Fill(akoladResturantDataSet_food.food);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه ارتباط با جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgv_food.CurrentCell = dgv_food.Rows[food_code - 1].Cells[1];
                        Dgv_food_CellClick(this, new DataGridViewCellEventArgs(1, food_code - 1));
                    }
                }
            }
        }
        private void Btn_customer_edit_Click(object sender, EventArgs e)
        {
            int customer_code = Convert.ToInt32(dgv_customer.Rows[dgv_customer.CurrentCell.RowIndex].Cells[0].Value);
            string customer_name_old = dgv_customer.Rows[dgv_customer.CurrentCell.RowIndex].Cells[1].Value.ToString();
            decimal customer_phone_old = Convert.ToDecimal(dgv_customer.Rows[dgv_customer.CurrentCell.RowIndex].Cells[2].Value);
            string customer_address_old = dgv_customer.Rows[dgv_customer.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string customer_name = input_customer_name.Text;
            if (customer_name == "") MessageBox.Show("نام مشتری وارد نشده است", "خطا", MessageBoxButtons.OK);
            else
            {
                string customer_address = input_customer_address.Text;
                long customer_phone = 0;
                string customer_phone_string = input_customer_phone.Text;
                bool check_phone = long.TryParse(customer_phone_string, out customer_phone);
                if (check_phone != true || customer_phone_string.Length != 11 || customer_phone_string[0].ToString() != "0")
                    MessageBox.Show("شماره تلفن وارد شده صحیح نمیباشد", "خطا", MessageBoxButtons.OK);
                else
                {
                    DialogResult isEdit = MessageBox.Show("مشتری کد « " + customer_code + " » ویرایش می شود\n\n" + customer_name_old + " »»» " + customer_name + "\n" + customer_phone + " ««« " + customer_phone_old + "\n" + customer_address_old + " »»» " + customer_address + "\n\nآیا مطمئن هستید؟", "ویرایش غذا", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (isEdit == DialogResult.Yes)
                    {
                        try
                        {
                            customerTableAdapter.UpdateQuery_customer(customer_name, customer_phone_string, customer_address, customer_code);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه ویرایش رکورد از جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        try
                        {
                            customerTableAdapter.Fill(akoladResturantDataSet_customer.customer);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه ارتباط با جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgv_customer.CurrentCell = dgv_customer.Rows[customer_code - 1].Cells[1];
                        Dgv_customer_CellClick(this, new DataGridViewCellEventArgs(1, customer_code - 1));
                    }
                }
            }
        }
        private void Btn_food_delete_Click(object sender, EventArgs e)
        {
            int food_RowIndex = dgv_food.CurrentCell.RowIndex;
            Dgv_food_CellClick(this, new DataGridViewCellEventArgs(1, food_RowIndex));
            int food_code = Convert.ToInt32(dgv_food.Rows[dgv_food.CurrentCell.RowIndex].Cells[0].Value);
            string food_name = dgv_food.Rows[dgv_food.CurrentCell.RowIndex].Cells[1].Value.ToString();
            decimal food_price = Convert.ToDecimal(dgv_food.Rows[dgv_food.CurrentCell.RowIndex].Cells[2].Value);
            DialogResult isDelete = MessageBox.Show("غذای کد « " + food_code + " » حذف می شود\n\n" + food_name + "\n" + food_price + "\n\nآیا مطمئن هستید؟", "حذف غذا", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (isDelete == DialogResult.Yes)
            {
                try
                {
                    foodTableAdapter.DeleteQuery_food(food_code);
                }
                catch
                {
                    MessageBox.Show("متاسفانه حذف رکورد از جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    foodTableAdapter.Fill(akoladResturantDataSet_food.food);
                }
                catch
                {
                    MessageBox.Show("متاسفانه ارتباط با جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Btn_customer_delete_Click(object sender, EventArgs e)
        {
            int customer_RowIndex = dgv_customer.CurrentCell.RowIndex;
            Dgv_customer_CellClick(this, new DataGridViewCellEventArgs(1, customer_RowIndex));
            int customer_code = Convert.ToInt32(dgv_customer.Rows[dgv_customer.CurrentCell.RowIndex].Cells[0].Value);
            string customer_name = dgv_customer.Rows[dgv_customer.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string customer_phone = dgv_customer.Rows[dgv_customer.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string customer_address = dgv_customer.Rows[dgv_customer.CurrentCell.RowIndex].Cells[3].Value.ToString();
            DialogResult isDelete = MessageBox.Show("مشتری کد « " + customer_code + " » حذف می شود\n\n" + customer_name + "\n" + customer_phone + "\n" + customer_address + "\n\nآیا مطمئن هستید؟", "حذف مشتری", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (isDelete == DialogResult.Yes)
            {

                try
                {
                    customerTableAdapter.DeleteQuery_customer(customer_code);
                }
                catch
                {
                    MessageBox.Show("متاسفانه حذف رکورد از جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    customerTableAdapter.Fill(akoladResturantDataSet_customer.customer);
                }
                catch
                {
                    MessageBox.Show("متاسفانه ارتباط با جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void Input_factor_food_code_TextChanged(object sender, EventArgs e)
        {
            int factor_food_code;
            lbl_factor_food_price.Text = "0 تومان";
            if (input_factor_food_code.Text.Length > 0)
            {
                input_factor_food_code.ForeColor = Color.FromArgb(214, 48, 49);
                lbl_factor_food_name.ForeColor = Color.FromArgb(214, 48, 49);
                lbl_factor_food_name.Text = "کد غذا نادرست است";

                if (int.TryParse(input_factor_food_code.Text, out factor_food_code))
                {
                    try
                    {
                        foodTableAdapter.FillBy_factor_search_food(akoladResturantDataSet_food.food, factor_food_code);
                    }
                    catch
                    {
                        MessageBox.Show("متاسفانه جست و جوی فاکتور در جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (akoladResturantDataSet_food.food.Rows.Count > 0)
                    {
                        input_factor_food_code.ForeColor = Color.FromArgb(126, 146, 154);
                        lbl_factor_food_name.ForeColor = Color.FromArgb(99, 110, 114);
                        lbl_factor_food_name.Text = akoladResturantDataSet_food.food.Rows[0]["name"].ToString();
                        lbl_factor_food_price.Text = akoladResturantDataSet_food.food.Rows[0]["price"].ToString() + " تومان";
                        try
                        {
                            foodTableAdapter.Fill(akoladResturantDataSet_food.food);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه ارتباط با جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgv_food.CurrentCell = dgv_food.Rows[factor_food_code - 1].Cells[1];
                        Dgv_food_CellClick(this, new DataGridViewCellEventArgs(1, factor_food_code - 1));
                    }
                }
            }
            else
            {
                input_factor_food_code.ForeColor = Color.FromArgb(126, 146, 154);
                lbl_factor_food_name.ForeColor = Color.FromArgb(99, 110, 114);
                lbl_factor_food_name.Text = "نام غذا";
            }
            if (lbl_factor_food_name.Text == "کد غذا نادرست است" || lbl_factor_food_name.Text == "")
                try
                {
                    foodTableAdapter.Fill(akoladResturantDataSet_food.food);
                }
                catch
                {
                    MessageBox.Show("متاسفانه ارتباط با جدول\n« food »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Input_factor_customer_code_TextChanged(object sender, EventArgs e)
        {
            int factor_customer_code;
            lbl_factor_customer_phone.Text = "09000000000";
            lbl_factor_customer_address.Text = "";
            if (input_factor_customer_code.Text.Length > 0)
            {
                input_factor_customer_code.ForeColor = Color.FromArgb(214, 48, 49);
                lbl_factor_customer_name.ForeColor = Color.FromArgb(214, 48, 49);
                lbl_factor_customer_name.Text = "کد مشتری نادرست است";

                if (int.TryParse(input_factor_customer_code.Text, out factor_customer_code))
                {
                    try
                    {
                        customerTableAdapter.FillBy_factor_search_customer(akoladResturantDataSet_customer.customer, factor_customer_code);
                    }
                    catch
                    {
                        MessageBox.Show("متاسفانه جست و جوی فاکتور در جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (akoladResturantDataSet_customer.customer.Rows.Count > 0)
                    {
                        input_factor_customer_code.ForeColor = Color.FromArgb(126, 146, 154);
                        lbl_factor_customer_name.ForeColor = Color.FromArgb(99, 110, 114);
                        lbl_factor_customer_name.Text = akoladResturantDataSet_customer.customer.Rows[0]["name"].ToString();
                        lbl_factor_customer_phone.Text = akoladResturantDataSet_customer.customer.Rows[0]["phone"].ToString();
                        lbl_factor_customer_address.Text = akoladResturantDataSet_customer.customer.Rows[0]["address"].ToString();
                        try
                        {
                            customerTableAdapter.Fill(akoladResturantDataSet_customer.customer);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه ارتباط با جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dgv_customer.CurrentCell = dgv_customer.Rows[factor_customer_code - 1].Cells[1];
                        Dgv_customer_CellClick(this, new DataGridViewCellEventArgs(1, factor_customer_code - 1));
                    }
                }
            }
            else
            {
                input_factor_customer_code.ForeColor = Color.FromArgb(126, 146, 154);
                lbl_factor_customer_name.ForeColor = Color.FromArgb(99, 110, 114);
                lbl_factor_customer_name.Text = "نام مشتری";
            }
            if (lbl_factor_customer_name.Text == "کد مشتری نادرست است" || lbl_factor_customer_name.Text == "")
                try
                {
                    customerTableAdapter.Fill(akoladResturantDataSet_customer.customer);
                }
                catch
                {
                    MessageBox.Show("متاسفانه ارتباط با جدول\n« customer »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void Btn_factor_choose_food_Click(object sender, EventArgs e)
        {
            Btn_food_Click(this, new EventArgs());
            input_food_name.Focus();
        }
        private void Btn_factor_choose_customer_Click(object sender, EventArgs e)
        {
            Btn_customer_Click(this, new EventArgs());
            input_customer_name.Focus();
        }
        private void Btn_food_submit_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tab_factor;
            input_factor_food_code.Text = input_food_code.Text;
            lbl_factor_food_name.Text = input_food_name.Text;
            lbl_factor_food_price.Text = input_food_price.Text + " تومان";
            input_factor_food_amount.Text = "1";
            input_factor_food_amount.Focus();
        }
        private void Btn_customer_submit_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tab_factor;
            input_factor_customer_code.Text = input_customer_code.Text;
            lbl_factor_customer_name.Text = input_customer_name.Text;
            lbl_factor_customer_phone.Text = input_customer_phone.Text;
            lbl_factor_customer_address.Text = input_customer_address.Text;
            input_factor_customer_code.Focus();
        }

        private void Btn_factor_add_food_Click(object sender, EventArgs e)
        {
            int lastRow = -1, food_amount, totalPrice;
            long factor_totalPrice = 0;
            bool isRepeated = false;
            if (lbl_factor_food_name.Text != "نام غذا" &&
                lbl_factor_food_name.Text != "کد غذا نادرست است" &&
                lbl_factor_food_name.Text != "" &&
                input_factor_food_amount.Text != "" &&
                int.TryParse(input_factor_food_amount.Text, out food_amount)
                )
            {

                lastRow = dgv_factor.Rows.Count - 1;
                for (int i = 0; i <= lastRow; i++)
                    if (input_factor_food_code.Text == dgv_factor.Rows[i].Cells["factor_food_code"].Value.ToString())
                    {
                        isRepeated = true;
                        dgv_factor.CurrentCell = dgv_factor.Rows[i].Cells["factor_food_name"];
                        Dgv_factor_CellContentClick(this, new DataGridViewCellEventArgs(1, i));
                        MessageBox.Show("غذای تکراری با کد « " + input_factor_food_code.Text + " » در فاکتور وجود دارد\nابتدا آن را حذف کنید و دوباره تلاش کنید", "غذای تکراری || فاکتور شماره " + lbl_factor_code.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                if (!isRepeated)
                {
                    dgv_factor.Rows.Add();
                    lastRow = dgv_factor.Rows.Count - 1;
                    dgv_factor.Rows[lastRow].Cells["factor_food_price"].Value = lbl_factor_food_price.Text.Replace(" تومان", "");
                    dgv_factor.Rows[lastRow].Cells["factor_food_code"].Value = input_factor_food_code.Text;
                    dgv_factor.Rows[lastRow].Cells["factor_food_name"].Value = lbl_factor_food_name.Text;
                    dgv_factor.Rows[lastRow].Cells["factor_food_amount"].Value = input_factor_food_amount.Text;
                    totalPrice = (Convert.ToInt32(dgv_factor.Rows[lastRow].Cells["factor_food_price"].Value) * Convert.ToInt32(input_factor_food_amount.Text));
                    dgv_factor.Rows[lastRow].Cells["factor_food_totalPrice"].Value = totalPrice.ToString();
                    dgv_factor.Rows[lastRow].Cells["factor_food_delete"].Style.ForeColor = Color.FromArgb(243, 247, 248);
                    dgv_factor.Rows[lastRow].Cells["factor_food_delete"].Style.BackColor = Color.FromArgb(239, 172, 173);
                    dgv_factor.Rows[lastRow].Cells["factor_food_delete"].Style.SelectionBackColor = Color.FromArgb(214, 48, 49);
                    dgv_factor.Rows[lastRow].Cells["factor_food_delete"].Value = "❌";
                    for (int i = 0; i <= lastRow; i++)
                        factor_totalPrice += Convert.ToInt32(dgv_factor.Rows[i].Cells["factor_food_totalPrice"].Value);
                    lbl_factor_totalPrice.Text = factor_totalPrice.ToString() + " تومان";
                    input_factor_food_code.Text = "";
                    input_factor_food_amount.Text = "";
                    lbl_factor_food_name.Text = "نام غذا";
                    lbl_factor_food_price.Text = "0 تومان";
                }
            }
            else if (lbl_factor_food_name.Text == "نام غذا" || lbl_factor_food_name.Text == "")
                MessageBox.Show("کد غذا وارد نشده است", "خطا", MessageBoxButtons.OK);
            else if (lbl_factor_food_name.Text == "کد غذا نادرست است")
                MessageBox.Show("کد غذا نادرست است", "خطا", MessageBoxButtons.OK);
            else if (input_factor_food_amount.Text == "")
                MessageBox.Show("تعداد غذا وارد نشده است", "خطا", MessageBoxButtons.OK);
            else if (!int.TryParse(input_factor_food_amount.Text, out food_amount))
                MessageBox.Show("تعداد غذا نادرست وارد شده است", "خطا", MessageBoxButtons.OK);
        }

        private void Dgv_factor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int factor_RowIndex = -1;
            if (dgv_factor.Rows.Count > 0)
            {
                factor_RowIndex = dgv_factor.CurrentCell.RowIndex;
                dgv_factor.Rows[factor_RowIndex].Selected = true;
                if (dgv_factor.CurrentCell.Value.ToString() == "❌" && e.RowIndex >= 0)
                {
                    string food_code = dgv_factor.Rows[factor_RowIndex].Cells["factor_food_code"].Value.ToString();
                    string food_name = dgv_factor.Rows[factor_RowIndex].Cells["factor_food_name"].Value.ToString();
                    DialogResult isDelete = MessageBox.Show("غذای کد « " + food_code + " » حذف می شود\n\n" + food_name + "\n\nآیا مطمئن هستید؟", "حذف غذا از فاکتور", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (isDelete == DialogResult.Yes)
                        dgv_factor.Rows.RemoveAt(e.RowIndex);
                }
            }

        }

        private void Tabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Text == "فاکتور")
                Get_factor_date();
            this.factorTableAdapter.Fill(this.akoladResturantDataSet_order.factor);
            int factors_count = Convert.ToInt32(dgv_factors.Rows.Count);
            if (factors_count > 0)
                lbl_factor_code.Text = Convert.ToString(Convert.ToInt32(dgv_factors.Rows[factors_count - 1].Cells[0].Value) + 1);
            else
                lbl_factor_code.Text = "1";
        }

        private void Btn_factor_submit_Click(object sender, EventArgs e)
        {
            Get_factor_date();
            int customer_code, factor_code, food_code;
            short food_amount;
            int factor_RowCount = dgv_factor.Rows.Count;
            if (factor_RowCount > 0 &&
                input_factor_customer_code.Text != "" &&
                lbl_factor_customer_name.Text != "کد مشتری نادرست است"
                )
            {
                DialogResult add_order = MessageBox.Show("از صحت اطلاعات وارد شده اطمینان دارید؟", "ثبت سفارش", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (add_order == DialogResult.Yes)
                {
                    factor_code = Convert.ToInt32(lbl_factor_code.Text);
                    customer_code = Convert.ToInt32(input_customer_code.Text);
                    DateTime factor_date = DateTime.Now;
                    try
                    {
                        orderTableAdapter.InsertQuery_order(factor_code, customer_code, factor_date, factor_date);
                    }
                    catch
                    {
                        MessageBox.Show("متاسفانه اضافه کردن رکورد جدید به جدول\n« order »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        orderTableAdapter.Fill(akoladResturantDataSet_order.order);
                    }
                    catch
                    {
                        MessageBox.Show("متاسفانه ارتباط با جدول\n« order »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    for (int i = 0; i < factor_RowCount; i++)
                    {
                        food_code = Convert.ToInt32(dgv_factor.Rows[i].Cells["factor_food_code"].Value);
                        food_amount = Convert.ToInt16(dgv_factor.Rows[i].Cells["factor_food_amount"].Value);
                        try
                        {
                            factorTableAdapter.InsertQuery_factor(factor_code, food_code, food_amount);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه اضافه کردن رکورد جدید به جدول\n« factor »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        try
                        {
                            factorTableAdapter.Fill(akoladResturantDataSet_order.factor);
                        }
                        catch
                        {
                            MessageBox.Show("متاسفانه ارتباط با جدول\n« factor »\nاز پایگاه داده با خطا مواجه شد", "خطای ارتباط با پایگاه داده", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("سفارش شما با کد « " + factor_code.ToString() + " » ثبت شد.", "ثبت سفارش", MessageBoxButtons.OK);
                    Btn_factor_empty_Click(this, new EventArgs());
                }
            }
            else if (!(factor_RowCount > 0))
                MessageBox.Show("ابتدا از جدول غذاها، مواردی را به فاکتور اضافه کنید", "خطا", MessageBoxButtons.OK);
            else if (input_factor_customer_code.Text == "")
                MessageBox.Show("کد مشتری وارد نشده است", "خطا", MessageBoxButtons.OK);
            else if (lbl_factor_customer_name.Text != "کد مشتری نادرست است")
                MessageBox.Show("کد مشتری به درستی وارد نشده است", "خطا", MessageBoxButtons.OK);
        }
        private void Btn_factor_empty_Click(object sender, EventArgs e)
        {
            dgv_factor.Rows.Clear();
            input_factor_customer_code.Text = "";
            input_factor_food_amount.Text = "";
            input_factor_food_code.Text = "";
        }
        public void Get_factor_date()
        {
            string shortDate = DateTime.Now.ToShortDateString();
            List<string> ListString_shortDate = shortDate.Split('/').Select(p => p.Trim()).ToList();
            ListString_shortDate.Reverse();
            lbl_factor_date.Text = string.Join("/", ListString_shortDate.ToArray());
            lbl_factor_time.Text = DateTime.Now.ToShortTimeString();
        }

    }
}
