namespace Rstaurant_MahdiAskarpoor
{
    partial class form_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.btn_showPassword = new System.Windows.Forms.Button();
            this.lbl_forgetPasswordLink = new System.Windows.Forms.LinkLabel();
            this.img_login = new System.Windows.Forms.PictureBox();
            this.lbl_detail = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.pnl_password = new System.Windows.Forms.PictureBox();
            this.pnl_username = new System.Windows.Forms.PictureBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.input_username = new System.Windows.Forms.TextBox();
            this.akoladResturantDataSet_employee = new Rstaurant_MahdiAskarpoor.AkoladResturantDataSet_employee();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Rstaurant_MahdiAskarpoor.AkoladResturantDataSet_employeeTableAdapters.employeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akoladResturantDataSet_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showPassword
            // 
            this.btn_showPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_showPassword.BackgroundImage")));
            this.btn_showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_showPassword.FlatAppearance.BorderSize = 0;
            this.btn_showPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showPassword.Location = new System.Drawing.Point(283, 276);
            this.btn_showPassword.Name = "btn_showPassword";
            this.btn_showPassword.Size = new System.Drawing.Size(40, 40);
            this.btn_showPassword.TabIndex = 13;
            this.btn_showPassword.UseVisualStyleBackColor = true;
            this.btn_showPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseDown);
            this.btn_showPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_showPassword_MouseUp);
            // 
            // lbl_forgetPasswordLink
            // 
            this.lbl_forgetPasswordLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.lbl_forgetPasswordLink.AutoSize = true;
            this.lbl_forgetPasswordLink.BackColor = System.Drawing.Color.Transparent;
            this.lbl_forgetPasswordLink.Font = new System.Drawing.Font("Vazir Light", 10F);
            this.lbl_forgetPasswordLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(222)))), ((int)(((byte)(228)))));
            this.lbl_forgetPasswordLink.Location = new System.Drawing.Point(239, 352);
            this.lbl_forgetPasswordLink.Name = "lbl_forgetPasswordLink";
            this.lbl_forgetPasswordLink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_forgetPasswordLink.Size = new System.Drawing.Size(83, 22);
            this.lbl_forgetPasswordLink.TabIndex = 3;
            this.lbl_forgetPasswordLink.TabStop = true;
            this.lbl_forgetPasswordLink.Text = "فراموشی رمز ";
            this.lbl_forgetPasswordLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_forgetPasswordLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // img_login
            // 
            this.img_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_login.BackgroundImage")));
            this.img_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_login.Location = new System.Drawing.Point(363, 75);
            this.img_login.Name = "img_login";
            this.img_login.Size = new System.Drawing.Size(258, 322);
            this.img_login.TabIndex = 11;
            this.img_login.TabStop = false;
            // 
            // lbl_detail
            // 
            this.lbl_detail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_detail.Font = new System.Drawing.Font("Vazir Light", 10F);
            this.lbl_detail.ForeColor = System.Drawing.Color.White;
            this.lbl_detail.Location = new System.Drawing.Point(114, 131);
            this.lbl_detail.MaximumSize = new System.Drawing.Size(370, 0);
            this.lbl_detail.Name = "lbl_detail";
            this.lbl_detail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_detail.Size = new System.Drawing.Size(214, 27);
            this.lbl_detail.TabIndex = 10;
            this.lbl_detail.Text = "نام کاربری و رمز عبور خود را وارد کنید";
            this.lbl_detail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Vazir", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(204, 92);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_title.Size = new System.Drawing.Size(130, 38);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "خوش آمدید";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Vazir Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(105, 341);
            this.btn_login.Name = "btn_login";
            this.btn_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_login.Size = new System.Drawing.Size(90, 42);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "ورود";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pnl_password
            // 
            this.pnl_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnl_password.Location = new System.Drawing.Point(105, 276);
            this.pnl_password.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_password.Name = "pnl_password";
            this.pnl_password.Size = new System.Drawing.Size(218, 40);
            this.pnl_password.TabIndex = 7;
            this.pnl_password.TabStop = false;
            this.pnl_password.Click += new System.EventHandler(this.pnl_password_Click);
            // 
            // pnl_username
            // 
            this.pnl_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnl_username.Location = new System.Drawing.Point(105, 201);
            this.pnl_username.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_username.Name = "pnl_username";
            this.pnl_username.Size = new System.Drawing.Size(218, 40);
            this.pnl_username.TabIndex = 6;
            this.pnl_username.TabStop = false;
            this.pnl_username.Click += new System.EventHandler(this.pnl_username_Click);
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.Color.White;
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_password.Font = new System.Drawing.Font("Vazir Light", 8F);
            this.input_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.input_password.Location = new System.Drawing.Point(113, 288);
            this.input_password.Margin = new System.Windows.Forms.Padding(8);
            this.input_password.MaximumSize = new System.Drawing.Size(200, 15);
            this.input_password.MinimumSize = new System.Drawing.Size(200, 15);
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '●';
            this.input_password.Size = new System.Drawing.Size(200, 15);
            this.input_password.TabIndex = 1;
            this.input_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_username_KeyDown);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Vazir Medium", 10F);
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.lbl_password.Location = new System.Drawing.Point(262, 251);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_password.Size = new System.Drawing.Size(62, 22);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "رمز عبور :";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Vazir Medium", 10F);
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.lbl_username.Location = new System.Drawing.Point(251, 176);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_username.Size = new System.Drawing.Size(73, 22);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "نام کاربری :";
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.Color.White;
            this.input_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_username.Font = new System.Drawing.Font("Vazir Medium", 11F);
            this.input_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.input_username.Location = new System.Drawing.Point(113, 210);
            this.input_username.Margin = new System.Windows.Forms.Padding(8);
            this.input_username.MaximumSize = new System.Drawing.Size(200, 30);
            this.input_username.MinimumSize = new System.Drawing.Size(200, 30);
            this.input_username.Name = "input_username";
            this.input_username.Size = new System.Drawing.Size(200, 30);
            this.input_username.TabIndex = 0;
            this.input_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_username_KeyDown);
            // 
            // akoladResturantDataSet_employee
            // 
            this.akoladResturantDataSet_employee.DataSetName = "AkoladResturantDataSet_employee";
            this.akoladResturantDataSet_employee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.akoladResturantDataSet_employee;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // form_login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(706, 471);
            this.Controls.Add(this.btn_showPassword);
            this.Controls.Add(this.lbl_forgetPasswordLink);
            this.Controls.Add(this.img_login);
            this.Controls.Add(this.lbl_detail);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.pnl_password);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.pnl_username);
            this.Controls.Add(this.lbl_username);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Vazir", 18F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.Name = "form_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akolad Restaurant || Login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akoladResturantDataSet_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showPassword;
        private System.Windows.Forms.LinkLabel lbl_forgetPasswordLink;
        private System.Windows.Forms.PictureBox img_login;
        private System.Windows.Forms.Label lbl_detail;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.PictureBox pnl_password;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.PictureBox pnl_username;
        private System.Windows.Forms.Label lbl_username;
        private AkoladResturantDataSet_employee akoladResturantDataSet_employee;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AkoladResturantDataSet_employeeTableAdapters.employeeTableAdapter employeeTableAdapter;
    }
}