namespace Clinic_App
{
    partial class Form_Visit_Timing
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
            this.Btn_Save = new ns1.BunifuFlatButton();
            this.Lbl_Day = new System.Windows.Forms.Label();
            this.Lbl_Month = new System.Windows.Forms.Label();
            this.Lbl_Year = new System.Windows.Forms.Label();
            this.Lbl_int_Day = new System.Windows.Forms.Label();
            this.Lbl_int_Month = new System.Windows.Forms.Label();
            this.Lbl_int_Year = new System.Windows.Forms.Label();
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radTimePicker1 = new Telerik.WinControls.UI.RadTimePicker();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.telerikMetroTheme2 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radSeparator1 = new Telerik.WinControls.UI.RadSeparator();
            this.radSeparator2 = new Telerik.WinControls.UI.RadSeparator();
            this.PB_MohrClinic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MohrClinic)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.Activecolor = System.Drawing.Color.YellowGreen;
            this.Btn_Save.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Save.BorderRadius = 0;
            this.Btn_Save.ButtonText = "تایید";
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
            this.Btn_Save.Location = new System.Drawing.Point(23, 343);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Normalcolor = System.Drawing.Color.LightGreen;
            this.Btn_Save.OnHovercolor = System.Drawing.Color.LawnGreen;
            this.Btn_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Save.selected = false;
            this.Btn_Save.Size = new System.Drawing.Size(89, 48);
            this.Btn_Save.TabIndex = 64;
            this.Btn_Save.Text = "تایید";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Save.Textcolor = System.Drawing.Color.Black;
            this.Btn_Save.TextFont = new System.Drawing.Font("Far.Homa", 13F);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lbl_Day
            // 
            this.Lbl_Day.AutoSize = true;
            this.Lbl_Day.Font = new System.Drawing.Font("A Soraya", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_Day.Location = new System.Drawing.Point(104, 157);
            this.Lbl_Day.Name = "Lbl_Day";
            this.Lbl_Day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Day.Size = new System.Drawing.Size(64, 36);
            this.Lbl_Day.TabIndex = 65;
            this.Lbl_Day.Text = "روز     :";
            // 
            // Lbl_Month
            // 
            this.Lbl_Month.AutoSize = true;
            this.Lbl_Month.Font = new System.Drawing.Font("A Soraya", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_Month.Location = new System.Drawing.Point(105, 216);
            this.Lbl_Month.Name = "Lbl_Month";
            this.Lbl_Month.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Month.Size = new System.Drawing.Size(63, 36);
            this.Lbl_Month.TabIndex = 66;
            this.Lbl_Month.Text = "ماه    :";
            // 
            // Lbl_Year
            // 
            this.Lbl_Year.AutoSize = true;
            this.Lbl_Year.Font = new System.Drawing.Font("A Soraya", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_Year.Location = new System.Drawing.Point(102, 275);
            this.Lbl_Year.Name = "Lbl_Year";
            this.Lbl_Year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Year.Size = new System.Drawing.Size(66, 36);
            this.Lbl_Year.TabIndex = 67;
            this.Lbl_Year.Text = "سال :";
            // 
            // Lbl_int_Day
            // 
            this.Lbl_int_Day.AutoSize = true;
            this.Lbl_int_Day.Font = new System.Drawing.Font("A Soraya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_int_Day.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Lbl_int_Day.Location = new System.Drawing.Point(19, 167);
            this.Lbl_int_Day.Name = "Lbl_int_Day";
            this.Lbl_int_Day.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_int_Day.Size = new System.Drawing.Size(86, 23);
            this.Lbl_int_Day.TabIndex = 68;
            this.Lbl_int_Day.Text = "انتخاب نشده.";
            // 
            // Lbl_int_Month
            // 
            this.Lbl_int_Month.AutoSize = true;
            this.Lbl_int_Month.Font = new System.Drawing.Font("A Soraya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_int_Month.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Lbl_int_Month.Location = new System.Drawing.Point(19, 226);
            this.Lbl_int_Month.Name = "Lbl_int_Month";
            this.Lbl_int_Month.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_int_Month.Size = new System.Drawing.Size(86, 23);
            this.Lbl_int_Month.TabIndex = 69;
            this.Lbl_int_Month.Text = "انتخاب نشده.";
            // 
            // Lbl_int_Year
            // 
            this.Lbl_int_Year.AutoSize = true;
            this.Lbl_int_Year.Font = new System.Drawing.Font("A Soraya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Lbl_int_Year.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Lbl_int_Year.Location = new System.Drawing.Point(19, 285);
            this.Lbl_int_Year.Name = "Lbl_int_Year";
            this.Lbl_int_Year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_int_Year.Size = new System.Drawing.Size(86, 23);
            this.Lbl_int_Year.TabIndex = 70;
            this.Lbl_int_Year.Text = "انتخاب نشده.";
            // 
            // radCalendar1
            // 
            this.radCalendar1.AllowFishEye = true;
            this.radCalendar1.AllowRowHeaderSelectors = true;
            this.radCalendar1.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full;
            this.radCalendar1.HeaderHeight = 20;
            this.radCalendar1.Location = new System.Drawing.Point(174, 81);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radCalendar1.SelectedDates.AddRange(new System.DateTime[] {
            new System.DateTime(1900, 1, 1, 0, 0, 0, 0)});
            this.radCalendar1.ShowFooter = true;
            this.radCalendar1.Size = new System.Drawing.Size(355, 227);
            this.radCalendar1.TabIndex = 71;
            this.radCalendar1.Text = "radCalendar1";
            this.radCalendar1.ThemeName = "TelerikMetroBlue";
            this.radCalendar1.SelectionChanged += new System.EventHandler(this.radCalendar1_SelectionChanged);
            ((Telerik.WinControls.UI.RadCalendarElement)(this.radCalendar1.GetChildAt(0))).AllowFishEye = true;
            ((Telerik.WinControls.UI.RadCalendarElement)(this.radCalendar1.GetChildAt(0))).HeaderWidth = 17;
            ((Telerik.WinControls.UI.RadCalendarElement)(this.radCalendar1.GetChildAt(0))).HeaderHeight = 20;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radCalendar1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(2))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            // 
            // radTimePicker1
            // 
            this.radTimePicker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radTimePicker1.ClockPosition = Telerik.WinControls.UI.ClockPosition.ClockAboveTables;
            this.radTimePicker1.CloseButtonText = "ثبت";
            this.radTimePicker1.EnableCodedUITests = true;
            this.radTimePicker1.EnableKeyMap = true;
            this.radTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.radTimePicker1.Location = new System.Drawing.Point(174, 366);
            this.radTimePicker1.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.radTimePicker1.MinValue = new System.DateTime(((long)(0)));
            this.radTimePicker1.Name = "radTimePicker1";
            this.radTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.radTimePicker1.RootElement.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.radTimePicker1.Size = new System.Drawing.Size(355, 25);
            this.radTimePicker1.TabIndex = 73;
            this.radTimePicker1.TabStop = false;
            this.radTimePicker1.Text = "19/04/1396 01:01 ب.ظ";
            this.radTimePicker1.ThemeName = "TelerikMetro";
            this.radTimePicker1.Value = new System.DateTime(2017, 7, 12, 0, 0, 0, 0);
            this.radTimePicker1.ValueChanged += new System.EventHandler(this.radTimePicker1_ValueChanged);
            this.radTimePicker1.MouseHover += new System.EventHandler(this.radTimePicker1_MouseHover);
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.Font = new System.Drawing.Font("A Soraya", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.Lbl_Time.ForeColor = System.Drawing.Color.Crimson;
            this.Lbl_Time.Location = new System.Drawing.Point(391, 328);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Time.Size = new System.Drawing.Size(142, 23);
            this.Lbl_Time.TabIndex = 74;
            this.Lbl_Time.Text = "ساعت حظور در کلینیک :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radSeparator1
            // 
            this.radSeparator1.Location = new System.Drawing.Point(11, 195);
            this.radSeparator1.Name = "radSeparator1";
            this.radSeparator1.Size = new System.Drawing.Size(157, 19);
            this.radSeparator1.TabIndex = 83;
            this.radSeparator1.Text = "radSeparator1";
            this.radSeparator1.ThemeName = "ControlDefault";
            // 
            // radSeparator2
            // 
            this.radSeparator2.Location = new System.Drawing.Point(11, 254);
            this.radSeparator2.Name = "radSeparator2";
            this.radSeparator2.Size = new System.Drawing.Size(157, 19);
            this.radSeparator2.TabIndex = 84;
            this.radSeparator2.Text = "radSeparator2";
            this.radSeparator2.ThemeName = "ControlDefault";
            // 
            // PB_MohrClinic
            // 
            this.PB_MohrClinic.BackColor = System.Drawing.Color.Transparent;
            this.PB_MohrClinic.Image = global::Clinic_App.Properties.Resources.Mohr_Clinic_red1;
            this.PB_MohrClinic.Location = new System.Drawing.Point(38, 81);
            this.PB_MohrClinic.Name = "PB_MohrClinic";
            this.PB_MohrClinic.Size = new System.Drawing.Size(106, 80);
            this.PB_MohrClinic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MohrClinic.TabIndex = 92;
            this.PB_MohrClinic.TabStop = false;
            // 
            // Form_Visit_Timing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 423);
            this.Controls.Add(this.PB_MohrClinic);
            this.Controls.Add(this.radSeparator2);
            this.Controls.Add(this.radSeparator1);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.radTimePicker1);
            this.Controls.Add(this.radCalendar1);
            this.Controls.Add(this.Lbl_int_Year);
            this.Controls.Add(this.Lbl_int_Month);
            this.Controls.Add(this.Lbl_int_Day);
            this.Controls.Add(this.Lbl_Year);
            this.Controls.Add(this.Lbl_Month);
            this.Controls.Add(this.Lbl_Day);
            this.Controls.Add(this.Btn_Save);
            this.Name = "Form_Visit_Timing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "تعیین وقت";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form_Visit_Timing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MohrClinic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuFlatButton Btn_Save;
        private System.Windows.Forms.Label Lbl_Day;
        private System.Windows.Forms.Label Lbl_Month;
        private System.Windows.Forms.Label Lbl_Year;
        private System.Windows.Forms.Label Lbl_int_Day;
        private System.Windows.Forms.Label Lbl_int_Month;
        private System.Windows.Forms.Label Lbl_int_Year;
        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadTimePicker radTimePicker1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme2;
        private Telerik.WinControls.UI.RadSeparator radSeparator1;
        private Telerik.WinControls.UI.RadSeparator radSeparator2;
        private System.Windows.Forms.PictureBox PB_MohrClinic;
    }
}