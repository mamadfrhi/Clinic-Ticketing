namespace Clinic_App
{
    partial class Form_Edit
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
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Mob = new System.Windows.Forms.TextBox();
            this.Lbl_Mob = new System.Windows.Forms.Label();
            this.Lbl_Ser = new System.Windows.Forms.Label();
            this.Lbl_Sec = new System.Windows.Forms.Label();
            this.Lbl_Doc = new System.Windows.Forms.Label();
            this.Cmb_Ser = new System.Windows.Forms.ComboBox();
            this.Cmb_Sec = new System.Windows.Forms.ComboBox();
            this.Cmb_Dr = new System.Windows.Forms.ComboBox();
            this.Txt_PatMob = new System.Windows.Forms.TextBox();
            this.Lbl_Patmob = new System.Windows.Forms.Label();
            this.Txt_PatAdrs = new System.Windows.Forms.TextBox();
            this.Lbl_PatAdrs = new System.Windows.Forms.Label();
            this.Txt_PatNcode = new System.Windows.Forms.TextBox();
            this.Lbl_PatNcode = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.Btn_Save = new ns1.BunifuFlatButton();
            this.Btn_Cancel = new ns1.BunifuFlatButton();
            this.Lbl_DrMedicalCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_Name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Name.Location = new System.Drawing.Point(156, 26);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(115, 29);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "نام                     :";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Name.Location = new System.Drawing.Point(23, 28);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(126, 23);
            this.Txt_Name.TabIndex = 1;
            // 
            // Txt_Mob
            // 
            this.Txt_Mob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mob.Location = new System.Drawing.Point(23, 61);
            this.Txt_Mob.Name = "Txt_Mob";
            this.Txt_Mob.Size = new System.Drawing.Size(126, 23);
            this.Txt_Mob.TabIndex = 3;
            // 
            // Lbl_Mob
            // 
            this.Lbl_Mob.AutoSize = true;
            this.Lbl_Mob.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_Mob.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Mob.Location = new System.Drawing.Point(157, 56);
            this.Lbl_Mob.Name = "Lbl_Mob";
            this.Lbl_Mob.Size = new System.Drawing.Size(114, 29);
            this.Lbl_Mob.TabIndex = 2;
            this.Lbl_Mob.Text = "شماره همراه       :";
            // 
            // Lbl_Ser
            // 
            this.Lbl_Ser.AutoSize = true;
            this.Lbl_Ser.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_Ser.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Ser.Location = new System.Drawing.Point(158, 150);
            this.Lbl_Ser.Name = "Lbl_Ser";
            this.Lbl_Ser.Size = new System.Drawing.Size(113, 29);
            this.Lbl_Ser.TabIndex = 4;
            this.Lbl_Ser.Text = "سرویس مربوطه :";
            // 
            // Lbl_Sec
            // 
            this.Lbl_Sec.AutoSize = true;
            this.Lbl_Sec.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_Sec.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Sec.Location = new System.Drawing.Point(158, 116);
            this.Lbl_Sec.Name = "Lbl_Sec";
            this.Lbl_Sec.Size = new System.Drawing.Size(113, 29);
            this.Lbl_Sec.TabIndex = 6;
            this.Lbl_Sec.Text = "بخش مربوطه     :";
            // 
            // Lbl_Doc
            // 
            this.Lbl_Doc.AutoSize = true;
            this.Lbl_Doc.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_Doc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Doc.Location = new System.Drawing.Point(159, 86);
            this.Lbl_Doc.Name = "Lbl_Doc";
            this.Lbl_Doc.Size = new System.Drawing.Size(112, 29);
            this.Lbl_Doc.TabIndex = 8;
            this.Lbl_Doc.Text = "نام دکتر مربوطه :";
            // 
            // Cmb_Ser
            // 
            this.Cmb_Ser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Ser.FormattingEnabled = true;
            this.Cmb_Ser.Location = new System.Drawing.Point(23, 156);
            this.Cmb_Ser.Name = "Cmb_Ser";
            this.Cmb_Ser.Size = new System.Drawing.Size(126, 21);
            this.Cmb_Ser.TabIndex = 12;
            // 
            // Cmb_Sec
            // 
            this.Cmb_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Sec.FormattingEnabled = true;
            this.Cmb_Sec.Location = new System.Drawing.Point(24, 125);
            this.Cmb_Sec.Name = "Cmb_Sec";
            this.Cmb_Sec.Size = new System.Drawing.Size(126, 21);
            this.Cmb_Sec.TabIndex = 13;
            // 
            // Cmb_Dr
            // 
            this.Cmb_Dr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Dr.FormattingEnabled = true;
            this.Cmb_Dr.Location = new System.Drawing.Point(23, 94);
            this.Cmb_Dr.Name = "Cmb_Dr";
            this.Cmb_Dr.Size = new System.Drawing.Size(126, 21);
            this.Cmb_Dr.TabIndex = 14;
            // 
            // Txt_PatMob
            // 
            this.Txt_PatMob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PatMob.Location = new System.Drawing.Point(24, 183);
            this.Txt_PatMob.Name = "Txt_PatMob";
            this.Txt_PatMob.Size = new System.Drawing.Size(126, 23);
            this.Txt_PatMob.TabIndex = 16;
            this.Txt_PatMob.Visible = false;
            // 
            // Lbl_Patmob
            // 
            this.Lbl_Patmob.AutoSize = true;
            this.Lbl_Patmob.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_Patmob.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_Patmob.Location = new System.Drawing.Point(146, 319);
            this.Lbl_Patmob.Name = "Lbl_Patmob";
            this.Lbl_Patmob.Size = new System.Drawing.Size(120, 29);
            this.Lbl_Patmob.TabIndex = 15;
            this.Lbl_Patmob.Text = "شماره همراه بیمار :";
            this.Lbl_Patmob.Visible = false;
            // 
            // Txt_PatAdrs
            // 
            this.Txt_PatAdrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PatAdrs.Location = new System.Drawing.Point(313, 360);
            this.Txt_PatAdrs.Name = "Txt_PatAdrs";
            this.Txt_PatAdrs.Size = new System.Drawing.Size(126, 23);
            this.Txt_PatAdrs.TabIndex = 18;
            this.Txt_PatAdrs.Visible = false;
            // 
            // Lbl_PatAdrs
            // 
            this.Lbl_PatAdrs.AutoSize = true;
            this.Lbl_PatAdrs.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_PatAdrs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_PatAdrs.Location = new System.Drawing.Point(158, 181);
            this.Lbl_PatAdrs.Name = "Lbl_PatAdrs";
            this.Lbl_PatAdrs.Size = new System.Drawing.Size(111, 29);
            this.Lbl_PatAdrs.TabIndex = 17;
            this.Lbl_PatAdrs.Text = "آدرس              :";
            this.Lbl_PatAdrs.Visible = false;
            // 
            // Txt_PatNcode
            // 
            this.Txt_PatNcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PatNcode.Location = new System.Drawing.Point(313, 321);
            this.Txt_PatNcode.Name = "Txt_PatNcode";
            this.Txt_PatNcode.Size = new System.Drawing.Size(126, 23);
            this.Txt_PatNcode.TabIndex = 20;
            this.Txt_PatNcode.Visible = false;
            // 
            // Lbl_PatNcode
            // 
            this.Lbl_PatNcode.AutoSize = true;
            this.Lbl_PatNcode.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_PatNcode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_PatNcode.Location = new System.Drawing.Point(157, 89);
            this.Lbl_PatNcode.Name = "Lbl_PatNcode";
            this.Lbl_PatNcode.Size = new System.Drawing.Size(114, 29);
            this.Lbl_PatNcode.TabIndex = 19;
            this.Lbl_PatNcode.Text = "کد ملی              :";
            this.Lbl_PatNcode.Visible = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_Save.BackColor = System.Drawing.Color.ForestGreen;
            this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Save.BorderRadius = 0;
            this.Btn_Save.ButtonText = "ثبت تغییرات";
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Save.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Save.Iconimage = null;
            this.Btn_Save.Iconimage_right = null;
            this.Btn_Save.Iconimage_right_Selected = null;
            this.Btn_Save.Iconimage_Selected = null;
            this.Btn_Save.IconMarginLeft = 0;
            this.Btn_Save.IconMarginRight = 0;
            this.Btn_Save.IconRightVisible = false;
            this.Btn_Save.IconRightZoom = 0D;
            this.Btn_Save.IconVisible = false;
            this.Btn_Save.IconZoom = 90D;
            this.Btn_Save.IsTab = false;
            this.Btn_Save.Location = new System.Drawing.Point(23, 227);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Normalcolor = System.Drawing.Color.ForestGreen;
            this.Btn_Save.OnHovercolor = System.Drawing.Color.PaleGreen;
            this.Btn_Save.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_Save.selected = false;
            this.Btn_Save.Size = new System.Drawing.Size(89, 41);
            this.Btn_Save.TabIndex = 23;
            this.Btn_Save.Text = "ثبت تغییرات";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Save.Textcolor = System.Drawing.Color.White;
            this.Btn_Save.TextFont = new System.Drawing.Font("Far.Homa", 12F);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Activecolor = System.Drawing.Color.Brown;
            this.Btn_Cancel.BackColor = System.Drawing.Color.Brown;
            this.Btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancel.BorderRadius = 0;
            this.Btn_Cancel.ButtonText = "لغو";
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Cancel.Iconimage = null;
            this.Btn_Cancel.Iconimage_right = null;
            this.Btn_Cancel.Iconimage_right_Selected = null;
            this.Btn_Cancel.Iconimage_Selected = null;
            this.Btn_Cancel.IconMarginLeft = 0;
            this.Btn_Cancel.IconMarginRight = 0;
            this.Btn_Cancel.IconRightVisible = false;
            this.Btn_Cancel.IconRightZoom = 0D;
            this.Btn_Cancel.IconVisible = false;
            this.Btn_Cancel.IconZoom = 90D;
            this.Btn_Cancel.IsTab = false;
            this.Btn_Cancel.Location = new System.Drawing.Point(128, 227);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Normalcolor = System.Drawing.Color.Brown;
            this.Btn_Cancel.OnHovercolor = System.Drawing.Color.Red;
            this.Btn_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Cancel.selected = false;
            this.Btn_Cancel.Size = new System.Drawing.Size(53, 41);
            this.Btn_Cancel.TabIndex = 24;
            this.Btn_Cancel.Text = "لغو";
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cancel.Textcolor = System.Drawing.Color.White;
            this.Btn_Cancel.TextFont = new System.Drawing.Font("Far.Homa", 12F);
            this.Btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_DrMedicalCode
            // 
            this.Lbl_DrMedicalCode.AutoSize = true;
            this.Lbl_DrMedicalCode.Font = new System.Drawing.Font("B Koodak", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_DrMedicalCode.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lbl_DrMedicalCode.Location = new System.Drawing.Point(158, 121);
            this.Lbl_DrMedicalCode.Name = "Lbl_DrMedicalCode";
            this.Lbl_DrMedicalCode.Size = new System.Drawing.Size(122, 29);
            this.Lbl_DrMedicalCode.TabIndex = 25;
            this.Lbl_DrMedicalCode.Text = " کد نظام پزشکی   :";
            this.Lbl_DrMedicalCode.Visible = false;
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 454);
            this.Controls.Add(this.Lbl_DrMedicalCode);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_PatNcode);
            this.Controls.Add(this.Lbl_PatNcode);
            this.Controls.Add(this.Txt_PatAdrs);
            this.Controls.Add(this.Lbl_PatAdrs);
            this.Controls.Add(this.Txt_PatMob);
            this.Controls.Add(this.Lbl_Patmob);
            this.Controls.Add(this.Cmb_Dr);
            this.Controls.Add(this.Cmb_Sec);
            this.Controls.Add(this.Cmb_Ser);
            this.Controls.Add(this.Lbl_Doc);
            this.Controls.Add(this.Lbl_Sec);
            this.Controls.Add(this.Lbl_Ser);
            this.Controls.Add(this.Txt_Mob);
            this.Controls.Add(this.Lbl_Mob);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Name);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Edit";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Form_Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Edit_FormClosing);
            this.Load += new System.EventHandler(this.Form_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Mob;
        private System.Windows.Forms.Label Lbl_Mob;
        private System.Windows.Forms.Label Lbl_Ser;
        private System.Windows.Forms.Label Lbl_Sec;
        private System.Windows.Forms.Label Lbl_Doc;
        private System.Windows.Forms.ComboBox Cmb_Ser;
        private System.Windows.Forms.ComboBox Cmb_Sec;
        private System.Windows.Forms.ComboBox Cmb_Dr;
        private System.Windows.Forms.TextBox Txt_PatMob;
        private System.Windows.Forms.Label Lbl_Patmob;
        private System.Windows.Forms.TextBox Txt_PatAdrs;
        private System.Windows.Forms.Label Lbl_PatAdrs;
        private System.Windows.Forms.TextBox Txt_PatNcode;
        private System.Windows.Forms.Label Lbl_PatNcode;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private ns1.BunifuFlatButton Btn_Save;
        private ns1.BunifuFlatButton Btn_Cancel;
        private System.Windows.Forms.Label Lbl_DrMedicalCode;
    }
}