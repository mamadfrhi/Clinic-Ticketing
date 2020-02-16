namespace Clinic_App
{
    partial class Form_EditImages
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
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_ImgNum = new System.Windows.Forms.Label();
            this.Lbl_NotFound = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.Btn_MaximizeImg = new ns1.BunifuFlatButton();
            this.Btn_SaveFromSql = new ns1.BunifuFlatButton();
            this.Btn_AddImg = new ns1.BunifuFlatButton();
            this.Pb_NotFound = new System.Windows.Forms.PictureBox();
            this.PB_MohrClinic = new System.Windows.Forms.PictureBox();
            this.Btn_NextImg = new ns1.BunifuFlatButton();
            this.Btn_PrevImg = new ns1.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_PicCount = new System.Windows.Forms.Label();
            this.Checkbox1 = new ns1.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Save = new ns1.BunifuFlatButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Txt_Name2 = new System.Windows.Forms.TextBox();
            this.timer_GoOut = new System.Windows.Forms.Timer(this.components);
            this.Lbl_DigitLeft = new System.Windows.Forms.Label();
            this.Lbl_DigitRight = new System.Windows.Forms.Label();
            this.Btn_DelRecord = new ns1.BunifuFlatButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_NotFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MohrClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Font = new System.Drawing.Font("A MehdiHeydari", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Name.Location = new System.Drawing.Point(312, 149);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(281, 35);
            this.Lbl_Name.TabIndex = 1;
            this.Lbl_Name.Text = "نام و نام خانوادگی بیمار انتخاب شده :";
            // 
            // Lbl_ImgNum
            // 
            this.Lbl_ImgNum.AutoSize = true;
            this.Lbl_ImgNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ImgNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_ImgNum.Location = new System.Drawing.Point(290, 706);
            this.Lbl_ImgNum.Name = "Lbl_ImgNum";
            this.Lbl_ImgNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_ImgNum.Size = new System.Drawing.Size(21, 20);
            this.Lbl_ImgNum.TabIndex = 90;
            this.Lbl_ImgNum.Text = " / ";
            // 
            // Lbl_NotFound
            // 
            this.Lbl_NotFound.AutoSize = true;
            this.Lbl_NotFound.Font = new System.Drawing.Font("A MehdiHeydari", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_NotFound.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_NotFound.Location = new System.Drawing.Point(188, 252);
            this.Lbl_NotFound.Name = "Lbl_NotFound";
            this.Lbl_NotFound.Size = new System.Drawing.Size(139, 35);
            this.Lbl_NotFound.TabIndex = 93;
            this.Lbl_NotFound.Text = "عکسی یافت نشد.";
            this.Lbl_NotFound.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 680);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(573, 16);
            this.bunifuSeparator1.TabIndex = 96;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Btn_MaximizeImg
            // 
            this.Btn_MaximizeImg.Activecolor = System.Drawing.Color.LightCyan;
            this.Btn_MaximizeImg.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Btn_MaximizeImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_MaximizeImg.BorderRadius = 0;
            this.Btn_MaximizeImg.ButtonText = "بزرگ کردن";
            this.Btn_MaximizeImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MaximizeImg.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_MaximizeImg.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_MaximizeImg.Iconimage = global::Clinic_App.Properties.Resources.maximize1;
            this.Btn_MaximizeImg.Iconimage_right = null;
            this.Btn_MaximizeImg.Iconimage_right_Selected = null;
            this.Btn_MaximizeImg.Iconimage_Selected = null;
            this.Btn_MaximizeImg.IconMarginLeft = 0;
            this.Btn_MaximizeImg.IconMarginRight = 0;
            this.Btn_MaximizeImg.IconRightVisible = false;
            this.Btn_MaximizeImg.IconRightZoom = 0D;
            this.Btn_MaximizeImg.IconVisible = true;
            this.Btn_MaximizeImg.IconZoom = 60D;
            this.Btn_MaximizeImg.IsTab = false;
            this.Btn_MaximizeImg.Location = new System.Drawing.Point(32, 167);
            this.Btn_MaximizeImg.Name = "Btn_MaximizeImg";
            this.Btn_MaximizeImg.Normalcolor = System.Drawing.Color.LightGoldenrodYellow;
            this.Btn_MaximizeImg.OnHovercolor = System.Drawing.Color.LightBlue;
            this.Btn_MaximizeImg.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_MaximizeImg.selected = false;
            this.Btn_MaximizeImg.Size = new System.Drawing.Size(104, 38);
            this.Btn_MaximizeImg.TabIndex = 97;
            this.Btn_MaximizeImg.Text = "بزرگ کردن";
            this.Btn_MaximizeImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_MaximizeImg.Textcolor = System.Drawing.Color.Black;
            this.Btn_MaximizeImg.TextFont = new System.Drawing.Font("Far.Homa", 12F);
            this.Btn_MaximizeImg.Click += new System.EventHandler(this.Btn_MaximizeImg_Click);
            // 
            // Btn_SaveFromSql
            // 
            this.Btn_SaveFromSql.Activecolor = System.Drawing.Color.LightBlue;
            this.Btn_SaveFromSql.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_SaveFromSql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_SaveFromSql.BorderRadius = 0;
            this.Btn_SaveFromSql.ButtonText = "ذخیره عکس از سرور";
            this.Btn_SaveFromSql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SaveFromSql.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_SaveFromSql.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_SaveFromSql.Iconimage = global::Clinic_App.Properties.Resources.download_to_storage_drive;
            this.Btn_SaveFromSql.Iconimage_right = null;
            this.Btn_SaveFromSql.Iconimage_right_Selected = null;
            this.Btn_SaveFromSql.Iconimage_Selected = null;
            this.Btn_SaveFromSql.IconMarginLeft = 0;
            this.Btn_SaveFromSql.IconMarginRight = 0;
            this.Btn_SaveFromSql.IconRightVisible = false;
            this.Btn_SaveFromSql.IconRightZoom = 0D;
            this.Btn_SaveFromSql.IconVisible = true;
            this.Btn_SaveFromSql.IconZoom = 55D;
            this.Btn_SaveFromSql.IsTab = false;
            this.Btn_SaveFromSql.Location = new System.Drawing.Point(156, 612);
            this.Btn_SaveFromSql.Name = "Btn_SaveFromSql";
            this.Btn_SaveFromSql.Normalcolor = System.Drawing.Color.LightBlue;
            this.Btn_SaveFromSql.OnHovercolor = System.Drawing.Color.PaleTurquoise;
            this.Btn_SaveFromSql.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_SaveFromSql.selected = false;
            this.Btn_SaveFromSql.Size = new System.Drawing.Size(150, 48);
            this.Btn_SaveFromSql.TabIndex = 95;
            this.Btn_SaveFromSql.Text = "ذخیره عکس از سرور";
            this.Btn_SaveFromSql.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_SaveFromSql.Textcolor = System.Drawing.Color.Black;
            this.Btn_SaveFromSql.TextFont = new System.Drawing.Font("Far.Homa", 11F);
            this.Btn_SaveFromSql.Click += new System.EventHandler(this.Btn_SaveFromSql_Click);
            // 
            // Btn_AddImg
            // 
            this.Btn_AddImg.Activecolor = System.Drawing.Color.PaleTurquoise;
            this.Btn_AddImg.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Btn_AddImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_AddImg.BorderRadius = 0;
            this.Btn_AddImg.ButtonText = "اضافه کردن عکس";
            this.Btn_AddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AddImg.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_AddImg.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_AddImg.Iconimage = global::Clinic_App.Properties.Resources.image1;
            this.Btn_AddImg.Iconimage_right = null;
            this.Btn_AddImg.Iconimage_right_Selected = null;
            this.Btn_AddImg.Iconimage_Selected = null;
            this.Btn_AddImg.IconMarginLeft = 0;
            this.Btn_AddImg.IconMarginRight = 0;
            this.Btn_AddImg.IconRightVisible = false;
            this.Btn_AddImg.IconRightZoom = 0D;
            this.Btn_AddImg.IconVisible = true;
            this.Btn_AddImg.IconZoom = 60D;
            this.Btn_AddImg.IsTab = false;
            this.Btn_AddImg.Location = new System.Drawing.Point(446, 613);
            this.Btn_AddImg.Name = "Btn_AddImg";
            this.Btn_AddImg.Normalcolor = System.Drawing.Color.PaleTurquoise;
            this.Btn_AddImg.OnHovercolor = System.Drawing.Color.LightGreen;
            this.Btn_AddImg.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_AddImg.selected = false;
            this.Btn_AddImg.Size = new System.Drawing.Size(141, 48);
            this.Btn_AddImg.TabIndex = 94;
            this.Btn_AddImg.Text = "اضافه کردن عکس";
            this.Btn_AddImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_AddImg.Textcolor = System.Drawing.Color.Black;
            this.Btn_AddImg.TextFont = new System.Drawing.Font("Far.Homa", 10F);
            this.Btn_AddImg.Click += new System.EventHandler(this.Btn_AddImg_Click);
            // 
            // Pb_NotFound
            // 
            this.Pb_NotFound.Image = global::Clinic_App.Properties.Resources.no_photo;
            this.Pb_NotFound.Location = new System.Drawing.Point(205, 110);
            this.Pb_NotFound.Name = "Pb_NotFound";
            this.Pb_NotFound.Size = new System.Drawing.Size(158, 139);
            this.Pb_NotFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_NotFound.TabIndex = 92;
            this.Pb_NotFound.TabStop = false;
            this.Pb_NotFound.Visible = false;
            // 
            // PB_MohrClinic
            // 
            this.PB_MohrClinic.BackColor = System.Drawing.Color.Transparent;
            this.PB_MohrClinic.Image = global::Clinic_App.Properties.Resources.Mohr_Clinic_red1;
            this.PB_MohrClinic.Location = new System.Drawing.Point(237, 43);
            this.PB_MohrClinic.Name = "PB_MohrClinic";
            this.PB_MohrClinic.Size = new System.Drawing.Size(145, 105);
            this.PB_MohrClinic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MohrClinic.TabIndex = 91;
            this.PB_MohrClinic.TabStop = false;
            // 
            // Btn_NextImg
            // 
            this.Btn_NextImg.Activecolor = System.Drawing.Color.PaleGreen;
            this.Btn_NextImg.BackColor = System.Drawing.Color.Transparent;
            this.Btn_NextImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_NextImg.BorderRadius = 0;
            this.Btn_NextImg.ButtonText = "";
            this.Btn_NextImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NextImg.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_NextImg.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_NextImg.Iconimage = global::Clinic_App.Properties.Resources.next1;
            this.Btn_NextImg.Iconimage_right = null;
            this.Btn_NextImg.Iconimage_right_Selected = null;
            this.Btn_NextImg.Iconimage_Selected = null;
            this.Btn_NextImg.IconMarginLeft = 0;
            this.Btn_NextImg.IconMarginRight = 0;
            this.Btn_NextImg.IconRightVisible = true;
            this.Btn_NextImg.IconRightZoom = 0D;
            this.Btn_NextImg.IconVisible = true;
            this.Btn_NextImg.IconZoom = 90D;
            this.Btn_NextImg.IsTab = false;
            this.Btn_NextImg.Location = new System.Drawing.Point(487, 688);
            this.Btn_NextImg.Name = "Btn_NextImg";
            this.Btn_NextImg.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_NextImg.OnHovercolor = System.Drawing.Color.PaleGreen;
            this.Btn_NextImg.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_NextImg.selected = false;
            this.Btn_NextImg.Size = new System.Drawing.Size(51, 48);
            this.Btn_NextImg.TabIndex = 89;
            this.Btn_NextImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_NextImg.Textcolor = System.Drawing.Color.White;
            this.Btn_NextImg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NextImg.Click += new System.EventHandler(this.Btn_NextImg_Click);
            // 
            // Btn_PrevImg
            // 
            this.Btn_PrevImg.Activecolor = System.Drawing.Color.PaleGreen;
            this.Btn_PrevImg.BackColor = System.Drawing.Color.Transparent;
            this.Btn_PrevImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_PrevImg.BorderRadius = 0;
            this.Btn_PrevImg.ButtonText = "";
            this.Btn_PrevImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PrevImg.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_PrevImg.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_PrevImg.Iconimage = global::Clinic_App.Properties.Resources.next_left;
            this.Btn_PrevImg.Iconimage_right = null;
            this.Btn_PrevImg.Iconimage_right_Selected = null;
            this.Btn_PrevImg.Iconimage_Selected = null;
            this.Btn_PrevImg.IconMarginLeft = 0;
            this.Btn_PrevImg.IconMarginRight = 0;
            this.Btn_PrevImg.IconRightVisible = true;
            this.Btn_PrevImg.IconRightZoom = 0D;
            this.Btn_PrevImg.IconVisible = true;
            this.Btn_PrevImg.IconZoom = 90D;
            this.Btn_PrevImg.IsTab = false;
            this.Btn_PrevImg.Location = new System.Drawing.Point(81, 688);
            this.Btn_PrevImg.Name = "Btn_PrevImg";
            this.Btn_PrevImg.Normalcolor = System.Drawing.Color.Transparent;
            this.Btn_PrevImg.OnHovercolor = System.Drawing.Color.PaleGreen;
            this.Btn_PrevImg.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_PrevImg.selected = false;
            this.Btn_PrevImg.Size = new System.Drawing.Size(51, 48);
            this.Btn_PrevImg.TabIndex = 88;
            this.Btn_PrevImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_PrevImg.Textcolor = System.Drawing.Color.White;
            this.Btn_PrevImg.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_PrevImg.Click += new System.EventHandler(this.Btn_PrevImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(17, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A MehdiHeydari", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(421, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 99;
            this.label1.Text = "تعداد عکس های اضافه شده:";
            // 
            // Lbl_PicCount
            // 
            this.Lbl_PicCount.AutoSize = true;
            this.Lbl_PicCount.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PicCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_PicCount.Location = new System.Drawing.Point(397, 189);
            this.Lbl_PicCount.Name = "Lbl_PicCount";
            this.Lbl_PicCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_PicCount.Size = new System.Drawing.Size(18, 19);
            this.Lbl_PicCount.TabIndex = 100;
            this.Lbl_PicCount.Text = "0";
            // 
            // Checkbox1
            // 
            this.Checkbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.Checked = true;
            this.Checkbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox1.ForeColor = System.Drawing.Color.White;
            this.Checkbox1.Location = new System.Drawing.Point(156, 185);
            this.Checkbox1.Name = "Checkbox1";
            this.Checkbox1.Size = new System.Drawing.Size(20, 20);
            this.Checkbox1.TabIndex = 101;
            this.Checkbox1.OnChange += new System.EventHandler(this.Checkbox1_OnChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Soraya", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(199, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 102;
            this.label2.Text = "هم اندازه شدن با قاب:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Pb_NotFound);
            this.panel1.Controls.Add(this.Lbl_NotFound);
            this.panel1.Location = new System.Drawing.Point(32, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 379);
            this.panel1.TabIndex = 105;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Activecolor = System.Drawing.Color.YellowGreen;
            this.Btn_Save.BackColor = System.Drawing.Color.PaleGreen;
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
            this.Btn_Save.Location = new System.Drawing.Point(32, 613);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Normalcolor = System.Drawing.Color.PaleGreen;
            this.Btn_Save.OnHovercolor = System.Drawing.Color.LightGreen;
            this.Btn_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Save.selected = false;
            this.Btn_Save.Size = new System.Drawing.Size(88, 48);
            this.Btn_Save.TabIndex = 106;
            this.Btn_Save.Text = "تایید";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Save.Textcolor = System.Drawing.Color.Black;
            this.Btn_Save.TextFont = new System.Drawing.Font("B Homa", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Txt_Name2
            // 
            this.Txt_Name2.Location = new System.Drawing.Point(156, 160);
            this.Txt_Name2.Name = "Txt_Name2";
            this.Txt_Name2.ReadOnly = true;
            this.Txt_Name2.Size = new System.Drawing.Size(150, 20);
            this.Txt_Name2.TabIndex = 107;
            this.Txt_Name2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_Name2_MouseDown);
            // 
            // timer_GoOut
            // 
            this.timer_GoOut.Interval = 1;
            this.timer_GoOut.Tick += new System.EventHandler(this.timer_GoOut_Tick);
            // 
            // Lbl_DigitLeft
            // 
            this.Lbl_DigitLeft.AutoSize = true;
            this.Lbl_DigitLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigitLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_DigitLeft.Location = new System.Drawing.Point(270, 706);
            this.Lbl_DigitLeft.Name = "Lbl_DigitLeft";
            this.Lbl_DigitLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_DigitLeft.Size = new System.Drawing.Size(18, 20);
            this.Lbl_DigitLeft.TabIndex = 108;
            this.Lbl_DigitLeft.Text = "0";
            // 
            // Lbl_DigitRight
            // 
            this.Lbl_DigitRight.AutoSize = true;
            this.Lbl_DigitRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigitRight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_DigitRight.Location = new System.Drawing.Point(317, 706);
            this.Lbl_DigitRight.Name = "Lbl_DigitRight";
            this.Lbl_DigitRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_DigitRight.Size = new System.Drawing.Size(18, 20);
            this.Lbl_DigitRight.TabIndex = 109;
            this.Lbl_DigitRight.Text = "0";
            // 
            // Btn_DelRecord
            // 
            this.Btn_DelRecord.Activecolor = System.Drawing.Color.Crimson;
            this.Btn_DelRecord.BackColor = System.Drawing.Color.Crimson;
            this.Btn_DelRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_DelRecord.BorderRadius = 0;
            this.Btn_DelRecord.ButtonText = "حذف";
            this.Btn_DelRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DelRecord.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_DelRecord.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_DelRecord.Iconimage = global::Clinic_App.Properties.Resources.delete_512;
            this.Btn_DelRecord.Iconimage_right = null;
            this.Btn_DelRecord.Iconimage_right_Selected = null;
            this.Btn_DelRecord.Iconimage_Selected = null;
            this.Btn_DelRecord.IconMarginLeft = 0;
            this.Btn_DelRecord.IconMarginRight = 0;
            this.Btn_DelRecord.IconRightVisible = true;
            this.Btn_DelRecord.IconRightZoom = 0D;
            this.Btn_DelRecord.IconVisible = true;
            this.Btn_DelRecord.IconZoom = 50D;
            this.Btn_DelRecord.IsTab = false;
            this.Btn_DelRecord.Location = new System.Drawing.Point(346, 613);
            this.Btn_DelRecord.Name = "Btn_DelRecord";
            this.Btn_DelRecord.Normalcolor = System.Drawing.Color.Crimson;
            this.Btn_DelRecord.OnHovercolor = System.Drawing.Color.Firebrick;
            this.Btn_DelRecord.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_DelRecord.selected = false;
            this.Btn_DelRecord.Size = new System.Drawing.Size(94, 47);
            this.Btn_DelRecord.TabIndex = 110;
            this.Btn_DelRecord.Text = "حذف";
            this.Btn_DelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_DelRecord.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Btn_DelRecord.TextFont = new System.Drawing.Font("Far.Homa", 13F);
            this.Btn_DelRecord.Visible = false;
            this.Btn_DelRecord.Click += new System.EventHandler(this.Btn_DelRecord_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(388, 664);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(203, 22);
            this.linkLabel1.TabIndex = 111;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "پاک کردن همه ی عکس های انتخاب شده.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form_EditImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(619, 737);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Btn_DelRecord);
            this.Controls.Add(this.Lbl_DigitRight);
            this.Controls.Add(this.Lbl_DigitLeft);
            this.Controls.Add(this.Txt_Name2);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Checkbox1);
            this.Controls.Add(this.Lbl_PicCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_MaximizeImg);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.Btn_SaveFromSql);
            this.Controls.Add(this.Btn_AddImg);
            this.Controls.Add(this.PB_MohrClinic);
            this.Controls.Add(this.Lbl_ImgNum);
            this.Controls.Add(this.Btn_NextImg);
            this.Controls.Add(this.Btn_PrevImg);
            this.Controls.Add(this.Lbl_Name);
            this.Name = "Form_EditImages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Tag = "633/131";
            this.Text = "مدیریت عکس بیمار";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EditImages_FormClosing);
            this.Load += new System.EventHandler(this.Form_EditImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_NotFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MohrClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
    //    private Telerik.WinControls.UI.RadTextBox Txt_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuFlatButton Btn_PrevImg;
        private ns1.BunifuFlatButton Btn_NextImg;
        private System.Windows.Forms.Label Lbl_ImgNum;
        private System.Windows.Forms.PictureBox PB_MohrClinic;
        private System.Windows.Forms.PictureBox Pb_NotFound;
        private System.Windows.Forms.Label Lbl_NotFound;
        private ns1.BunifuFlatButton Btn_AddImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuFlatButton Btn_MaximizeImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_PicCount;
        private ns1.BunifuCheckbox Checkbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuFlatButton Btn_Save;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Txt_Name2;
        private System.Windows.Forms.Timer timer_GoOut;
        private System.Windows.Forms.Label Lbl_DigitLeft;
        private System.Windows.Forms.Label Lbl_DigitRight;
        private ns1.BunifuFlatButton Btn_DelRecord;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private ns1.BunifuFlatButton Btn_SaveFromSql;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}