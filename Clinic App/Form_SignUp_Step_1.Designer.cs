namespace Clinic_App
{
    partial class Form_SignUp_Step_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignUp_Step_1));
            this.Lbl_RetPwErr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_Pw_Null = new System.Windows.Forms.Label();
            this.Lbl_Role_Err = new System.Windows.Forms.Label();
            this.LblUser_Null = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.Lbl_UserErr = new System.Windows.Forms.Label();
            this.Txt_UserName = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_RetPw = new ns1.BunifuCustomLabel();
            this.Lbl_PW = new ns1.BunifuCustomLabel();
            this.Lbl_UserName = new ns1.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_UserNameCharErr = new System.Windows.Forms.Label();
            this.Txt_RetPw = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Pw = new MetroFramework.Controls.MetroTextBox();
            this.Cmb_Role = new MetroFramework.Controls.MetroComboBox();
            this.Lbl_User_small = new System.Windows.Forms.Label();
            this.Btn_Save = new ns1.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cancel = new ns1.BunifuFlatButton();
            this.Lbl_PwCounErr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_RetPwErr
            // 
            this.Lbl_RetPwErr.AutoSize = true;
            this.Lbl_RetPwErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_RetPwErr.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_RetPwErr.Location = new System.Drawing.Point(58, 445);
            this.Lbl_RetPwErr.Name = "Lbl_RetPwErr";
            this.Lbl_RetPwErr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_RetPwErr.Size = new System.Drawing.Size(205, 18);
            this.Lbl_RetPwErr.TabIndex = 72;
            this.Lbl_RetPwErr.Text = "دو کلمه عبور با یکدیگر یکسان نیستند...!";
            this.Lbl_RetPwErr.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(61, 468);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(300, 13);
            this.textBox1.TabIndex = 71;
            this.textBox1.Text = "________________________________________________________________";
            // 
            // Lbl_Pw_Null
            // 
            this.Lbl_Pw_Null.AutoSize = true;
            this.Lbl_Pw_Null.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Lbl_Pw_Null.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_Pw_Null.Location = new System.Drawing.Point(117, 445);
            this.Lbl_Pw_Null.Name = "Lbl_Pw_Null";
            this.Lbl_Pw_Null.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Pw_Null.Size = new System.Drawing.Size(165, 17);
            this.Lbl_Pw_Null.TabIndex = 70;
            this.Lbl_Pw_Null.Text = "قسمت کلمه عبور را پر کنید.";
            this.Lbl_Pw_Null.Visible = false;
            // 
            // Lbl_Role_Err
            // 
            this.Lbl_Role_Err.AutoSize = true;
            this.Lbl_Role_Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.Lbl_Role_Err.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_Role_Err.Location = new System.Drawing.Point(12, 498);
            this.Lbl_Role_Err.Name = "Lbl_Role_Err";
            this.Lbl_Role_Err.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Role_Err.Size = new System.Drawing.Size(190, 17);
            this.Lbl_Role_Err.TabIndex = 68;
            this.Lbl_Role_Err.Text = "نقش کاربر مورد نظر را انتخاب کنید...!";
            this.Lbl_Role_Err.Visible = false;
            // 
            // LblUser_Null
            // 
            this.LblUser_Null.AutoSize = true;
            this.LblUser_Null.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.LblUser_Null.ForeColor = System.Drawing.Color.Firebrick;
            this.LblUser_Null.Location = new System.Drawing.Point(7, 309);
            this.LblUser_Null.Name = "LblUser_Null";
            this.LblUser_Null.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUser_Null.Size = new System.Drawing.Size(178, 15);
            this.LblUser_Null.TabIndex = 67;
            this.LblUser_Null.Text = "لطفا یک نام کاربری برای خود انتخاب کنید.";
            this.LblUser_Null.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("A Soraya", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(249, 488);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 30);
            this.bunifuCustomLabel1.TabIndex = 64;
            this.bunifuCustomLabel1.Text = "نقش:";
            // 
            // Lbl_UserErr
            // 
            this.Lbl_UserErr.AutoSize = true;
            this.Lbl_UserErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold);
            this.Lbl_UserErr.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_UserErr.Location = new System.Drawing.Point(4, 303);
            this.Lbl_UserErr.Name = "Lbl_UserErr";
            this.Lbl_UserErr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_UserErr.Size = new System.Drawing.Size(180, 17);
            this.Lbl_UserErr.TabIndex = 63;
            this.Lbl_UserErr.Text = "این نام کاربری قبلا ثبت شده...!";
            this.Lbl_UserErr.Visible = false;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_UserName.Lines = new string[] {
        "نام کاربری را وارد کنید."};
            this.Txt_UserName.Location = new System.Drawing.Point(110, 279);
            this.Txt_UserName.MaxLength = 32767;
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.PasswordChar = '\0';
            this.Txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_UserName.SelectedText = "";
            this.Txt_UserName.Size = new System.Drawing.Size(204, 23);
            this.Txt_UserName.TabIndex = 1;
            this.Txt_UserName.Text = "نام کاربری را وارد کنید.";
            this.Txt_UserName.UseCustomForeColor = true;
            this.Txt_UserName.UseSelectable = true;
            this.Txt_UserName.Enter += new System.EventHandler(this.Txt_UserName_Enter);
            this.Txt_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UserName_KeyPress);
            this.Txt_UserName.Leave += new System.EventHandler(this.Txt_UserName_Leave);
            // 
            // Lbl_RetPw
            // 
            this.Lbl_RetPw.AutoSize = true;
            this.Lbl_RetPw.Font = new System.Drawing.Font("A Soraya", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_RetPw.Location = new System.Drawing.Point(192, 376);
            this.Lbl_RetPw.Name = "Lbl_RetPw";
            this.Lbl_RetPw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_RetPw.Size = new System.Drawing.Size(127, 30);
            this.Lbl_RetPw.TabIndex = 60;
            this.Lbl_RetPw.Text = "تکرار کلمه عبور:";
            // 
            // Lbl_PW
            // 
            this.Lbl_PW.AutoSize = true;
            this.Lbl_PW.Font = new System.Drawing.Font("A Soraya", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_PW.Location = new System.Drawing.Point(227, 309);
            this.Lbl_PW.Name = "Lbl_PW";
            this.Lbl_PW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_PW.Size = new System.Drawing.Size(90, 30);
            this.Lbl_PW.TabIndex = 59;
            this.Lbl_PW.Text = "کلمه عبور:";
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Font = new System.Drawing.Font("A Soraya", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_UserName.Location = new System.Drawing.Point(222, 242);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_UserName.Size = new System.Drawing.Size(95, 30);
            this.Lbl_UserName.TabIndex = 57;
            this.Lbl_UserName.Text = "نام کاربری:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_UserNameCharErr
            // 
            this.Lbl_UserNameCharErr.AutoSize = true;
            this.Lbl_UserNameCharErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(50)));
            this.Lbl_UserNameCharErr.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_UserNameCharErr.Location = new System.Drawing.Point(8, 249);
            this.Lbl_UserNameCharErr.Name = "Lbl_UserNameCharErr";
            this.Lbl_UserNameCharErr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_UserNameCharErr.Size = new System.Drawing.Size(165, 15);
            this.Lbl_UserNameCharErr.TabIndex = 73;
            this.Lbl_UserNameCharErr.Text = "کاراکتر های انتحاب شده معتبر نمیباشد.";
            this.Lbl_UserNameCharErr.Visible = false;
            // 
            // Txt_RetPw
            // 
            this.Txt_RetPw.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_RetPw.Lines = new string[] {
        "کلمه عبور را وارد کنید."};
            this.Txt_RetPw.Location = new System.Drawing.Point(110, 413);
            this.Txt_RetPw.MaxLength = 32767;
            this.Txt_RetPw.Name = "Txt_RetPw";
            this.Txt_RetPw.PasswordChar = '\0';
            this.Txt_RetPw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_RetPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_RetPw.SelectedText = "";
            this.Txt_RetPw.Size = new System.Drawing.Size(204, 23);
            this.Txt_RetPw.TabIndex = 3;
            this.Txt_RetPw.Text = "کلمه عبور را وارد کنید.";
            this.Txt_RetPw.UseCustomForeColor = true;
            this.Txt_RetPw.UseSelectable = true;
            this.Txt_RetPw.Enter += new System.EventHandler(this.Txt_RetPw_Enter);
            this.Txt_RetPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_RetPw_KeyPress);
            this.Txt_RetPw.Leave += new System.EventHandler(this.Txt_RetPw_Leave);
            // 
            // Txt_Pw
            // 
            this.Txt_Pw.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Pw.Lines = new string[] {
        "کلمه عبور را وارد کنید."};
            this.Txt_Pw.Location = new System.Drawing.Point(110, 346);
            this.Txt_Pw.MaxLength = 32767;
            this.Txt_Pw.Name = "Txt_Pw";
            this.Txt_Pw.PasswordChar = '\0';
            this.Txt_Pw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Pw.SelectedText = "";
            this.Txt_Pw.Size = new System.Drawing.Size(204, 23);
            this.Txt_Pw.TabIndex = 2;
            this.Txt_Pw.Text = "کلمه عبور را وارد کنید.";
            this.Txt_Pw.UseCustomForeColor = true;
            this.Txt_Pw.UseSelectable = true;
            this.Txt_Pw.Enter += new System.EventHandler(this.Txt_Pw_Enter);
            this.Txt_Pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pw_KeyPress);
            this.Txt_Pw.Leave += new System.EventHandler(this.Txt_Pw_Leave);
            // 
            // Cmb_Role
            // 
            this.Cmb_Role.BackColor = System.Drawing.Color.Gainsboro;
            this.Cmb_Role.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.Cmb_Role.ForeColor = System.Drawing.Color.SeaShell;
            this.Cmb_Role.FormattingEnabled = true;
            this.Cmb_Role.ItemHeight = 19;
            this.Cmb_Role.Location = new System.Drawing.Point(110, 536);
            this.Cmb_Role.Name = "Cmb_Role";
            this.Cmb_Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Role.Size = new System.Drawing.Size(204, 25);
            this.Cmb_Role.Style = MetroFramework.MetroColorStyle.Green;
            this.Cmb_Role.TabIndex = 74;
            this.Cmb_Role.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Cmb_Role.UseCustomBackColor = true;
            this.Cmb_Role.UseCustomForeColor = true;
            this.Cmb_Role.UseSelectable = true;
            this.Cmb_Role.UseStyleColors = true;
            this.Cmb_Role.DropDown += new System.EventHandler(this.Cmb_Role_DropDown);
            // 
            // Lbl_User_small
            // 
            this.Lbl_User_small.AutoSize = true;
            this.Lbl_User_small.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Lbl_User_small.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_User_small.Location = new System.Drawing.Point(3, 249);
            this.Lbl_User_small.Name = "Lbl_User_small";
            this.Lbl_User_small.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_User_small.Size = new System.Drawing.Size(171, 15);
            this.Lbl_User_small.TabIndex = 76;
            this.Lbl_User_small.Text = "نام انتخاب شده باید بیش از 8 حرف باشد.";
            this.Lbl_User_small.Visible = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Activecolor = System.Drawing.Color.YellowGreen;
            this.Btn_Save.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Save.BorderRadius = 0;
            this.Btn_Save.ButtonText = "ذخیره اطلاعات";
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Save.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Save.Iconimage = global::Clinic_App.Properties.Resources.Save_50;
            this.Btn_Save.Iconimage_right = null;
            this.Btn_Save.Iconimage_right_Selected = null;
            this.Btn_Save.Iconimage_Selected = null;
            this.Btn_Save.IconMarginLeft = 0;
            this.Btn_Save.IconMarginRight = 0;
            this.Btn_Save.IconRightVisible = true;
            this.Btn_Save.IconRightZoom = 0D;
            this.Btn_Save.IconVisible = true;
            this.Btn_Save.IconZoom = 90D;
            this.Btn_Save.IsTab = false;
            this.Btn_Save.Location = new System.Drawing.Point(110, 589);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Normalcolor = System.Drawing.Color.LightGreen;
            this.Btn_Save.OnHovercolor = System.Drawing.Color.YellowGreen;
            this.Btn_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Save.selected = false;
            this.Btn_Save.Size = new System.Drawing.Size(130, 48);
            this.Btn_Save.TabIndex = 75;
            this.Btn_Save.Text = "ذخیره اطلاعات";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Save.Textcolor = System.Drawing.Color.Black;
            this.Btn_Save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinic_App.Properties.Resources.Step_1_02;
            this.pictureBox1.Location = new System.Drawing.Point(61, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Activecolor = System.Drawing.Color.IndianRed;
            this.Btn_Cancel.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancel.BorderRadius = 0;
            this.Btn_Cancel.ButtonText = "لغو";
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Cancel.Iconimage = global::Clinic_App.Properties.Resources.CancelWhiteBig1;
            this.Btn_Cancel.Iconimage_right = null;
            this.Btn_Cancel.Iconimage_right_Selected = null;
            this.Btn_Cancel.Iconimage_Selected = null;
            this.Btn_Cancel.IconMarginLeft = 0;
            this.Btn_Cancel.IconMarginRight = 0;
            this.Btn_Cancel.IconRightVisible = false;
            this.Btn_Cancel.IconRightZoom = 0D;
            this.Btn_Cancel.IconVisible = true;
            this.Btn_Cancel.IconZoom = 50D;
            this.Btn_Cancel.IsTab = false;
            this.Btn_Cancel.Location = new System.Drawing.Point(246, 589);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Normalcolor = System.Drawing.Color.Crimson;
            this.Btn_Cancel.OnHovercolor = System.Drawing.Color.LightCoral;
            this.Btn_Cancel.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_Cancel.selected = false;
            this.Btn_Cancel.Size = new System.Drawing.Size(68, 48);
            this.Btn_Cancel.TabIndex = 62;
            this.Btn_Cancel.Text = "لغو";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancel.Textcolor = System.Drawing.Color.White;
            this.Btn_Cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lbl_PwCounErr
            // 
            this.Lbl_PwCounErr.AutoSize = true;
            this.Lbl_PwCounErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Lbl_PwCounErr.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_PwCounErr.Location = new System.Drawing.Point(3, 376);
            this.Lbl_PwCounErr.Name = "Lbl_PwCounErr";
            this.Lbl_PwCounErr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_PwCounErr.Size = new System.Drawing.Size(180, 16);
            this.Lbl_PwCounErr.TabIndex = 77;
            this.Lbl_PwCounErr.Text = "کلمه عبور باید بیش از 8 حرف باشد.";
            this.Lbl_PwCounErr.Visible = false;
            // 
            // Form_SignUp_Step_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 680);
            this.Controls.Add(this.Lbl_PwCounErr);
            this.Controls.Add(this.Lbl_User_small);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Cmb_Role);
            this.Controls.Add(this.Lbl_UserNameCharErr);
            this.Controls.Add(this.Lbl_RetPwErr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_Pw_Null);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Role_Err);
            this.Controls.Add(this.LblUser_Null);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Lbl_UserErr);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Lbl_RetPw);
            this.Controls.Add(this.Txt_RetPw);
            this.Controls.Add(this.Lbl_PW);
            this.Controls.Add(this.Txt_Pw);
            this.Controls.Add(this.Lbl_UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SignUp_Step_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "فرم ثبت نام";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SignUp_Step_1_FormClosing);
            this.Load += new System.EventHandler(this.Form_SignUp_Step_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_RetPwErr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_Pw_Null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Role_Err;
        private System.Windows.Forms.Label LblUser_Null;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label Lbl_UserErr;
        private ns1.BunifuFlatButton Btn_Cancel;
        private MetroFramework.Controls.MetroTextBox Txt_UserName;
        private ns1.BunifuCustomLabel Lbl_RetPw;
        private ns1.BunifuCustomLabel Lbl_PW;
        private ns1.BunifuCustomLabel Lbl_UserName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_UserNameCharErr;
        private MetroFramework.Controls.MetroTextBox Txt_RetPw;
        private MetroFramework.Controls.MetroTextBox Txt_Pw;
        private MetroFramework.Controls.MetroComboBox Cmb_Role;
        private ns1.BunifuFlatButton Btn_Save;
        private System.Windows.Forms.Label Lbl_User_small;
        private System.Windows.Forms.Label Lbl_PwCounErr;
    }
}