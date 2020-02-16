namespace Clinic_App
{
    partial class Form_SignUp
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
            this.Lbl_UserName = new ns1.BunifuCustomLabel();
            this.Lbl_PW = new ns1.BunifuCustomLabel();
            this.Txt_Pw = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_RetPw = new ns1.BunifuCustomLabel();
            this.Txt_RetPw = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Mob = new ns1.BunifuCustomLabel();
            this.Txt_Mob = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Adrs = new ns1.BunifuCustomLabel();
            this.Txt_Adrs = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Email = new ns1.BunifuCustomLabel();
            this.Txt_Email = new MetroFramework.Controls.MetroTextBox();
            this.Txt_UserName = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_UserErr = new System.Windows.Forms.Label();
            this.Lbl_RetPwErr = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.Txt_Role = new MetroFramework.Controls.MetroTextBox();
            this.Cmb_Role = new System.Windows.Forms.ComboBox();
            this.Txt_NameAndFamily = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_NameAndFamily = new ns1.BunifuCustomLabel();
            this.LblUser_Null = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cancel = new ns1.BunifuFlatButton();
            this.Btn_Save = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserName.Location = new System.Drawing.Point(222, 116);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_UserName.Size = new System.Drawing.Size(62, 17);
            this.Lbl_UserName.TabIndex = 1;
            this.Lbl_UserName.Text = "نام کاربری:";
            this.Lbl_UserName.Visible = false;
            // 
            // Lbl_PW
            // 
            this.Lbl_PW.AutoSize = true;
            this.Lbl_PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PW.Location = new System.Drawing.Point(225, 172);
            this.Lbl_PW.Name = "Lbl_PW";
            this.Lbl_PW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_PW.Size = new System.Drawing.Size(59, 17);
            this.Lbl_PW.TabIndex = 3;
            this.Lbl_PW.Text = "کلمه عبور:";
            this.Lbl_PW.UseWaitCursor = true;
            this.Lbl_PW.Visible = false;
            // 
            // Txt_Pw
            // 
            this.Txt_Pw.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Pw.Lines = new string[] {
        "کلمه عبور را وارد کنید."};
            this.Txt_Pw.Location = new System.Drawing.Point(96, 197);
            this.Txt_Pw.MaxLength = 32767;
            this.Txt_Pw.Name = "Txt_Pw";
            this.Txt_Pw.PasswordChar = '\0';
            this.Txt_Pw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Pw.SelectedText = "";
            this.Txt_Pw.Size = new System.Drawing.Size(188, 23);
            this.Txt_Pw.TabIndex = 1;
            this.Txt_Pw.Text = "کلمه عبور را وارد کنید.";
            this.Txt_Pw.UseCustomForeColor = true;
            this.Txt_Pw.UseSelectable = true;
            this.Txt_Pw.UseWaitCursor = true;
            this.Txt_Pw.Visible = false;
            this.Txt_Pw.Enter += new System.EventHandler(this.Txt_Pw_Enter);
            // 
            // Lbl_RetPw
            // 
            this.Lbl_RetPw.AutoSize = true;
            this.Lbl_RetPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RetPw.Location = new System.Drawing.Point(195, 228);
            this.Lbl_RetPw.Name = "Lbl_RetPw";
            this.Lbl_RetPw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_RetPw.Size = new System.Drawing.Size(89, 17);
            this.Lbl_RetPw.TabIndex = 5;
            this.Lbl_RetPw.Text = "تکرار کلمه عبور:";
            this.Lbl_RetPw.UseWaitCursor = true;
            this.Lbl_RetPw.Visible = false;
            // 
            // Txt_RetPw
            // 
            this.Txt_RetPw.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_RetPw.Lines = new string[] {
        "کلمه عبور را وارد کنید."};
            this.Txt_RetPw.Location = new System.Drawing.Point(96, 253);
            this.Txt_RetPw.MaxLength = 32767;
            this.Txt_RetPw.Name = "Txt_RetPw";
            this.Txt_RetPw.PasswordChar = '\0';
            this.Txt_RetPw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_RetPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_RetPw.SelectedText = "";
            this.Txt_RetPw.Size = new System.Drawing.Size(188, 23);
            this.Txt_RetPw.TabIndex = 2;
            this.Txt_RetPw.Text = "کلمه عبور را وارد کنید.";
            this.Txt_RetPw.UseCustomForeColor = true;
            this.Txt_RetPw.UseSelectable = true;
            this.Txt_RetPw.UseWaitCursor = true;
            this.Txt_RetPw.Visible = false;
            this.Txt_RetPw.Enter += new System.EventHandler(this.Txt_RetPw_Enter);
            // 
            // Lbl_Mob
            // 
            this.Lbl_Mob.AutoSize = true;
            this.Lbl_Mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mob.Location = new System.Drawing.Point(216, 284);
            this.Lbl_Mob.Name = "Lbl_Mob";
            this.Lbl_Mob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Mob.Size = new System.Drawing.Size(68, 17);
            this.Lbl_Mob.TabIndex = 7;
            this.Lbl_Mob.Text = "شماره همراه:";
            this.Lbl_Mob.UseWaitCursor = true;
            this.Lbl_Mob.Visible = false;
            // 
            // Txt_Mob
            // 
            this.Txt_Mob.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Mob.Lines = new string[] {
        "شماره همراه را وارد کنید."};
            this.Txt_Mob.Location = new System.Drawing.Point(96, 309);
            this.Txt_Mob.MaxLength = 32767;
            this.Txt_Mob.Name = "Txt_Mob";
            this.Txt_Mob.PasswordChar = '\0';
            this.Txt_Mob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Mob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Mob.SelectedText = "";
            this.Txt_Mob.Size = new System.Drawing.Size(188, 23);
            this.Txt_Mob.TabIndex = 3;
            this.Txt_Mob.Text = "شماره همراه را وارد کنید.";
            this.Txt_Mob.UseCustomForeColor = true;
            this.Txt_Mob.UseSelectable = true;
            this.Txt_Mob.Visible = false;
            this.Txt_Mob.Enter += new System.EventHandler(this.Txt_Mob_Enter);
            // 
            // Lbl_Adrs
            // 
            this.Lbl_Adrs.AutoSize = true;
            this.Lbl_Adrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Adrs.Location = new System.Drawing.Point(245, 396);
            this.Lbl_Adrs.Name = "Lbl_Adrs";
            this.Lbl_Adrs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Adrs.Size = new System.Drawing.Size(39, 17);
            this.Lbl_Adrs.TabIndex = 9;
            this.Lbl_Adrs.Text = "آدرس:";
            this.Lbl_Adrs.Visible = false;
            // 
            // Txt_Adrs
            // 
            this.Txt_Adrs.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Adrs.Lines = new string[] {
        "آدرس را وارد کنید."};
            this.Txt_Adrs.Location = new System.Drawing.Point(96, 421);
            this.Txt_Adrs.MaxLength = 32767;
            this.Txt_Adrs.Name = "Txt_Adrs";
            this.Txt_Adrs.PasswordChar = '\0';
            this.Txt_Adrs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Adrs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Adrs.SelectedText = "";
            this.Txt_Adrs.Size = new System.Drawing.Size(188, 23);
            this.Txt_Adrs.TabIndex = 4;
            this.Txt_Adrs.Text = "آدرس را وارد کنید.";
            this.Txt_Adrs.UseCustomForeColor = true;
            this.Txt_Adrs.UseSelectable = true;
            this.Txt_Adrs.Visible = false;
            this.Txt_Adrs.Enter += new System.EventHandler(this.Txt_Adrs_Enter);
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Email.Location = new System.Drawing.Point(251, 452);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Email.Size = new System.Drawing.Size(33, 17);
            this.Lbl_Email.TabIndex = 11;
            this.Lbl_Email.Text = "ایمیل:";
            this.Lbl_Email.Visible = false;
            // 
            // Txt_Email
            // 
            this.Txt_Email.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Email.Lines = new string[] {
        "ایمیل را وارد کنید."};
            this.Txt_Email.Location = new System.Drawing.Point(96, 477);
            this.Txt_Email.MaxLength = 32767;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.PasswordChar = '\0';
            this.Txt_Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Email.SelectedText = "";
            this.Txt_Email.Size = new System.Drawing.Size(188, 23);
            this.Txt_Email.TabIndex = 5;
            this.Txt_Email.Text = "ایمیل را وارد کنید.";
            this.Txt_Email.UseCustomForeColor = true;
            this.Txt_Email.UseSelectable = true;
            this.Txt_Email.Visible = false;
            this.Txt_Email.Enter += new System.EventHandler(this.Txt_Email_Enter);
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_UserName.Lines = new string[] {
        "نام کاربری را وارد کنید."};
            this.Txt_UserName.Location = new System.Drawing.Point(96, 141);
            this.Txt_UserName.MaxLength = 32767;
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.PasswordChar = '\0';
            this.Txt_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_UserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_UserName.SelectedText = "";
            this.Txt_UserName.Size = new System.Drawing.Size(188, 23);
            this.Txt_UserName.TabIndex = 0;
            this.Txt_UserName.Text = "نام کاربری را وارد کنید.";
            this.Txt_UserName.UseCustomForeColor = true;
            this.Txt_UserName.UseSelectable = true;
            this.Txt_UserName.Visible = false;
            this.Txt_UserName.Enter += new System.EventHandler(this.Txt_UserName_Enter);
            // 
            // Lbl_UserErr
            // 
            this.Lbl_UserErr.AutoSize = true;
            this.Lbl_UserErr.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_UserErr.Location = new System.Drawing.Point(59, 174);
            this.Lbl_UserErr.Name = "Lbl_UserErr";
            this.Lbl_UserErr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_UserErr.Size = new System.Drawing.Size(149, 13);
            this.Lbl_UserErr.TabIndex = 12;
            this.Lbl_UserErr.Text = "این نام کاربری قبلا ثبت شده...!";
            this.Lbl_UserErr.Visible = false;
            // 
            // Lbl_RetPwErr
            // 
            this.Lbl_RetPwErr.AutoSize = true;
            this.Lbl_RetPwErr.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_RetPwErr.Location = new System.Drawing.Point(1, 230);
            this.Lbl_RetPwErr.Name = "Lbl_RetPwErr";
            this.Lbl_RetPwErr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_RetPwErr.Size = new System.Drawing.Size(191, 13);
            this.Lbl_RetPwErr.TabIndex = 13;
            this.Lbl_RetPwErr.Text = "دو کلمه عبور با یکدیگر یکسان نیستند...!";
            this.Lbl_RetPwErr.Visible = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(253, 340);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(31, 17);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "نقش:";
            this.bunifuCustomLabel1.Visible = false;
            // 
            // Txt_Role
            // 
            this.Txt_Role.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Role.Lines = new string[] {
        "نقش کاربر را انتخاب کنید."};
            this.Txt_Role.Location = new System.Drawing.Point(96, 365);
            this.Txt_Role.MaxLength = 32767;
            this.Txt_Role.Name = "Txt_Role";
            this.Txt_Role.PasswordChar = '\0';
            this.Txt_Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Role.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Role.SelectedText = "";
            this.Txt_Role.Size = new System.Drawing.Size(188, 23);
            this.Txt_Role.TabIndex = 16;
            this.Txt_Role.Text = "نقش کاربر را انتخاب کنید.";
            this.Txt_Role.UseCustomForeColor = true;
            this.Txt_Role.UseSelectable = true;
            this.Txt_Role.Visible = false;
            this.Txt_Role.Enter += new System.EventHandler(this.Txt_Role_Enter);
            // 
            // Cmb_Role
            // 
            this.Cmb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Role.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmb_Role.FormattingEnabled = true;
            this.Cmb_Role.Location = new System.Drawing.Point(96, 367);
            this.Cmb_Role.Name = "Cmb_Role";
            this.Cmb_Role.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Role.Size = new System.Drawing.Size(127, 21);
            this.Cmb_Role.TabIndex = 18;
            this.Cmb_Role.Visible = false;
            // 
            // Txt_NameAndFamily
            // 
            this.Txt_NameAndFamily.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_NameAndFamily.Lines = new string[] {
        "نام و نام خانوادگی را وارد کنید."};
            this.Txt_NameAndFamily.Location = new System.Drawing.Point(96, 85);
            this.Txt_NameAndFamily.MaxLength = 32767;
            this.Txt_NameAndFamily.Name = "Txt_NameAndFamily";
            this.Txt_NameAndFamily.PasswordChar = '\0';
            this.Txt_NameAndFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_NameAndFamily.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_NameAndFamily.SelectedText = "";
            this.Txt_NameAndFamily.Size = new System.Drawing.Size(188, 23);
            this.Txt_NameAndFamily.TabIndex = 19;
            this.Txt_NameAndFamily.Text = "نام و نام خانوادگی را وارد کنید.";
            this.Txt_NameAndFamily.UseCustomForeColor = true;
            this.Txt_NameAndFamily.UseSelectable = true;
            this.Txt_NameAndFamily.Visible = false;
            this.Txt_NameAndFamily.Enter += new System.EventHandler(this.Txt_NameAndFamily_Enter);
            // 
            // Lbl_NameAndFamily
            // 
            this.Lbl_NameAndFamily.AutoSize = true;
            this.Lbl_NameAndFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NameAndFamily.Location = new System.Drawing.Point(190, 60);
            this.Lbl_NameAndFamily.Name = "Lbl_NameAndFamily";
            this.Lbl_NameAndFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_NameAndFamily.Size = new System.Drawing.Size(94, 17);
            this.Lbl_NameAndFamily.TabIndex = 20;
            this.Lbl_NameAndFamily.Text = "نام و نام خانوادگی:";
            this.Lbl_NameAndFamily.Visible = false;
            // 
            // LblUser_Null
            // 
            this.LblUser_Null.AutoSize = true;
            this.LblUser_Null.ForeColor = System.Drawing.Color.Firebrick;
            this.LblUser_Null.Location = new System.Drawing.Point(7, 405);
            this.LblUser_Null.Name = "LblUser_Null";
            this.LblUser_Null.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUser_Null.Size = new System.Drawing.Size(211, 13);
            this.LblUser_Null.TabIndex = 21;
            this.LblUser_Null.Text = "لطفا یک نام کاربری برای حود انتخاب کنید....!";
            this.LblUser_Null.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
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
            this.Btn_Cancel.Iconimage = global::Clinic_App.Properties.Resources.Very_Basic_Cancel;
            this.Btn_Cancel.Iconimage_right = null;
            this.Btn_Cancel.Iconimage_right_Selected = null;
            this.Btn_Cancel.Iconimage_Selected = null;
            this.Btn_Cancel.IconMarginLeft = 0;
            this.Btn_Cancel.IconMarginRight = 0;
            this.Btn_Cancel.IconRightVisible = false;
            this.Btn_Cancel.IconRightZoom = 0D;
            this.Btn_Cancel.IconVisible = true;
            this.Btn_Cancel.IconZoom = 60D;
            this.Btn_Cancel.IsTab = false;
            this.Btn_Cancel.Location = new System.Drawing.Point(221, 527);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Normalcolor = System.Drawing.Color.Crimson;
            this.Btn_Cancel.OnHovercolor = System.Drawing.Color.LightCoral;
            this.Btn_Cancel.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_Cancel.selected = false;
            this.Btn_Cancel.Size = new System.Drawing.Size(63, 48);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "لغو";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancel.Textcolor = System.Drawing.Color.White;
            this.Btn_Cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Btn_Save.IconRightVisible = false;
            this.Btn_Save.IconRightZoom = 0D;
            this.Btn_Save.IconVisible = true;
            this.Btn_Save.IconZoom = 60D;
            this.Btn_Save.IsTab = false;
            this.Btn_Save.Location = new System.Drawing.Point(96, 527);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Normalcolor = System.Drawing.Color.LightGreen;
            this.Btn_Save.OnHovercolor = System.Drawing.Color.YellowGreen;
            this.Btn_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Save.selected = false;
            this.Btn_Save.Size = new System.Drawing.Size(119, 48);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "ذخیره اطلاعات";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Save.Textcolor = System.Drawing.Color.Black;
            this.Btn_Save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Visible = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblUser_Null);
            this.Controls.Add(this.Txt_NameAndFamily);
            this.Controls.Add(this.Lbl_NameAndFamily);
            this.Controls.Add(this.Cmb_Role);
            this.Controls.Add(this.Txt_Role);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Lbl_RetPwErr);
            this.Controls.Add(this.Lbl_UserErr);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Adrs);
            this.Controls.Add(this.Txt_Adrs);
            this.Controls.Add(this.Lbl_Mob);
            this.Controls.Add(this.Txt_Mob);
            this.Controls.Add(this.Lbl_RetPw);
            this.Controls.Add(this.Txt_RetPw);
            this.Controls.Add(this.Lbl_PW);
            this.Controls.Add(this.Txt_Pw);
            this.Controls.Add(this.Lbl_UserName);
            this.Name = "Form_SignUp";
            this.Text = "فرم ثبت نام";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomLabel Lbl_UserName;
        private ns1.BunifuCustomLabel Lbl_PW;
        private MetroFramework.Controls.MetroTextBox Txt_Pw;
        private ns1.BunifuCustomLabel Lbl_RetPw;
        private MetroFramework.Controls.MetroTextBox Txt_RetPw;
        private ns1.BunifuCustomLabel Lbl_Mob;
        private MetroFramework.Controls.MetroTextBox Txt_Mob;
        private ns1.BunifuCustomLabel Lbl_Adrs;
        private MetroFramework.Controls.MetroTextBox Txt_Adrs;
        private ns1.BunifuCustomLabel Lbl_Email;
        private MetroFramework.Controls.MetroTextBox Txt_Email;
        private MetroFramework.Controls.MetroTextBox Txt_UserName;
        private ns1.BunifuFlatButton Btn_Save;
        private ns1.BunifuFlatButton Btn_Cancel;
        private System.Windows.Forms.Label Lbl_UserErr;
        private System.Windows.Forms.Label Lbl_RetPwErr;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_Role;
        private System.Windows.Forms.ComboBox Cmb_Role;
        private MetroFramework.Controls.MetroTextBox Txt_NameAndFamily;
        private ns1.BunifuCustomLabel Lbl_NameAndFamily;
        private System.Windows.Forms.Label LblUser_Null;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}