namespace Clinic_App
{
    partial class Form_SignUp_Step_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignUp_Step_2));
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.Txt_NameAndFamily = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_NameAndFamily = new ns1.BunifuCustomLabel();
            this.Lbl_Email = new ns1.BunifuCustomLabel();
            this.Txt_Email = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Adrs = new ns1.BunifuCustomLabel();
            this.Txt_Adrs = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Mob = new ns1.BunifuCustomLabel();
            this.Txt_Mob = new MetroFramework.Controls.MetroTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PB_UploadPic = new System.Windows.Forms.PictureBox();
            this.Btn_Browse = new ns1.BunifuThinButton2();
            this.PB_User_Prv = new System.Windows.Forms.PictureBox();
            this.PB_Back = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_EmailErr = new System.Windows.Forms.Label();
            this.Lbl_PhoneNo_Null_Err = new System.Windows.Forms.Label();
            this.Btn_Save = new ns1.BunifuFlatButton();
            this.Btn_Cancel = new ns1.BunifuFlatButton();
            this.Lbl_Family_Null_Err = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UploadPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_User_Prv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(181, 504);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(115, 17);
            this.bunifuCustomLabel1.TabIndex = 70;
            this.bunifuCustomLabel1.Text = "آپلود تصویر کاربر:";
            // 
            // Txt_NameAndFamily
            // 
            this.Txt_NameAndFamily.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_NameAndFamily.Lines = new string[] {
        "نام و نام خانوادگی را وارد کنید."};
            this.Txt_NameAndFamily.Location = new System.Drawing.Point(110, 280);
            this.Txt_NameAndFamily.MaxLength = 32767;
            this.Txt_NameAndFamily.Name = "Txt_NameAndFamily";
            this.Txt_NameAndFamily.PasswordChar = '\0';
            this.Txt_NameAndFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_NameAndFamily.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_NameAndFamily.SelectedText = "";
            this.Txt_NameAndFamily.Size = new System.Drawing.Size(204, 23);
            this.Txt_NameAndFamily.TabIndex = 0;
            this.Txt_NameAndFamily.Text = "نام و نام خانوادگی را وارد کنید.";
            this.Txt_NameAndFamily.UseCustomForeColor = true;
            this.Txt_NameAndFamily.UseSelectable = true;
            this.Txt_NameAndFamily.Enter += new System.EventHandler(this.Txt_NameAndFamily_Enter);
            this.Txt_NameAndFamily.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NameAndFamily_KeyPress);
            this.Txt_NameAndFamily.Leave += new System.EventHandler(this.Txt_NameAndFamily_Leave);
            // 
            // Lbl_NameAndFamily
            // 
            this.Lbl_NameAndFamily.AutoSize = true;
            this.Lbl_NameAndFamily.Font = new System.Drawing.Font("Far.Homa", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_NameAndFamily.Location = new System.Drawing.Point(178, 244);
            this.Lbl_NameAndFamily.Name = "Lbl_NameAndFamily";
            this.Lbl_NameAndFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_NameAndFamily.Size = new System.Drawing.Size(142, 35);
            this.Lbl_NameAndFamily.TabIndex = 66;
            this.Lbl_NameAndFamily.Text = "نام و نام خانوادگی:";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Far.Homa", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_Email.Location = new System.Drawing.Point(261, 425);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Email.Size = new System.Drawing.Size(59, 35);
            this.Lbl_Email.TabIndex = 65;
            this.Lbl_Email.Text = "ایمیل:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Email.Lines = new string[] {
        "ایمیل را وارد کنید."};
            this.Txt_Email.Location = new System.Drawing.Point(110, 462);
            this.Txt_Email.MaxLength = 32767;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.PasswordChar = '\0';
            this.Txt_Email.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Email.SelectedText = "";
            this.Txt_Email.Size = new System.Drawing.Size(204, 23);
            this.Txt_Email.TabIndex = 3;
            this.Txt_Email.Text = "ایمیل را وارد کنید.";
            this.Txt_Email.UseCustomForeColor = true;
            this.Txt_Email.UseSelectable = true;
            this.Txt_Email.Enter += new System.EventHandler(this.Txt_Email_Enter);
            this.Txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Email_KeyPress);
            this.Txt_Email.Leave += new System.EventHandler(this.Txt_Email_Leave);
            // 
            // Lbl_Adrs
            // 
            this.Lbl_Adrs.AutoSize = true;
            this.Lbl_Adrs.Font = new System.Drawing.Font("Far.Homa", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_Adrs.Location = new System.Drawing.Point(261, 304);
            this.Lbl_Adrs.Name = "Lbl_Adrs";
            this.Lbl_Adrs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Adrs.Size = new System.Drawing.Size(59, 35);
            this.Lbl_Adrs.TabIndex = 64;
            this.Lbl_Adrs.Text = "آدرس:";
            // 
            // Txt_Adrs
            // 
            this.Txt_Adrs.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Adrs.Lines = new string[] {
        "آدرس را وارد کنید."};
            this.Txt_Adrs.Location = new System.Drawing.Point(110, 342);
            this.Txt_Adrs.MaxLength = 32767;
            this.Txt_Adrs.Name = "Txt_Adrs";
            this.Txt_Adrs.PasswordChar = '\0';
            this.Txt_Adrs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Adrs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Adrs.SelectedText = "";
            this.Txt_Adrs.Size = new System.Drawing.Size(204, 23);
            this.Txt_Adrs.TabIndex = 1;
            this.Txt_Adrs.Text = "آدرس را وارد کنید.";
            this.Txt_Adrs.UseCustomForeColor = true;
            this.Txt_Adrs.UseSelectable = true;
            this.Txt_Adrs.Enter += new System.EventHandler(this.Txt_Adrs_Enter);
            this.Txt_Adrs.Leave += new System.EventHandler(this.Txt_Adrs_Leave);
            // 
            // Lbl_Mob
            // 
            this.Lbl_Mob.AutoSize = true;
            this.Lbl_Mob.Font = new System.Drawing.Font("Far.Homa", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_Mob.Location = new System.Drawing.Point(215, 365);
            this.Lbl_Mob.Name = "Lbl_Mob";
            this.Lbl_Mob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Mob.Size = new System.Drawing.Size(105, 35);
            this.Lbl_Mob.TabIndex = 63;
            this.Lbl_Mob.Text = "شماره همراه:";
            this.Lbl_Mob.UseWaitCursor = true;
            // 
            // Txt_Mob
            // 
            this.Txt_Mob.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Mob.Lines = new string[] {
        "شماره همراه را وارد کنید."};
            this.Txt_Mob.Location = new System.Drawing.Point(110, 401);
            this.Txt_Mob.MaxLength = 32767;
            this.Txt_Mob.Name = "Txt_Mob";
            this.Txt_Mob.PasswordChar = '\0';
            this.Txt_Mob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Mob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Mob.SelectedText = "";
            this.Txt_Mob.Size = new System.Drawing.Size(204, 23);
            this.Txt_Mob.TabIndex = 2;
            this.Txt_Mob.Text = "شماره همراه را وارد کنید.";
            this.Txt_Mob.UseCustomForeColor = true;
            this.Txt_Mob.UseSelectable = true;
            this.Txt_Mob.Enter += new System.EventHandler(this.Txt_Mob_Enter);
            this.Txt_Mob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Mob_KeyPress);
            this.Txt_Mob.Leave += new System.EventHandler(this.Txt_Mob_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PB_UploadPic
            // 
            this.PB_UploadPic.BackColor = System.Drawing.Color.Transparent;
            this.PB_UploadPic.Image = global::Clinic_App.Properties.Resources.UploadPhotos_512;
            this.PB_UploadPic.Location = new System.Drawing.Point(269, 540);
            this.PB_UploadPic.Name = "PB_UploadPic";
            this.PB_UploadPic.Size = new System.Drawing.Size(25, 22);
            this.PB_UploadPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_UploadPic.TabIndex = 72;
            this.PB_UploadPic.TabStop = false;
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.ActiveBorderThickness = 1;
            this.Btn_Browse.ActiveCornerRadius = 20;
            this.Btn_Browse.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.Btn_Browse.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_Browse.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Browse.BackgroundImage")));
            this.Btn_Browse.ButtonText = "انتخاب عکس";
            this.Btn_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Browse.Font = new System.Drawing.Font("B Koodak", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Browse.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Btn_Browse.IdleBorderThickness = 1;
            this.Btn_Browse.IdleCornerRadius = 20;
            this.Btn_Browse.IdleFillColor = System.Drawing.Color.White;
            this.Btn_Browse.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Browse.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_Browse.Location = new System.Drawing.Point(128, 530);
            this.Btn_Browse.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(134, 41);
            this.Btn_Browse.TabIndex = 4;
            this.Btn_Browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // PB_User_Prv
            // 
            this.PB_User_Prv.Image = global::Clinic_App.Properties.Resources.user_male2_512;
            this.PB_User_Prv.Location = new System.Drawing.Point(20, 489);
            this.PB_User_Prv.Name = "PB_User_Prv";
            this.PB_User_Prv.Size = new System.Drawing.Size(84, 82);
            this.PB_User_Prv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_User_Prv.TabIndex = 69;
            this.PB_User_Prv.TabStop = false;
            // 
            // PB_Back
            // 
            this.PB_Back.Image = global::Clinic_App.Properties.Resources.Button_Back_1_512;
            this.PB_Back.Location = new System.Drawing.Point(23, 589);
            this.PB_Back.Name = "PB_Back";
            this.PB_Back.Size = new System.Drawing.Size(44, 48);
            this.PB_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Back.TabIndex = 68;
            this.PB_Back.TabStop = false;
            this.PB_Back.Click += new System.EventHandler(this.pictureBox2_Click);
            this.PB_Back.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinic_App.Properties.Resources.Step_21;
            this.pictureBox1.Location = new System.Drawing.Point(60, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_EmailErr
            // 
            this.Lbl_EmailErr.AutoSize = true;
            this.Lbl_EmailErr.Font = new System.Drawing.Font("Far.Homa", 10F);
            this.Lbl_EmailErr.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_EmailErr.Location = new System.Drawing.Point(42, 433);
            this.Lbl_EmailErr.Name = "Lbl_EmailErr";
            this.Lbl_EmailErr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_EmailErr.Size = new System.Drawing.Size(173, 25);
            this.Lbl_EmailErr.TabIndex = 73;
            this.Lbl_EmailErr.Text = "این آدرس ایمیل نامعتبر میباشد.";
            this.Lbl_EmailErr.Visible = false;
            // 
            // Lbl_PhoneNo_Null_Err
            // 
            this.Lbl_PhoneNo_Null_Err.AutoSize = true;
            this.Lbl_PhoneNo_Null_Err.Font = new System.Drawing.Font("Far.Homa", 10F);
            this.Lbl_PhoneNo_Null_Err.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_PhoneNo_Null_Err.Location = new System.Drawing.Point(20, 373);
            this.Lbl_PhoneNo_Null_Err.Name = "Lbl_PhoneNo_Null_Err";
            this.Lbl_PhoneNo_Null_Err.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_PhoneNo_Null_Err.Size = new System.Drawing.Size(181, 25);
            this.Lbl_PhoneNo_Null_Err.TabIndex = 74;
            this.Lbl_PhoneNo_Null_Err.Text = "شماره همراه را به درستی وازد کنید.";
            this.Lbl_PhoneNo_Null_Err.Visible = false;
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
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "ذخیره اطلاعات";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Save.Textcolor = System.Drawing.Color.Black;
            this.Btn_Save.TextFont = new System.Drawing.Font("Far.Homa", 10F);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
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
            this.Btn_Cancel.Location = new System.Drawing.Point(246, 589);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Normalcolor = System.Drawing.Color.Crimson;
            this.Btn_Cancel.OnHovercolor = System.Drawing.Color.LightCoral;
            this.Btn_Cancel.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_Cancel.selected = false;
            this.Btn_Cancel.Size = new System.Drawing.Size(68, 48);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "لغو";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancel.Textcolor = System.Drawing.Color.White;
            this.Btn_Cancel.TextFont = new System.Drawing.Font("Far.Homa", 10F);
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lbl_Family_Null_Err
            // 
            this.Lbl_Family_Null_Err.AutoSize = true;
            this.Lbl_Family_Null_Err.Font = new System.Drawing.Font("Far.Homa", 10F);
            this.Lbl_Family_Null_Err.ForeColor = System.Drawing.Color.Firebrick;
            this.Lbl_Family_Null_Err.Location = new System.Drawing.Point(9, 252);
            this.Lbl_Family_Null_Err.Name = "Lbl_Family_Null_Err";
            this.Lbl_Family_Null_Err.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Family_Null_Err.Size = new System.Drawing.Size(156, 25);
            this.Lbl_Family_Null_Err.TabIndex = 78;
            this.Lbl_Family_Null_Err.Text = "نام و نام خانوادگی را وارد کنید.";
            this.Lbl_Family_Null_Err.Visible = false;
            // 
            // Form_SignUp_Step_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 680);
            this.Controls.Add(this.Lbl_Family_Null_Err);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Lbl_PhoneNo_Null_Err);
            this.Controls.Add(this.Lbl_EmailErr);
            this.Controls.Add(this.PB_UploadPic);
            this.Controls.Add(this.Btn_Browse);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.PB_User_Prv);
            this.Controls.Add(this.PB_Back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_NameAndFamily);
            this.Controls.Add(this.Lbl_NameAndFamily);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_Adrs);
            this.Controls.Add(this.Txt_Adrs);
            this.Controls.Add(this.Lbl_Mob);
            this.Controls.Add(this.Txt_Mob);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SignUp_Step_2";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "فرم ثبت نام";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form_SignUp_Step_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_UploadPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_User_Prv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_UploadPic;
        private ns1.BunifuThinButton2 Btn_Browse;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox PB_User_Prv;
        private System.Windows.Forms.PictureBox PB_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox Txt_NameAndFamily;
        private ns1.BunifuCustomLabel Lbl_NameAndFamily;
        private ns1.BunifuCustomLabel Lbl_Email;
        private MetroFramework.Controls.MetroTextBox Txt_Email;
        private ns1.BunifuCustomLabel Lbl_Adrs;
        private MetroFramework.Controls.MetroTextBox Txt_Adrs;
        private ns1.BunifuCustomLabel Lbl_Mob;
        private MetroFramework.Controls.MetroTextBox Txt_Mob;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Lbl_EmailErr;
        private System.Windows.Forms.Label Lbl_PhoneNo_Null_Err;
        private ns1.BunifuFlatButton Btn_Save;
        private ns1.BunifuFlatButton Btn_Cancel;
        private System.Windows.Forms.Label Lbl_Family_Null_Err;
    }
}