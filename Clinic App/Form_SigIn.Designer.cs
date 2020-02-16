namespace Clinic_App
{
    partial class Form_SigIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SigIn));
            this.Lbl_Nothing = new System.Windows.Forms.Label();
            this.Lbl_UserName = new ns1.BunifuCustomLabel();
            this.Txt_UserName = new ns1.BunifuMetroTextbox();
            this.Lbl_PW = new ns1.BunifuCustomLabel();
            this.Txt_Pw = new ns1.BunifuMetroTextbox();
            this.PB_Pw = new System.Windows.Forms.PictureBox();
            this.Btn_SignIn = new ns1.BunifuThinButton2();
            this.PB_UserName = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UserName)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nothing
            // 
            this.Lbl_Nothing.AutoSize = true;
            this.Lbl_Nothing.Location = new System.Drawing.Point(10, 20);
            this.Lbl_Nothing.Name = "Lbl_Nothing";
            this.Lbl_Nothing.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nothing.TabIndex = 3;
            this.Lbl_Nothing.Text = "label1";
            this.Lbl_Nothing.Visible = false;
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Font = new System.Drawing.Font("B Kourosh", 17F, System.Drawing.FontStyle.Bold);
            this.Lbl_UserName.Location = new System.Drawing.Point(183, 114);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_UserName.Size = new System.Drawing.Size(97, 35);
            this.Lbl_UserName.TabIndex = 11;
            this.Lbl_UserName.Text = "نام کاربری :";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.Txt_UserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_UserName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Txt_UserName.BorderThickness = 3;
            this.Txt_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_UserName.Font = new System.Drawing.Font("Dima", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_UserName.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_UserName.isPassword = false;
            this.Txt_UserName.Location = new System.Drawing.Point(58, 114);
            this.Txt_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(117, 40);
            this.Txt_UserName.TabIndex = 0;
            this.Txt_UserName.Text = "نام کاربری";
            this.Txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_UserName.Enter += new System.EventHandler(this.Txt_UserName_Enter);
            // 
            // Lbl_PW
            // 
            this.Lbl_PW.AutoSize = true;
            this.Lbl_PW.Font = new System.Drawing.Font("B Kourosh", 17F, System.Drawing.FontStyle.Bold);
            this.Lbl_PW.Location = new System.Drawing.Point(183, 168);
            this.Lbl_PW.Name = "Lbl_PW";
            this.Lbl_PW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_PW.Size = new System.Drawing.Size(95, 35);
            this.Lbl_PW.TabIndex = 8;
            this.Lbl_PW.Text = "کلمه عبور :";
            // 
            // Txt_Pw
            // 
            this.Txt_Pw.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.Txt_Pw.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_Pw.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Txt_Pw.BorderThickness = 3;
            this.Txt_Pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Txt_Pw.ForeColor = System.Drawing.Color.DarkGray;
            this.Txt_Pw.isPassword = true;
            this.Txt_Pw.Location = new System.Drawing.Point(58, 167);
            this.Txt_Pw.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Pw.Name = "Txt_Pw";
            this.Txt_Pw.Size = new System.Drawing.Size(117, 40);
            this.Txt_Pw.TabIndex = 1;
            this.Txt_Pw.Text = "کلمه عبور";
            this.Txt_Pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_Pw.Enter += new System.EventHandler(this.Txt_Pw_Enter);
            this.Txt_Pw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Pw_KeyPress);
            // 
            // PB_Pw
            // 
            this.PB_Pw.Image = global::Clinic_App.Properties.Resources.password;
            this.PB_Pw.Location = new System.Drawing.Point(11, 167);
            this.PB_Pw.Name = "PB_Pw";
            this.PB_Pw.Size = new System.Drawing.Size(40, 36);
            this.PB_Pw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Pw.TabIndex = 14;
            this.PB_Pw.TabStop = false;
            // 
            // Btn_SignIn
            // 
            this.Btn_SignIn.ActiveBorderThickness = 1;
            this.Btn_SignIn.ActiveCornerRadius = 20;
            this.Btn_SignIn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_SignIn.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_SignIn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_SignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_SignIn.BackgroundImage")));
            this.Btn_SignIn.ButtonText = "ورود";
            this.Btn_SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SignIn.Font = new System.Drawing.Font("B Koodak", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SignIn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_SignIn.IdleBorderThickness = 1;
            this.Btn_SignIn.IdleCornerRadius = 20;
            this.Btn_SignIn.IdleFillColor = System.Drawing.Color.White;
            this.Btn_SignIn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_SignIn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_SignIn.Location = new System.Drawing.Point(49, 215);
            this.Btn_SignIn.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_SignIn.Name = "Btn_SignIn";
            this.Btn_SignIn.Size = new System.Drawing.Size(181, 41);
            this.Btn_SignIn.TabIndex = 3;
            this.Btn_SignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
            // 
            // PB_UserName
            // 
            this.PB_UserName.Image = ((System.Drawing.Image)(resources.GetObject("PB_UserName.Image")));
            this.PB_UserName.Location = new System.Drawing.Point(11, 118);
            this.PB_UserName.Name = "PB_UserName";
            this.PB_UserName.Size = new System.Drawing.Size(40, 36);
            this.PB_UserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_UserName.TabIndex = 12;
            this.PB_UserName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Kourosh", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(253, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "مشخصات حساب مدیر  را وارد کنید.";
            // 
            // Form_SigIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_Pw);
            this.Controls.Add(this.Btn_SignIn);
            this.Controls.Add(this.PB_UserName);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Lbl_PW);
            this.Controls.Add(this.Txt_Pw);
            this.Controls.Add(this.Lbl_Nothing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SigIn";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "ورود به بخش تنظیمات";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SignInAndSignUp_FormClosing);
            this.Load += new System.EventHandler(this.Form_SignInAndSignUp_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_SignInAndSignUp_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Pw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UserName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Nothing;
        private ns1.BunifuThinButton2 Btn_SignIn;
        private System.Windows.Forms.PictureBox PB_UserName;
        private ns1.BunifuCustomLabel Lbl_UserName;
        private ns1.BunifuMetroTextbox Txt_UserName;
        private ns1.BunifuCustomLabel Lbl_PW;
        private ns1.BunifuMetroTextbox Txt_Pw;
        private System.Windows.Forms.PictureBox PB_Pw;
        private System.Windows.Forms.Label label1;
    }
}