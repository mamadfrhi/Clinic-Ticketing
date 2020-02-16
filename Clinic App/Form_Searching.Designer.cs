namespace Clinic_App
{
    partial class Form_Searching
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Searching));
            this.CmbBx_Searching_Section = new System.Windows.Forms.ComboBox();
            this.TxtBx_SearchingValue = new System.Windows.Forms.TextBox();
            this.CmbBx_SearchingModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdVw_Searching = new MetroFramework.Controls.MetroGrid();
            this.radSpellChecker1 = new Telerik.WinControls.UI.RadSpellChecker();
            this.GpBox_Searching = new Telerik.WinControls.UI.RadGroupBox();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.Timer_SelectCheckBox = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_Out = new System.Windows.Forms.Timer(this.components);
            this.Lbl_SelectedCount_Int = new System.Windows.Forms.Label();
            this.Lbl_SelectedCount = new System.Windows.Forms.Label();
            this.Btn_EditImages = new ns1.BunifuFlatButton();
            this.Btn_Bck = new ns1.BunifuFlatButton();
            this.Btn_Add = new ns1.BunifuFlatButton();
            this.Btn_DelRecord = new ns1.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Refresh = new ns1.BunifuFlatButton();
            this.Btn_Edit = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdVw_Searching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpBox_Searching)).BeginInit();
            this.GpBox_Searching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBx_Searching_Section
            // 
            this.CmbBx_Searching_Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBx_Searching_Section.FormattingEnabled = true;
            this.CmbBx_Searching_Section.Location = new System.Drawing.Point(7, 33);
            this.CmbBx_Searching_Section.Name = "CmbBx_Searching_Section";
            this.CmbBx_Searching_Section.Size = new System.Drawing.Size(192, 21);
            this.CmbBx_Searching_Section.TabIndex = 1;
            this.CmbBx_Searching_Section.DropDown += new System.EventHandler(this.CmbBx_Searching_Section_DropDown);
            this.CmbBx_Searching_Section.SelectedIndexChanged += new System.EventHandler(this.CmbBx_Searching_Section_SelectedIndexChanged);
            // 
            // TxtBx_SearchingValue
            // 
            this.TxtBx_SearchingValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtBx_SearchingValue.Location = new System.Drawing.Point(9, 115);
            this.TxtBx_SearchingValue.Name = "TxtBx_SearchingValue";
            this.TxtBx_SearchingValue.Size = new System.Drawing.Size(192, 22);
            this.TxtBx_SearchingValue.TabIndex = 2;
            this.TxtBx_SearchingValue.Visible = false;
            this.TxtBx_SearchingValue.TextChanged += new System.EventHandler(this.TxtBx_ValueSearch_TextChanged);
            this.TxtBx_SearchingValue.Enter += new System.EventHandler(this.TxtBx_ValueSearch_Enter);
            // 
            // CmbBx_SearchingModel
            // 
            this.CmbBx_SearchingModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBx_SearchingModel.FormattingEnabled = true;
            this.CmbBx_SearchingModel.Location = new System.Drawing.Point(7, 74);
            this.CmbBx_SearchingModel.Name = "CmbBx_SearchingModel";
            this.CmbBx_SearchingModel.Size = new System.Drawing.Size(192, 21);
            this.CmbBx_SearchingModel.TabIndex = 3;
            this.CmbBx_SearchingModel.Visible = false;
            this.CmbBx_SearchingModel.DropDown += new System.EventHandler(this.CmbBx_SearchingModel_DropDown);
            this.CmbBx_SearchingModel.SelectedIndexChanged += new System.EventHandler(this.CmbBx_SearchingModel_SelectedIndexChanged);
            this.CmbBx_SearchingModel.DropDownClosed += new System.EventHandler(this.CmbBx_SearchingModel_DropDownClosed);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 360);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(371, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "ابتدا تنظیمات جست و جو را انجام دهید.";
            // 
            // GrdVw_Searching
            // 
            this.GrdVw_Searching.AllowUserToResizeRows = false;
            this.GrdVw_Searching.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GrdVw_Searching.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdVw_Searching.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GrdVw_Searching.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdVw_Searching.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdVw_Searching.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdVw_Searching.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdVw_Searching.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdVw_Searching.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdVw_Searching.EnableHeadersVisualStyles = false;
            this.GrdVw_Searching.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdVw_Searching.GridColor = System.Drawing.Color.Black;
            this.GrdVw_Searching.Location = new System.Drawing.Point(16, 63);
            this.GrdVw_Searching.Name = "GrdVw_Searching";
            this.GrdVw_Searching.ReadOnly = true;
            this.GrdVw_Searching.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdVw_Searching.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdVw_Searching.RowHeadersVisible = false;
            this.GrdVw_Searching.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdVw_Searching.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdVw_Searching.Size = new System.Drawing.Size(544, 453);
            this.GrdVw_Searching.TabIndex = 28;
            this.GrdVw_Searching.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVw_Searching_CellClick);
            this.GrdVw_Searching.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVw_Searching_CellDoubleClick);
            this.GrdVw_Searching.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdVw_Searching_CellMouseDown);
            this.GrdVw_Searching.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdVw_Searching_CellMouseUp);
            this.GrdVw_Searching.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GrdVw_Searching_DataBindingComplete);
            // 
            // GpBox_Searching
            // 
            this.GpBox_Searching.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GpBox_Searching.Controls.Add(this.TxtBx_SearchingValue);
            this.GpBox_Searching.Controls.Add(this.CmbBx_SearchingModel);
            this.GpBox_Searching.Controls.Add(this.CmbBx_Searching_Section);
            this.GpBox_Searching.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.GpBox_Searching.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.GpBox_Searching.HeaderText = "تنظیمات جست و جو";
            this.GpBox_Searching.Location = new System.Drawing.Point(354, 522);
            this.GpBox_Searching.Name = "GpBox_Searching";
            this.GpBox_Searching.Size = new System.Drawing.Size(206, 155);
            this.GpBox_Searching.TabIndex = 31;
            this.GpBox_Searching.Text = "تنظیمات جست و جو";
            this.GpBox_Searching.ThemeName = "Office2010Black";
            // 
            // Timer_SelectCheckBox
            // 
            this.Timer_SelectCheckBox.Tick += new System.EventHandler(this.Timer_SelectCheckBox_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_Out
            // 
            this.timer_Out.Interval = 1;
            this.timer_Out.Tick += new System.EventHandler(this.timer_Out_Tick);
            // 
            // Lbl_SelectedCount_Int
            // 
            this.Lbl_SelectedCount_Int.AutoSize = true;
            this.Lbl_SelectedCount_Int.Font = new System.Drawing.Font("A Soraya", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_SelectedCount_Int.Location = new System.Drawing.Point(354, 677);
            this.Lbl_SelectedCount_Int.Name = "Lbl_SelectedCount_Int";
            this.Lbl_SelectedCount_Int.Size = new System.Drawing.Size(14, 23);
            this.Lbl_SelectedCount_Int.TabIndex = 40;
            this.Lbl_SelectedCount_Int.Text = "0";
            this.Lbl_SelectedCount_Int.Visible = false;
            // 
            // Lbl_SelectedCount
            // 
            this.Lbl_SelectedCount.AutoSize = true;
            this.Lbl_SelectedCount.Font = new System.Drawing.Font("A Soraya", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_SelectedCount.Location = new System.Drawing.Point(464, 681);
            this.Lbl_SelectedCount.Name = "Lbl_SelectedCount";
            this.Lbl_SelectedCount.Size = new System.Drawing.Size(94, 19);
            this.Lbl_SelectedCount.TabIndex = 39;
            this.Lbl_SelectedCount.Text = "تعداد انتخاب شده:";
            this.Lbl_SelectedCount.Visible = false;
            // 
            // Btn_EditImages
            // 
            this.Btn_EditImages.Activecolor = System.Drawing.Color.SeaGreen;
            this.Btn_EditImages.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_EditImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_EditImages.BorderRadius = 0;
            this.Btn_EditImages.ButtonText = "ویرایش عکس های بیمار";
            this.Btn_EditImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EditImages.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_EditImages.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_EditImages.Iconimage = global::Clinic_App.Properties.Resources.skeleton_view_on_x_ray;
            this.Btn_EditImages.Iconimage_right = null;
            this.Btn_EditImages.Iconimage_right_Selected = null;
            this.Btn_EditImages.Iconimage_Selected = null;
            this.Btn_EditImages.IconMarginLeft = 0;
            this.Btn_EditImages.IconMarginRight = 0;
            this.Btn_EditImages.IconRightVisible = true;
            this.Btn_EditImages.IconRightZoom = 0D;
            this.Btn_EditImages.IconVisible = true;
            this.Btn_EditImages.IconZoom = 90D;
            this.Btn_EditImages.IsTab = false;
            this.Btn_EditImages.Location = new System.Drawing.Point(16, 578);
            this.Btn_EditImages.Name = "Btn_EditImages";
            this.Btn_EditImages.Normalcolor = System.Drawing.Color.SeaGreen;
            this.Btn_EditImages.OnHovercolor = System.Drawing.Color.SpringGreen;
            this.Btn_EditImages.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_EditImages.selected = false;
            this.Btn_EditImages.Size = new System.Drawing.Size(139, 53);
            this.Btn_EditImages.TabIndex = 41;
            this.Btn_EditImages.Tag = "";
            this.Btn_EditImages.Text = "ویرایش عکس های بیمار";
            this.Btn_EditImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_EditImages.Textcolor = System.Drawing.SystemColors.Window;
            this.Btn_EditImages.TextFont = new System.Drawing.Font("A Soraya", 8F);
            this.Btn_EditImages.Visible = false;
            this.Btn_EditImages.Click += new System.EventHandler(this.Btn_EditImages_Click);
            // 
            // Btn_Bck
            // 
            this.Btn_Bck.Activecolor = System.Drawing.Color.Teal;
            this.Btn_Bck.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Bck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Bck.BorderRadius = 0;
            this.Btn_Bck.ButtonText = "بازگشت به فرم قبل";
            this.Btn_Bck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Bck.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Bck.ForeColor = System.Drawing.Color.White;
            this.Btn_Bck.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Bck.Iconimage = global::Clinic_App.Properties.Resources.back_arrow_button;
            this.Btn_Bck.Iconimage_right = null;
            this.Btn_Bck.Iconimage_right_Selected = null;
            this.Btn_Bck.Iconimage_Selected = null;
            this.Btn_Bck.IconMarginLeft = 0;
            this.Btn_Bck.IconMarginRight = 0;
            this.Btn_Bck.IconRightVisible = true;
            this.Btn_Bck.IconRightZoom = 0D;
            this.Btn_Bck.IconVisible = true;
            this.Btn_Bck.IconZoom = 60D;
            this.Btn_Bck.IsTab = false;
            this.Btn_Bck.Location = new System.Drawing.Point(16, 637);
            this.Btn_Bck.Name = "Btn_Bck";
            this.Btn_Bck.Normalcolor = System.Drawing.Color.LightGray;
            this.Btn_Bck.OnHovercolor = System.Drawing.Color.DarkGray;
            this.Btn_Bck.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_Bck.selected = false;
            this.Btn_Bck.Size = new System.Drawing.Size(116, 51);
            this.Btn_Bck.TabIndex = 34;
            this.Btn_Bck.Text = "بازگشت به فرم قبل";
            this.Btn_Bck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Bck.Textcolor = System.Drawing.Color.Black;
            this.Btn_Bck.TextFont = new System.Drawing.Font("B Koodak", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Bck.Click += new System.EventHandler(this.Btn_BackToSettings_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Activecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Add.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Add.BorderRadius = 0;
            this.Btn_Add.ButtonText = "اضافه کردن به لیست";
            this.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Add.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Add.Iconimage = global::Clinic_App.Properties.Resources.round_add_button_copy2;
            this.Btn_Add.Iconimage_right = null;
            this.Btn_Add.Iconimage_right_Selected = null;
            this.Btn_Add.Iconimage_Selected = null;
            this.Btn_Add.IconMarginLeft = 0;
            this.Btn_Add.IconMarginRight = 0;
            this.Btn_Add.IconRightVisible = true;
            this.Btn_Add.IconRightZoom = 0D;
            this.Btn_Add.IconVisible = true;
            this.Btn_Add.IconZoom = 70D;
            this.Btn_Add.IsTab = false;
            this.Btn_Add.Location = new System.Drawing.Point(198, 522);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Normalcolor = System.Drawing.Color.SeaGreen;
            this.Btn_Add.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Add.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_Add.selected = false;
            this.Btn_Add.Size = new System.Drawing.Size(139, 53);
            this.Btn_Add.TabIndex = 33;
            this.Btn_Add.Text = "اضافه کردن به لیست";
            this.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Add.Textcolor = System.Drawing.SystemColors.Window;
            this.Btn_Add.TextFont = new System.Drawing.Font("A Soraya", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Add.Visible = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_DelRecord
            // 
            this.Btn_DelRecord.Activecolor = System.Drawing.Color.MediumBlue;
            this.Btn_DelRecord.BackColor = System.Drawing.Color.Crimson;
            this.Btn_DelRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_DelRecord.BorderRadius = 0;
            this.Btn_DelRecord.ButtonText = "حذف کردن انتخاب شده ها";
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
            this.Btn_DelRecord.IconZoom = 55D;
            this.Btn_DelRecord.IsTab = false;
            this.Btn_DelRecord.Location = new System.Drawing.Point(198, 641);
            this.Btn_DelRecord.Name = "Btn_DelRecord";
            this.Btn_DelRecord.Normalcolor = System.Drawing.Color.Crimson;
            this.Btn_DelRecord.OnHovercolor = System.Drawing.Color.Firebrick;
            this.Btn_DelRecord.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_DelRecord.selected = false;
            this.Btn_DelRecord.Size = new System.Drawing.Size(139, 47);
            this.Btn_DelRecord.TabIndex = 29;
            this.Btn_DelRecord.Text = "حذف کردن انتخاب شده ها";
            this.Btn_DelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_DelRecord.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Btn_DelRecord.TextFont = new System.Drawing.Font("A Soraya", 8F);
            this.Btn_DelRecord.Visible = false;
            this.Btn_DelRecord.Click += new System.EventHandler(this.Btn_DelRecord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Clinic_App.Properties.Resources.Pointer1;
            this.pictureBox1.Location = new System.Drawing.Point(406, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Activecolor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_Refresh.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Refresh.BorderRadius = 0;
            this.Btn_Refresh.ButtonText = "رفرش کردن لیست";
            this.Btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Refresh.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Refresh.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Refresh.Iconimage = global::Clinic_App.Properties.Resources.refresh_page_arrow_button;
            this.Btn_Refresh.Iconimage_right = null;
            this.Btn_Refresh.Iconimage_right_Selected = null;
            this.Btn_Refresh.Iconimage_Selected = null;
            this.Btn_Refresh.IconMarginLeft = 0;
            this.Btn_Refresh.IconMarginRight = 0;
            this.Btn_Refresh.IconRightVisible = true;
            this.Btn_Refresh.IconRightZoom = 0D;
            this.Btn_Refresh.IconVisible = true;
            this.Btn_Refresh.IconZoom = 40D;
            this.Btn_Refresh.IsTab = false;
            this.Btn_Refresh.Location = new System.Drawing.Point(198, 593);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Normalcolor = System.Drawing.Color.SeaGreen;
            this.Btn_Refresh.OnHovercolor = System.Drawing.Color.PaleGreen;
            this.Btn_Refresh.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_Refresh.selected = false;
            this.Btn_Refresh.Size = new System.Drawing.Size(139, 31);
            this.Btn_Refresh.TabIndex = 27;
            this.Btn_Refresh.Text = "رفرش کردن لیست";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Refresh.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Refresh.TextFont = new System.Drawing.Font("A Soraya", 8F);
            this.Btn_Refresh.Visible = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Activecolor = System.Drawing.Color.SeaGreen;
            this.Btn_Edit.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Edit.BorderRadius = 0;
            this.Btn_Edit.ButtonText = "ویرایش اطلاعات";
            this.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Edit.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Edit.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Edit.Iconimage = global::Clinic_App.Properties.Resources.user1;
            this.Btn_Edit.Iconimage_right = null;
            this.Btn_Edit.Iconimage_right_Selected = null;
            this.Btn_Edit.Iconimage_Selected = null;
            this.Btn_Edit.IconMarginLeft = 0;
            this.Btn_Edit.IconMarginRight = 0;
            this.Btn_Edit.IconRightVisible = true;
            this.Btn_Edit.IconRightZoom = 0D;
            this.Btn_Edit.IconVisible = true;
            this.Btn_Edit.IconZoom = 90D;
            this.Btn_Edit.IsTab = false;
            this.Btn_Edit.Location = new System.Drawing.Point(16, 522);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Normalcolor = System.Drawing.Color.SeaGreen;
            this.Btn_Edit.OnHovercolor = System.Drawing.Color.SpringGreen;
            this.Btn_Edit.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_Edit.selected = false;
            this.Btn_Edit.Size = new System.Drawing.Size(139, 53);
            this.Btn_Edit.TabIndex = 26;
            this.Btn_Edit.Text = "ویرایش اطلاعات";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Edit.Textcolor = System.Drawing.SystemColors.Window;
            this.Btn_Edit.TextFont = new System.Drawing.Font("A Soraya", 9F);
            this.Btn_Edit.Visible = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Form_Searching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 706);
            this.Controls.Add(this.Btn_EditImages);
            this.Controls.Add(this.Lbl_SelectedCount_Int);
            this.Controls.Add(this.Btn_Bck);
            this.Controls.Add(this.Lbl_SelectedCount);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.GpBox_Searching);
            this.Controls.Add(this.Btn_DelRecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdVw_Searching);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Edit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Searching";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "جست جو ، ویرایش بیماران و پزشکان";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Searching_FormClosing);
            this.Load += new System.EventHandler(this.Form_Searching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdVw_Searching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GpBox_Searching)).EndInit();
            this.GpBox_Searching.ResumeLayout(false);
            this.GpBox_Searching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbBx_Searching_Section;
        private System.Windows.Forms.TextBox TxtBx_SearchingValue;
        private System.Windows.Forms.ComboBox CmbBx_SearchingModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuFlatButton Btn_Edit;
        internal ns1.BunifuFlatButton Btn_Refresh;
        private MetroFramework.Controls.MetroGrid GrdVw_Searching;
        private ns1.BunifuFlatButton Btn_DelRecord;
        private Telerik.WinControls.UI.RadSpellChecker radSpellChecker1;
        private Telerik.WinControls.UI.RadGroupBox GpBox_Searching;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private ns1.BunifuFlatButton Btn_Add;
        private System.Windows.Forms.Timer Timer_SelectCheckBox;
        private System.Windows.Forms.Timer timer1;
        private ns1.BunifuFlatButton Btn_Bck;
        private System.Windows.Forms.Timer timer_Out;
        private System.Windows.Forms.Label Lbl_SelectedCount_Int;
        private System.Windows.Forms.Label Lbl_SelectedCount;
        private ns1.BunifuFlatButton Btn_EditImages;
    }
}