using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;
using Telerik.WinControls;
using Excel = Microsoft.Office.Interop.Excel;
//using CustomToolTipDemo.Properties;

namespace Clinic_App
{
    using MetroFramework;
    using System.Linq;
    using Telerik.WinControls.UI;

    public partial class Form_Settings : MetroFramework.Forms.MetroForm
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();

        private void Form_Settings_Load(object sender, EventArgs e)
        {

            GrdVw_Drs.DefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);
            GrdVw_Pats.DefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);
            GrdVw_Reception.DefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);
            GrdVw_Sec.DefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);
            GrdVw_Ser.DefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);

            if (Trans_Class.Flag_Back_from_srchingfrm == false)
            {
                Btn_Search.Text = "جست و جو";

                Set_Form_Settings();
                GrdVw_Reception.ClearSelection();
                GrdVw_Reception.FirstDisplayedScrollingRowIndex = GrdVw_Reception.Rows.Count - 1;
                GrdVw_Reception.Rows[GrdVw_Reception.Rows.Count - 1].Selected = true;
            }
            else
            {
                Btn_Shw_Othr_Click(null, null);
                Btn_Search.Visible = true;
                //Trans_Class.Flag_Back_from_srchingfrm = false;
            }

            //radMenuItem_Download_From_Excel.PerformClick();
        }

        public void Add_CheckBox_To_RecGrdVw()
        {
            checkColumn.Name = "checkColumn";
            checkColumn.DataPropertyName = "checkColumn";
            checkColumn.HeaderText = "انتخاب نوبت";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10;
            GrdVw_Reception.Columns.Insert(0, checkColumn);
        }

        public void Set_Form_Settings()
        {
            GrdVw_Reception.Columns.Clear();
            GrdVw_Reception.ClearSelection();

            Btn_Search.Visible = true;

            try
            {
                Add_CheckBox_To_RecGrdVw();
            }
            catch (Exception)
            {
                GrdVw_Reception.Columns.Remove("checkColumn");
                Add_CheckBox_To_RecGrdVw();
            }

            GrdVw_Reception.ColumnHeadersHeight = 45;
            GrdVw_Reception.ColumnHeadersDefaultCellStyle.Font = new Font("Vazir", 10, FontStyle.Bold);

            Model.DB_ClinicEntities Obj_DB_Ref = new Model.DB_ClinicEntities();
            GrdVw_Reception.DataSource = "";
            GrdVw_Reception.DataSource = Obj_DB_Ref.Vw_Reception.ToList();

            Btn_Edit.Visible = false;
            Btn_DelRecord.Visible = false;


            GrdVw_Reception.Columns["ID"].Visible = false;

            for (int i = 0; i < GrdVw_Reception.RowCount; i++)
            {
                if (GrdVw_Reception.Rows[i].Cells["VisitDate"].Value == null || GrdVw_Reception.Rows[i].Cells["VisitTime"].Value == null)
                {
                    GrdVw_Reception.Rows[i].Cells["VisitTime"].Value = "ثبت نشده";
                    GrdVw_Reception.Rows[i].Cells["VisitDate"].Value = "ثبت نشده";
                }
            }
            if (GrdVw_Reception.Columns.Contains("img_String") || GrdVw_Reception.Columns.Contains("RoleID_String"))
            {
                GrdVw_Reception.Columns["img_String"].Visible = false;
                GrdVw_Reception.Columns["RoleID_String"].Visible = false;
            }

            GrdVw_Reception.Columns["name"].HeaderText = "نام بیمار";
            GrdVw_Reception.Columns["mobile"].HeaderText = "شماره همراه";
            GrdVw_Reception.Columns["ServTitle"].HeaderText = "سرویس مربوطه";
            GrdVw_Reception.Columns["SecTitle"].HeaderText = "بخش مربوطه";
            GrdVw_Reception.Columns["Dr_Name"].HeaderText = "نام دکتر مربوطه";
            GrdVw_Reception.Columns["VisitTime"].HeaderText = "ساعت نوبت";
            GrdVw_Reception.Columns["VisitDate"].HeaderText = "تاریخ نوبت";

            GrdVw_Reception.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Reception.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;

            GrdVw_Reception.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            GrdVw_Reception.DefaultCellStyle.SelectionForeColor = Color.White;

            GrdVw_Reception.ForeColor = Color.Black;

            CmbBx_SelectSearchingModeInReception();

            Trans_Class.Flag_Back_from_srchingfrm = false;
        }

        private void CmbBx_SelectSearchingModeInReception()
        {
            CmbBx_SelectSearchingModeInReception_Metro.Items.Clear();
            CmbBx_SelectSearchingModeInReception_Metro.Name = "CmbBx_SelectSearchingModeInReception_Metro";

            CmbBx_SelectSearchingModeInReception_Metro.Items.Insert(0, "جست و جو در لیست نوبت ها");
            CmbBx_SelectSearchingModeInReception_Metro.SelectedIndex = 0;

            CmbBx_SelectSearchingModeInReception_Metro.Items.Add("جست و جو براساس نام بیمار");
            CmbBx_SelectSearchingModeInReception_Metro.Items.Add("جست و جو بر اساس نام پزشک مربوطه");
            CmbBx_SelectSearchingModeInReception_Metro.Items.Add("جست و جو بر اساس شماره همراه بیمار");
            CmbBx_SelectSearchingModeInReception_Metro.Items.Add("جست و جو بر اساس بخش مربوطه");
            CmbBx_SelectSearchingModeInReception_Metro.Items.Add("جست و جو بر اساس سرویس مربوطه");
            CmbBx_SelectSearchingModeInReception_Metro.Items.Add("خروج از حالت جست و جو");

            CmbBx_SelectSearchingModeInReception_Metro.Size = new Size(230, 23);

            CmbBx_SelectSearchingModeInReception_Metro.FontSize = MetroComboBoxSize.Small;

            CmbBx_SelectSearchingModeInReception_Metro.Location = new Point(156, 628);


            SearchingInReceptionModelIndex = -1;
            this.CmbBx_SelectSearchingModeInReception_Metro.DropDownStyle = ComboBoxStyle.DropDownList;

            CmbBx_SelectSearchingModeInReception_Metro.RightToLeft = RightToLeft.Yes;
            CmbBx_SelectSearchingModeInReception_Metro.Theme = MetroThemeStyle.Light;
            CmbBx_SelectSearchingModeInReception_Metro.Style = MetroColorStyle.Teal;



            CmbBx_SelectSearchingModeInReception_Metro.Text = "";
            CmbBx_SelectSearchingModeInReception_Metro.Visible = false;
            this.CmbBx_SelectSearchingModeInReception_Metro.SelectedIndexChanged += new System.EventHandler(this.CmbBx_SelectSearchingModeInReception_SelectedIndexChanged);

            this.CmbBx_SelectSearchingModeInReception_Metro.DropDown += CmbBx_SelectSearchingModeInReception_DropedDown;

            this.Controls.Add(CmbBx_SelectSearchingModeInReception_Metro);

            TxtBx_SearchingValue.Visible = false;

            // this.CmbBx_SelectSearchingModeInReception_Metro.DrawItem += new DrawItemEventHandler(this.CmbBx_SelectSearchingModeInReception_Metro_DrawItem);
        }

        //private void CmbBx_SelectSearchingModeInReception_Metro_DrawItem(object sender, DrawItemEventArgs e)
        //{

        //}

        MetroFramework.Controls.MetroComboBox CmbBx_SelectSearchingModeInReception_Metro = new MetroFramework.Controls.MetroComboBox();
        private void CmbBx_SelectSearchingModeInReception_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchingInReceptionModelIndex = CmbBx_SelectSearchingModeInReception_Metro.SelectedIndex;

            TxtBx_SearchingValue.Visible = true;

            if (SearchingInReceptionModelIndex == 0)
            {
                TxtBx_SearchingValue.Text = "نام بیمار مورد نظر را وارد کنید";

                SearchingPatNameFlag = true;
                SearchingDrNameFlag = false;
                SearchingPatPhoneNoFlag = false;
                SearchingSecFlag = false;
                SearchingSerFlag = false;
            }
            if (SearchingInReceptionModelIndex == 1)
            {
                TxtBx_SearchingValue.Text = "نام دکتر مورد نظر را وارد کنید";

                SearchingDrNameFlag = true;
                SearchingPatNameFlag = false;
                SearchingPatPhoneNoFlag = false;
                SearchingSecFlag = false;
                SearchingSerFlag = false;
            }
            if (SearchingInReceptionModelIndex == 2)
            {
                TxtBx_SearchingValue.Text = "شماره همراه بیمار را وارد کنید";

                SearchingPatPhoneNoFlag = true;
                SearchingDrNameFlag = false;
                SearchingPatNameFlag = false;
                SearchingSecFlag = false;
                SearchingSerFlag = false;
            }
            if (SearchingInReceptionModelIndex == 3)
            {
                TxtBx_SearchingValue.Text = "نام بخش را وارد کنید";

                SearchingSecFlag = true;
                SearchingPatPhoneNoFlag = false;
                SearchingDrNameFlag = false;
                SearchingPatNameFlag = false;
                SearchingSerFlag = false;
            }
            if (SearchingInReceptionModelIndex == 4)
            {
                TxtBx_SearchingValue.Text = "نام سرویس را وارد کنید";

                SearchingSerFlag = true;
                SearchingSecFlag = false;
                SearchingPatPhoneNoFlag = false;
                SearchingDrNameFlag = false;
                SearchingPatNameFlag = false;
            }
            if (SearchingInReceptionModelIndex == 5)
            {
                Model.DB_ClinicEntities Obj_ClinicDB = new Model.DB_ClinicEntities();
                GrdVw_Reception.DataSource = Obj_ClinicDB.Vw_Reception.ToList();
                SearchingSerFlag = false;
                SearchingSecFlag = false;
                SearchingPatPhoneNoFlag = false;
                SearchingDrNameFlag = false;
                SearchingPatNameFlag = false;
                TxtBx_SearchingValue.Visible = false;
                Btn_Search.Visible = true;
                Btn_Edit.Visible = false;
                Btn_DelRecord.Visible = false;
                CmbBx_SelectSearchingModeInReception_Metro.Visible = false;
            }

        }
        private void TxtBx_SearchingValue_TextChanged(object sender, EventArgs e)
        {
            Model.DB_ClinicEntities Obj_ClinicDB = new Model.DB_ClinicEntities();

            if (SearchingPatNameFlag == true)
            {
                var SearchingSqlQuery = Obj_ClinicDB.Vw_Reception.Where(w => w.name.Contains(TxtBx_SearchingValue.Text)).ToList();

                if (SearchingSqlQuery.Count > 0)
                {
                    GrdVw_Reception.DataSource = "";
                    GrdVw_Reception.DataSource = SearchingSqlQuery.ToList();
                }
            }

            if (SearchingDrNameFlag == true)
            {
                var SearchingSqlQuery = Obj_ClinicDB.Vw_Reception.Where(w => w.Dr_Name.Contains(TxtBx_SearchingValue.Text)).ToList();
                if (SearchingSqlQuery.Count > 0)
                {
                    GrdVw_Reception.DataSource = "";
                    GrdVw_Reception.DataSource = SearchingSqlQuery.ToList();
                }
            }

            if (SearchingPatPhoneNoFlag == true)
            {
                var SearchingSqlQuery = Obj_ClinicDB.Vw_Reception.Where(w => w.mobile.Contains(TxtBx_SearchingValue.Text)).ToList();
                if (SearchingSqlQuery.Count > 0)
                {
                    GrdVw_Reception.DataSource = "";
                    GrdVw_Reception.DataSource = SearchingSqlQuery.ToList();
                }
            }

            if (SearchingSerFlag == true)
            {
                var SearchingSqlQuery = Obj_ClinicDB.Vw_Reception.Where(w => w.ServTitle.Contains(TxtBx_SearchingValue.Text)).ToList();
                if (SearchingSqlQuery.Count > 0)
                {
                    GrdVw_Reception.DataSource = "";
                    GrdVw_Reception.DataSource = SearchingSqlQuery.ToList();
                }
            }
            if (SearchingSecFlag == true)
            {
                var SearchingSqlQuery = Obj_ClinicDB.Vw_Reception.Where(w => w.SecTitle.Contains(TxtBx_SearchingValue.Text)).ToList();
                if (SearchingSqlQuery.Count > 0)
                {
                    GrdVw_Reception.DataSource = "";
                    GrdVw_Reception.DataSource = SearchingSqlQuery.ToList();
                }

            }



            GrdVw_Reception.Columns["ID"].Visible = false;

            GrdVw_Reception.Columns["name"].HeaderText = "نام بیمار";
            GrdVw_Reception.Columns["mobile"].HeaderText = "شماره همراه";
            GrdVw_Reception.Columns["ServTitle"].HeaderText = "سرویس مربوطه";
            GrdVw_Reception.Columns["SecTitle"].HeaderText = "بخش مربوطه";
            GrdVw_Reception.Columns["Dr_Name"].HeaderText = "نام دکتر مربوطه";
            GrdVw_Reception.Columns["VisitTime"].HeaderText = "ساعت نوبت";
            GrdVw_Reception.Columns["VisitDate"].HeaderText = "تاریخ نوبت";

            for (int i = 0; i < GrdVw_Reception.RowCount; i++)
            {
                if (GrdVw_Reception.Rows[i].Cells["VisitDate"].Value == null || GrdVw_Reception.Rows[i].Cells["VisitTime"].Value == null)
                {
                    GrdVw_Reception.Rows[i].Cells["VisitTime"].Value = "ثبت نشده";
                    GrdVw_Reception.Rows[i].Cells["VisitDate"].Value = "ثبت نشده";
                }
            }
        }

        private void CmbBx_SelectSearchingModeInReception_DropedDown(object sender, EventArgs e)
        {
            CmbBx_SelectSearchingModeInReception_Metro.Items.Remove("جست و جو در لیست نوبت ها");
        }


        private void Btn_Shw_Othr_Click(object sender, EventArgs e)
        {
            //Form_Waiting Frm_Wait = new Form_Waiting();
            ///*Frm_Wait.Activate();*/
            //backgroundWorker_SetSettings.RunWorkerAsync(Frm_Wait);
            //Frm_Wait.Show();

            Model.DB_ClinicEntities Obj_ClinicDB = new Model.DB_ClinicEntities();

            Btn_Add_To_DB.Visible = false;

            Lbl_SelectedCount.Visible = false;
            Lbl_SelectedCount_Int.Visible = false;

            Flag_EditUsers = false;

            Lbl_Users.Visible = false;

            GrdVw_Reception.Visible = false;
            Lbl_Reception.Visible = false;

            GrdVw_Drs.Visible = true;
            Lbl_Drs.Visible = true;

            GrdVw_Pats.Visible = true;
            Lbl_Pat.Visible = true;

            GrdVw_Sec.Visible = true;
            Lbl_ُSec.Visible = true;

            GrdVw_Ser.Visible = true;
            Lbl_ُSer.Visible = true;

            Btn_ShwReception.Visible = true;
            Btn_Shw_Othr.Visible = false;

            //GrdView Drs..........................................................................

            GrdVw_Drs.Columns.Clear();

            GrdVw_Drs.DataSource = "";
            GrdVw_Drs.DataSource = Obj_ClinicDB.Tbl_Doctor.ToList();
            GrdVw_Drs.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Drs.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;

            GrdVw_Drs.ColumnHeadersDefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);

            GrdVw_Drs.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            GrdVw_Drs.DefaultCellStyle.SelectionForeColor = Color.White;
            GrdVw_Drs.ForeColor = Color.Black;

            GrdVw_Drs.Columns["Tbl_Reception"].Visible = false;
            GrdVw_Drs.Columns["ID"].HeaderText = "ردیف";
            GrdVw_Drs.Columns["name_dr"].HeaderText = "نام";
            GrdVw_Drs.Columns["Skill"].HeaderText = "تخصص";
            GrdVw_Drs.Columns["MedicalCode"].HeaderText = "کد نظام پزشکی";
            GrdVw_Drs.Columns["Ncode"].HeaderText = "کد ملی";
            GrdVw_Drs.Columns["Mobile"].HeaderText = "شماره همراه";
            GrdVw_Drs.Columns["adrs"].HeaderText = "آدرس";
            GrdVw_Drs.Columns["Image_Dr"].Visible = false;
            //GrdVw_Pats.Columns["Image_Dr"].Visible = false;

            GrdVw_Drs.RightToLeft = RightToLeft.No;

            //GrdView Drs..........................................................................End


            //GrdView Pats..........................................................................

            GrdVw_Pats.Columns.Clear();

            GrdVw_Pats.DataSource = "";
            GrdVw_Pats.DataSource = Obj_ClinicDB.Tbl_Patient.ToList();
            GrdVw_Pats.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Pats.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;

            GrdVw_Pats.ColumnHeadersDefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);

            GrdVw_Pats.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            GrdVw_Pats.DefaultCellStyle.SelectionForeColor = Color.White;
            GrdVw_Pats.ForeColor = Color.Black;

            GrdVw_Pats.Columns["Tbl_Reception"].Visible = false;
            GrdVw_Pats.Columns["ID"].HeaderText = "ردیف";
            GrdVw_Pats.Columns["name"].HeaderText = "نام بیمار";
            GrdVw_Pats.Columns["adrs"].HeaderText = "آدرس";
            GrdVw_Pats.Columns["mobile"].HeaderText = "شماره تماس";
            GrdVw_Pats.Columns["Ncode"].HeaderText = "کدملی";
            GrdVw_Pats.Columns["adrs"].HeaderText = "آدرس";
            GrdVw_Pats.Columns["CountOfPictures"].Visible = false;
            GrdVw_Pats.Columns["Tbl_Pat_Images"].Visible = false;

            DataGridViewImageColumn Grdvw_ImgCol = new DataGridViewImageColumn();
            Grdvw_ImgCol.Width = 10;
            Grdvw_ImgCol.Name = "Grdvw_ImgCol";
            Grdvw_ImgCol.ImageLayout = DataGridViewImageCellLayout.NotSet;
            GrdVw_Pats.Columns.Add(Grdvw_ImgCol);
            Grdvw_ImgCol.HeaderText = "عکس";
            GrdVw_Pats.RightToLeft = RightToLeft.No;

            for (int i = 0; i < GrdVw_Pats.Rows.Count; i++)
            {
                if (Convert.ToInt32(GrdVw_Pats.Rows[i].Cells["CountOfPictures"].Value) == 0)
                {
                    GrdVw_Pats.Rows[i].Cells["Grdvw_ImgCol"].Value = Clinic_App.Properties.Resources.GCrossSmallRed;
                }
                else
                {
                    GrdVw_Pats.Rows[i].Cells["Grdvw_ImgCol"].Value = Clinic_App.Properties.Resources.GtickSmallGreen1;
                }
            }
            //GrdVw_Pats.Columns["Image_Dr"].Visible = false;

            //GrdView Pats..........................................................................End

            //GrdView Ser And Sec..........................................................................End

            GrdVw_Sec.DataSource = "";
            GrdVw_Sec.DataSource = Obj_ClinicDB.Tbl_Section.ToList();
            GrdVw_Sec.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Sec.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;

            GrdVw_Sec.ColumnHeadersDefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);

            GrdVw_Sec.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            GrdVw_Sec.DefaultCellStyle.SelectionForeColor = Color.White;
            GrdVw_Sec.ForeColor = Color.Black;

            GrdVw_Sec.Columns[2].Visible = false;
            GrdVw_Sec.Columns[0].Visible = false;
            GrdVw_Sec.Columns[1].HeaderText = "عنوان بخش";



            GrdVw_Ser.DataSource = "";
            GrdVw_Ser.DataSource = Obj_ClinicDB.Tbl_Service.ToList();
            GrdVw_Ser.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Ser.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;

            GrdVw_Ser.ColumnHeadersDefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);

            GrdVw_Ser.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            GrdVw_Ser.DefaultCellStyle.SelectionForeColor = Color.White;
            GrdVw_Ser.ForeColor = Color.Black;

            GrdVw_Ser.Columns[1].HeaderText = "عنوان سرویس";
            GrdVw_Ser.Columns[2].Visible = false;
            GrdVw_Ser.Columns[0].Visible = false;

            CmbBx_SelectSearchingModeInReception_Metro.Visible = false;
            Btn_Search.Visible = true;
            Btn_Search.Text = "جست و جو و ویرایش\n\tجدول های بالا";

            Btn_Search.TextFont = new Font("B Koodak", 12, FontStyle.Bold);


            Btn_Search.Size = new Size(123 + 60, 55);

            Btn_DelRecord.Visible = false;
            Btn_Edit.Visible = false;
            TxtBx_SearchingValue.Visible = false;

            GrdVw_Sec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdVw_Ser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdVw_Ser.ScrollBars = ScrollBars.None;
            GrdVw_Sec.ScrollBars = ScrollBars.None;

            Trans_Class.Flag_Back_from_srchingfrm = true;

        }

        private void Btn_ShwReception_Click(object sender, EventArgs e)
        {
            Btn_Add_To_DB.Visible = false;

            Flag_EditUsers = false;
            Btn_DelRecord.Text = "حذف کردن نوبت ها";
            Lbl_SelectedCount.Visible = false;
            Lbl_SelectedCount_Int.Visible = false;

            Lbl_Users.Visible = false;

            Btn_Search.Visible = true;
            Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Btn_Search.Text = "جست و جو";
            Btn_Search.TextFont = new Font("B Koodak", 15, FontStyle.Bold);
            Btn_Search.Size = new Size(149, 58);

            GrdVw_Drs.Visible = false;
            Lbl_Drs.Visible = false;

            GrdVw_Pats.Visible = false;
            Lbl_Pat.Visible = false;

            GrdVw_Sec.Visible = false;
            Lbl_ُSec.Visible = false;

            GrdVw_Ser.Visible = false;
            Lbl_ُSer.Visible = false;

            GrdVw_Reception.Visible = true;
            Lbl_Reception.Visible = true;

            Btn_Shw_Othr.Visible = true;
            Btn_ShwReception.Visible = false;

            Set_Form_Settings();

            GrdVw_Reception.ClearSelection();
            GrdVw_Reception.FirstDisplayedScrollingRowIndex = GrdVw_Reception.Rows.Count - 1;
            GrdVw_Reception.Rows[GrdVw_Reception.Rows.Count - 1].Selected = true;



        }

        Model.Tbl_Patient Obj_Pat_Tbl = new Model.Tbl_Patient();

        int SearchingInReceptionModelIndex = -1;
        bool SearchingPatNameFlag = false;
        bool SearchingDrNameFlag = false;
        bool SearchingPatPhoneNoFlag = false;
        bool SearchingSecFlag = false;
        bool SearchingSerFlag = false;
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Model.DB_ClinicEntities Obj_ClinicDB = new Model.DB_ClinicEntities();
            if (Pat_Name_Edit_Flag == true)
            {
                Obj_ClinicDB.SaveChanges();
                Pat_Name_Edit_Flag = false;
                Btn_Save.Visible = false;
                MessageBox.Show("مشخصات بیمار به روز شد");
            }

            if (Dr_Name_Edit_Flag == true)
            {
                Obj_ClinicDB.SaveChanges();
                Dr_Name_Edit_Flag = false;
                Btn_Save.Visible = false;
                MessageBox.Show("مشخصات پزشک به روز شد");
            }

        }

        bool Pat_Name_Edit_Flag = false;
        bool Dr_Name_Edit_Flag = false;

        private void TxtBx_SearchingValue_Enter(object sender, EventArgs e)
        {
            TxtBx_SearchingValue.ForeColor = SystemColors.WindowText;
            TxtBx_SearchingValue.Text = "";
        }

        List<DataGridViewRow> SelectedReceptionRows = new List<DataGridViewRow>();
        private void Btn_DelRecord_Click(object sender, EventArgs e)
        {
            Model.DB_ClinicEntities Obj_ClinicDB = new Model.DB_ClinicEntities();
            if (Flag_EditUsers == false)
            {
                if (MetroMessageBox.Show(this, "آیا برای حذف مطمعا هستید ؟", "پاک شوند ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {

                    SelectedReceptionRows = (from Rows in GrdVw_Reception.Rows.Cast<DataGridViewRow>()
                                             where Convert.ToBoolean(Rows.Cells["checkColumn"].Value) == true
                                             select Rows).ToList();

                    var GetSqlID = SelectedReceptionRows.Select(x => (int)x.Cells["ID"].Value).ToList();

                    var GetSqlRecord = Obj_ClinicDB.Tbl_Reception.Where(x => GetSqlID.Contains(x.ID));

                    foreach (var item in GetSqlRecord)
                    {
                        Obj_ClinicDB.Tbl_Reception.Remove(item);
                    }

                    Obj_ClinicDB.SaveChanges();
                    SelectedReceptionRows.Clear();

                    GrdVw_Reception.DataSource = "";
                    GrdVw_Reception.DataSource = Obj_ClinicDB.Vw_Reception.ToList();


                }

                Set_Form_Settings();
            }
            else
            {
                if (MetroMessageBox.Show(this, "آیا برای حذف مطمعا هستید ؟", "پاک شوند ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    SelectedReceptionRows = (from Rows in GrdVw_Reception.Rows.Cast<DataGridViewRow>()
                                             where Convert.ToBoolean(Rows.Cells["checkColumn"].Value) == true
                                             select Rows).ToList();

                    var GetSqlID = SelectedReceptionRows.Select(x => (int)x.Cells["ID"].Value).ToList();

                    var GetSqlRecord = Obj_ClinicDB.Tbl_User.Where(x => GetSqlID.Contains(x.ID));

                    foreach (var item in GetSqlRecord)
                    {
                        Obj_ClinicDB.Tbl_User.Remove(item);
                    }

                    Obj_ClinicDB.SaveChanges();
                    SelectedReceptionRows.Clear();

                    ToolStripMenuItem_EditUsers_Click_1(null, null);
                }

            }
            Btn_DelRecord.Visible = false;
            Btn_Edit.Visible = false;
            Lbl_SelectedCount.Visible = false;
            Lbl_SelectedCount_Int.Visible = false;
        }

        private void Btn_Bck_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //var Form = new Form_Main();
            //Form.Closed += (s, args) => this.Close();
            //Form.ShowDialog();

            this.Close();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Btn_Search.Text == "جست و جو")
            {
                Btn_Search.Visible = false;
                //CmbBx_SelectSearchingModeInReception.Visible = false;
                //  CmbBx_SelectSearchingModeInReception.Visible = true;
                CmbBx_SelectSearchingModeInReception_Metro.Visible = true;
            }

            else if (Btn_Search.Text == "جست و جو و ویرایش\n\tجدول های بالا")
            {

                Btn_Search.Visible = false;
                CmbBx_SelectSearchingModeInReception_Metro.Visible = false;

                this.Opacity = 0.3;
                var Obj_Form_Searching = new Form_Searching();
                Obj_Form_Searching.ShowDialog();
                this.Opacity = 1;
                Btn_Search.Visible = true;
            }

        }
        int VisitID = -1;
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Btn_Edit.Text == "ویرایش اطلاعات")
            {
                Trans_Class.Flag_Pat_Edit = false;
                Trans_Class.Flag_Visit_Edit = true;
                Trans_Class.Flag_Doc_Edit = false;

                for (int i = 0; i < GrdVw_Reception.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(GrdVw_Reception.Rows[i].Cells["checkColumn"].Value) == true)
                    {
                        VisitID = (int)GrdVw_Reception.Rows[i].Cells["ID"].Value;
                        Trans_Class.ID_Visit_Trans = VisitID;
                        Trans_Class.Date_Visit_Trans = GrdVw_Reception.Rows[i].Cells["VisitDate"].Value.ToString();
                        Trans_Class.Time_Visit_Trans = GrdVw_Reception.Rows[i].Cells["VisitTime"].Value.ToString();
                    }
                }

                this.Opacity = 0.4;
                Form_Edit1 Frm_Edit = new Form_Edit1();
                Frm_Edit.ShowDialog();
                this.Opacity = 1;

                Set_Form_Settings();

                this.Activate();

                GrdVw_Reception.ClearSelection();
                GrdVw_Reception.FirstDisplayedScrollingRowIndex = Rec_GridView_Selected_Index;
                GrdVw_Reception.Rows[Rec_GridView_Selected_Index].Selected = true;
            }
        }
        int Rec_GridView_Selected_Index;
        private void GrdVw_Reception_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (GrdVw_Reception.CurrentCellAddress.X == 0)
            //{
            //    if (GrdVw_Reception.IsCurrentCellDirty)
            //    {
            //        GrdVw_Reception.CommitEdit(DataGridViewDataErrorContexts.Commit);

            //    }
            //    if (Convert.ToBoolean(GrdVw_Reception.CurrentCell.Value) == false)
            //    {
            //        GrdVw_Reception.CurrentCell.Value = CheckState.Checked;
            //    }
            //    else
            //    {
            //        GrdVw_Reception.CurrentCell.Value = CheckState.Unchecked;
            //    }
            //    for (int j = 0; j < GrdVw_Reception.Rows.Count; j++)          //count has the total no of rows in datagrid
            //    {
            //        bool click = Convert.ToBoolean(GrdVw_Reception.Rows[j].Cells[0].Value);    //Cells[0] is the checkbox column
            //        if (click == true)
            //        {
            //            checkbox_count++;
            //            break;
            //        }
            //    }

            //    if (checkbox_count == 1)
            //    {
            //        Btn_Edit.Visible = true;
            //        Btn_DelRecord.Visible = true;
            //    }
            //    else
            //    {
            //        Btn_DelRecord.Visible = true;
            //        Btn_Edit.Visible = false;
            //    }
            // }

        }

        private void Edit_Reception_Click(object sender, EventArgs e)
        {
            radApplicationMenu1.DropDownButtonElement.HideDropDown();
            Btn_ShwReception_Click(null, null);
        }

        private void Edit_Other_Click(object sender, EventArgs e)
        {
            radApplicationMenu1.DropDownButtonElement.HideDropDown();
            Btn_Shw_Othr_Click(null, null);
        }


        private void Menu_Strip_SignUpForm_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.3;

            //Form_signUp__1.Owner = this;
            //DialogResult ds1=  Form_signUp__1.ShowDialog();

            Form_SignUp_Step_1 Form_signUp__1 = new Form_SignUp_Step_1();
            /*DialogResult ds = */
            DialogResult DS_S1 = Form_signUp__1.ShowDialog();
            if (DS_S1 == DialogResult.Cancel)
                MetroMessageBox.Show(this, "کاربر جدید به پایگاه داده اضافه نشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Menu_SubEditUsers.PerformClick();

            //if (ds == DialogResult.OK) 
            //{
            //    Trans_Class.ParentFormTr = Form_signUp__1;
            //    Form_SignUp_Step_2 Form_signUp__2 = new Form_SignUp_Step_2();

            //    if ((Form_signUp__2.ShowDialog()) == DialogResult.OK)
            //    {
            //        Form_SignUp_Step_3 Form_signUp__3 = new Form_SignUp_Step_3();
            //        if ((Form_signUp__3.ShowDialog()) == DialogResult.OK)
            //        {
            //            MessageBox.Show("SUCCED");
            //        }
            //        else
            //        {

            //        }
            //    }
            //    else
            //    {
            //        Trans_Class.ParentFormTr.Show();
            //    }
            //}
            //else
            //    MessageBox.Show("nashod1");
            //}


            //if (Form_signUp1.ShowDialog(this) == DialogResult.OK)
            //{
            //    var Form_signUp2 = new Form_SignUp_Step_2(Form_signUp1);
            //    Form_signUp2.ShowDialog();
            //}

            this.Opacity = 1;

            //Flag_EditUsers = false;
            //Dr_Name_Edit_Flag = false;
            //flag

        }

        private void Form_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }

        private void backgroundWorker_SetSettings_DoWork(object sender, DoWorkEventArgs e)
        {

            //GrdVw_Reception.Visible = false;
            //Lbl_Reception.Visible = false;
            //Btn_Search.Visible = false;
            //TxtBx_SearchingValue.Visible = false;
            //radWaitingBar1.Visible = true;
            //radWaitingBar1.StartWaiting();
        }

        private void GrdVw_Reception_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                Lbl_SelectedCount.Visible = true;
                Lbl_SelectedCount_Int.Visible = true;

                if (Convert.ToBoolean(GrdVw_Reception.Rows[e.RowIndex].Cells[0].Value) == true)
                {
                    GrdVw_Reception.Rows[e.RowIndex].Cells[0].Value = CheckState.Unchecked;
                }
                else
                {
                    GrdVw_Reception.Rows[GrdVw_Reception.CurrentCellAddress.Y].Cells[0].Value = CheckState.Checked;
                }

                int UpToOne = 0;

                for (int i = 0; i < GrdVw_Reception.Rows.Count; i++)
                {

                    if (Convert.ToBoolean(GrdVw_Reception.Rows[i].Cells[0].Value) == true)
                    {
                        GrdVw_Reception.Rows[i].Selected = true;
                        ++UpToOne;
                    }
                    else
                    {
                        GrdVw_Reception.Rows[i].Selected = false;
                    }
                    if (UpToOne == 1 && Convert.ToBoolean(GrdVw_Reception.Rows[i].Cells[0].Value) == true)
                        Rec_GridView_Selected_Index = i;

                }
                if (UpToOne == 0)
                {
                    Btn_DelRecord.Visible = false;
                    Btn_Edit.Visible = false;
                    Lbl_SelectedCount.Visible = false;
                    Lbl_SelectedCount_Int.Visible = false;
                }
                else if (UpToOne == 1 && Flag_EditUsers == false)
                {
                    Lbl_SelectedCount.Visible = false;
                    Lbl_SelectedCount_Int.Visible = false;
                    Btn_Edit.Visible = true;
                    Btn_DelRecord.Visible = true;
                    Btn_DelRecord.Location = new Point(408, 681);
                }
                else if (UpToOne >= 1)
                {
                    Lbl_SelectedCount.Visible = true;
                    Lbl_SelectedCount_Int.Visible = true;
                    Btn_Edit.Visible = false;
                    Btn_DelRecord.Visible = true;
                    Btn_DelRecord.Location = new Point(535, 680);
                }
                Lbl_SelectedCount_Int.Text = UpToOne.ToString();
            }
        }


        bool Flag_EditUsers = false;

        private void ToolStripMenuItem_EditUsers_Click_1(object sender, EventArgs e)
        {
            Trans_Class.Flag_Pat_Edit = false;
            Trans_Class.Flag_Visit_Edit = false;
            Trans_Class.Flag_Doc_Edit = false;

            Btn_DelRecord.Text = "حذف کردن کاربر ها";

            Btn_DelRecord.Location = Btn_Edit.Location;

            radApplicationMenu1.DropDownButtonElement.HideDropDown();
            GrdVw_Reception.Columns.Clear();
            GrdVw_Reception.ClearSelection();
            Add_CheckBox_To_RecGrdVw();

            Flag_EditUsers = true;
            Lbl_Users.Visible = true;
            Lbl_Users.Location = new Point(281, 90);

            GrdVw_Reception.Visible = true;

            //GrdVw_Reception.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //GrdVw_Reception.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //GrdVw_Reception.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.TxtBx_SearchingValue.Visible = false;
            CmbBx_SelectSearchingModeInReception_Metro.Visible = false;


            this.GrdVw_Drs.Visible = false;
            this.GrdVw_Pats.Visible = false;
            Lbl_Drs.Visible = false;
            Lbl_Pat.Visible = false;

            GrdVw_Sec.Visible = false;
            Lbl_ُSec.Visible = false;
            GrdVw_Ser.Visible = false;
            Lbl_ُSer.Visible = false;

            this.Btn_Shw_Othr.Visible = false;
            this.Btn_ShwReception.Visible = false;
            this.Btn_Search.Visible = false;
            this.Btn_Save.Visible = false;
            this.Btn_Edit.Visible = false;
            this.Lbl_Reception.Visible = false;

            Btn_ShwReception.Visible = true;
            Btn_Shw_Othr.Visible = false;

            Model.DB_ClinicEntities Obj_ClinicDB = new Model.DB_ClinicEntities();
            GrdVw_Reception.DataSource = "";
            GrdVw_Reception.DataSource = Obj_ClinicDB.Tbl_User.ToList();

            GrdVw_Reception.Columns["UserName"].HeaderText = "نام کابری";
            GrdVw_Reception.Columns["NameAndFamily"].HeaderText = "نام و نام خانوادگی";
            GrdVw_Reception.Columns["Mail"].HeaderText = "ایمیل";
            GrdVw_Reception.Columns["Mob"].HeaderText = "تلفن";
            GrdVw_Reception.Columns["img"].HeaderText = "تصویر کاربر";
            GrdVw_Reception.Columns["RoleID"].HeaderText = "نقش کاربر";

            GrdVw_Reception.Columns["Pass"].Visible = false;
            GrdVw_Reception.Columns["RoleID"].Visible = false;
            GrdVw_Reception.Columns["ID"].Visible = false;
            GrdVw_Reception.Columns["Tbl_Role"].Visible = false;

            GrdVw_Reception.Columns.Add("img_String", "عکس");
            GrdVw_Reception.Columns.Add("RoleID_String", "نقش کاربر");

            GrdVw_Reception.Columns["checkColumn"].DisplayIndex = 0;
            GrdVw_Reception.Columns["NameAndFamily"].DisplayIndex = 3;
            GrdVw_Reception.Columns["RoleID_String"].DisplayIndex = 4;
            GrdVw_Reception.Columns["Mob"].DisplayIndex = 5;
            GrdVw_Reception.Columns["Mail"].DisplayIndex = 6;
            GrdVw_Reception.Columns["img_String"].DisplayIndex = 7;

            DataGridViewImageColumn Grdvw_ImgCol = new DataGridViewImageColumn();
            Grdvw_ImgCol.Width = 20;
            Grdvw_ImgCol.Name = "Grdvw_ImgCol";
            Grdvw_ImgCol.ImageLayout = DataGridViewImageCellLayout.NotSet;
            GrdVw_Reception.Columns.Add(Grdvw_ImgCol);
            GrdVw_Reception.Visible = true;
            Grdvw_ImgCol.DisplayIndex = 8;
            Grdvw_ImgCol.HeaderText = "";

            GrdVw_Reception.Columns["img"].Visible = false;

            for (int i = 0; i < GrdVw_Reception.Rows.Count; i++)
            {

                if (GrdVw_Reception.Rows[i].Cells["img"].Value == null)
                {
                    this.GrdVw_Reception.Rows[i].Cells["img_String"].Value = "ذخیره نشده";
                    this.GrdVw_Reception.Rows[i].Cells["img_String"].Tag = 0;
                    GrdVw_Reception.Rows[i].Cells["Grdvw_ImgCol"].Value = Clinic_App.Properties.Resources.GCrossSmallRed;
                }
                else
                {
                    this.GrdVw_Reception.Rows[i].Cells["img_String"].Value = "ذخیره شده";
                    this.GrdVw_Reception.Rows[i].Cells["img_String"].Tag = 1;
                    GrdVw_Reception.Rows[i].Cells["Grdvw_ImgCol"].Value = Clinic_App.Properties.Resources.GtickSmallGreen1;
                }

                if (Convert.ToInt32(GrdVw_Reception.Rows[i].Cells["RoleID"].Value) == 1)
                {
                    GrdVw_Reception.Rows[i].Cells["RoleID_String"].Value = "مدیر کل";
                }
                else if (Convert.ToInt32(GrdVw_Reception.Rows[i].Cells["RoleID"].Value) == 2)
                {
                    GrdVw_Reception.Rows[i].Cells["RoleID_String"].Value = "منشی";
                }
                else
                {
                    GrdVw_Reception.Rows[i].Cells["RoleID_String"].Value = "اپراتور";
                }
            }
        }

        private void Menu_BackMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            if (Img_Size_For_TT != null)
            {
                Point pp = new Point(Img_Size_For_TT.Size);
                e.ToolTipSize = new Size(pp);
            }

        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            if (Img_Size_For_TT != null)
            {
                e.Graphics.DrawImage(Img_Size_For_TT, 0, 0);
            }
        }
        Model.Tbl_User Obj_Tbl_User = new Model.Tbl_User();
        Model.DB_ClinicEntities Obj_DB_Entire = new Model.DB_ClinicEntities();

        private static Image Img_Size_For_TT;

        char Timer_For_TT_Flag = '0';
        private void GrdVw_Reception_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString(), "ROW");
            //MessageBox.Show(e.ColumnIndex.ToString(), "col");

            if (Flag_EditUsers == true && ((e.ColumnIndex == 10) || (e.ColumnIndex == 12)) /*&& Timer_For_TT_Flag == '0'*/)
            {
                //long x = 0;
                ///*If user Thread.sleep(); it will be work while mouse hover change because all of system is sleeping and cant reach mouse move
                //this is only for intrupt*/
                //while (x < 5000000000)
                //{
                //    x += 20;
                //}
                //Timer_For_TT_Flag = '1';
            }
            else
            {
                toolTip1.Hide(this);
            }


            if (/*Timer_For_TT_Flag == '1' &&*/ ((e.ColumnIndex == 10) || (e.ColumnIndex == 12))
               && (e.RowIndex != -1) && (Flag_EditUsers == true) &&
               (((int)(GrdVw_Reception.Rows[e.RowIndex].Cells["img_String"].Tag)) == 1))
            {
                Timer_For_TT_Flag = '0';
                int GetSqlID = (int)GrdVw_Reception.Rows[e.RowIndex].Cells["ID"].Value;
                var q = Obj_DB_Entire.Tbl_User.Find(GetSqlID).img;

                Img_Size_For_TT = System.Drawing.Image.FromStream(new System.IO.MemoryStream(q));

                //pictureBox1.Image = Img_Size_For_TT;

                toolTip1.OwnerDraw = true;
                toolTip1.IsBalloon = false;

                Img_Size_For_TT = ScaleImage(Img_Size_For_TT, 200, 300);
                var TT_P = GrdVw_Reception.PointToScreen(GrdVw_Reception.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
                Point relativePoint = this.PointToClient(Cursor.Position);
                toolTip1.Show("عکس", this, relativePoint.X, relativePoint.Y);


            }
            else if ((/*(Timer_For_TT_Flag == '1') &&*/
            (Flag_EditUsers == true) &&
                (e.RowIndex != -1) &&
                ((e.ColumnIndex == 10) || (e.ColumnIndex == 12)) &&
                (((int)(GrdVw_Reception.Rows[e.RowIndex].Cells["img_String"].Tag)) == 0)
                 ))

            {
                Timer_For_TT_Flag = '0';
                Img_Size_For_TT = null;
                toolTip1.IsBalloon = true;
                toolTip1.AutoPopDelay = 10;
                //var cellRectangle = GrdVw_Reception.GetCellDisplayRectangle(e.ColumnIndex , e.RowIndex , true);
                Point relativePoint = this.PointToClient(Cursor.Position);
                toolTip1.Show("عکسی برای این کاربر ثبت نشده", this, relativePoint.X, relativePoint.Y);
            }
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        private void radApplicationMenu1_MouseHover(object sender, EventArgs e)
        {
            //radApplicationMenu1_Click(null, null);
            radApplicationMenu1.ShowDropDown();
        }

        private void Menu_Edit_Click(object sender, EventArgs e)
        {

        }

        private void PB_Menu_Dynamic_MouseEnter(object sender, EventArgs e)
        {
            radApplicationMenu1_MouseHover(null, null);
        }

        private void PB_Menu_Static_MouseHover(object sender, EventArgs e)
        {
            radApplicationMenu1.DropDownButtonElement.ShowDropDown();

            PB_Menu_Static.Visible = false;
            PB_Menu_Dynamic.Image = Properties.Resources.Menu_Open_Dynamic;
            PB_Menu_Dynamic.Visible = true;
            timer_OpenMenu.Enabled = true;
            timer_OpenMenu.Start();
        }

        private void timer_CloseMenu_Tick(object sender, EventArgs e)
        {
            PB_Menu_Static.Image = Properties.Resources.Menu_11;
            PB_Menu_Dynamic.Visible = false;
            PB_Menu_Static.Visible = true;
            timer_CloseMenu.Stop();
        }

        private void timer_OpenMenu_Tick(object sender, EventArgs e)
        {
            PB_Menu_Static.Image = Properties.Resources.Menu_21;
            PB_Menu_Dynamic.Visible = false;
            PB_Menu_Static.Visible = true;
            timer_OpenMenu.Enabled = false;
            timer_OpenMenu.Stop();
        }

        private void PB_Menu_Static_MouseEnter(object sender, EventArgs e)
        {
            radApplicationMenu1.DropDownButtonElement.ShowDropDown();
            //radApplicationMenu1_Click(null, null);
            PB_Menu_Static.Visible = false;
            PB_Menu_Dynamic.Image = Properties.Resources.Menu_Open_Dynamic;
            PB_Menu_Dynamic.Visible = true;
            timer_OpenMenu.Enabled = true;
            timer_OpenMenu.Start();
        }

        private void PB_Menu_Dynamic_MouseEnter_1(object sender, EventArgs e)
        {
            //radApplicationMenu1_MouseHover(null, null);
        }

        private void radApplicationMenu1_DropDownClosed(object sender, EventArgs e)
        {
            PB_Menu_Static.Visible = false;
            PB_Menu_Dynamic.Image = Properties.Resources.Menu_Close_Dynamic1;
            PB_Menu_Dynamic.Visible = true;

            timer_CloseMenu.Start();
        }

        private void Menu_SubShowSearchingForm_Click(object sender, EventArgs e)
        {
            Btn_Add_To_DB.Visible = false;
            Btn_Search.Text = "جست و جو و ویرایش\n\tجدول های بالا";
            Btn_Search_Click(null, null);
            Trans_Class.Flag_Back_from_srchingfrm = true;
            Form_Settings_Load(null, null);
            Btn_Search.Visible = true;
        }

        private void GrdVw_Reception_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            toolTip1.Hide(this);
        }

        private void radApplicationMenu1_Click(object sender, EventArgs e)
        {
            Btn_Add_To_DB.Visible = false;

            if (radApplicationMenu1.DropDownButtonElement.DropDownMenu.Visible)
            {
                radApplicationMenu1.DropDownButtonElement.HideDropDown();

            }
            else
            {
                radApplicationMenu1.DropDownButtonElement.ShowDropDown();
                PB_Menu_Static_MouseEnter(null, null);
            }
        }

        private void PB_Menu_Static_Click(object sender, EventArgs e)
        {
            radApplicationMenu1_Click(null, null);
        }

        private void radMenuItem_Download_From_Excel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Add_To_DB_Click(object sender, EventArgs e)
        {
            if (flag_Add_To_Recep == true)
            {
                for (int i = 0; i < Data_Set.Rows.Count; i++)
                {
                    Model.DB_ClinicEntities Obj_All = new Model.DB_ClinicEntities();
                    Model.Tbl_Reception Obj_rec = new Model.Tbl_Reception();
                    Model.Tbl_Patient Obj_Pat = new Model.Tbl_Patient();
                    Model.Tbl_Doctor Obj_Doc = new Model.Tbl_Doctor();

                    Obj_Pat.name = Data_Set.Rows[i].ItemArray.GetValue(0).ToString();
                    Obj_Pat.mobile = Data_Set.Rows[i].ItemArray.GetValue(1).ToString();
                    Obj_Pat.Ncode = null;
                    Obj_Pat.adrs = null;
                    Obj_All.Tbl_Patient.Add(Obj_Pat);

                    Obj_Doc.adrs = null;
                    Obj_Doc.MedicalCode = null;
                    Obj_Doc.Mobile = null;
                    Obj_Doc.name_dr = Data_Set.Rows[i].ItemArray.GetValue(4).ToString(); ;
                    Obj_Doc.Ncode = null;
                    Obj_Doc.Skill = null;

                    Obj_rec.DocID = 0;
                    Obj_rec.PatID = 0;
                    Obj_rec.SecID = 0;
                    Obj_rec.ServID = 0;
                    Obj_rec.VisitTime = Data_Set.Rows[i].ItemArray.GetValue(5).ToString();
                    Obj_rec.VisitDate = Data_Set.Rows[i].ItemArray.GetValue(6).ToString();
                    Obj_All.Tbl_Reception.Add(Obj_rec);
                    Obj_All.SaveChanges();

                }
            }
            else if (flag_Add_To_Pat == true)
            {
                for (int i = 0; i < Data_Set.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(Data_Set.Rows[i].ItemArray.GetValue(0).ToString()) &&
                        string.IsNullOrEmpty(Data_Set.Rows[i].ItemArray.GetValue(1).ToString()) &&
                        string.IsNullOrEmpty(Data_Set.Rows[i].ItemArray.GetValue(2).ToString())&&
                        string.IsNullOrEmpty(Data_Set.Rows[i].ItemArray.GetValue(3).ToString()))
                    {
                        Data_Set.Rows.RemoveAt(i);
                    }
                    else
                    {
                        Model.DB_ClinicEntities Obj_All = new Model.DB_ClinicEntities();
                        Model.Tbl_Patient Obj_Pat = new Model.Tbl_Patient();

                        Obj_Pat.name = Data_Set.Rows[i].ItemArray.GetValue(0).ToString();
                        Obj_Pat.adrs = Data_Set.Rows[i].ItemArray.GetValue(1).ToString();
                        Obj_Pat.mobile = Data_Set.Rows[i].ItemArray.GetValue(2).ToString();
                        Obj_Pat.Ncode = Data_Set.Rows[i].ItemArray.GetValue(3).ToString();
                        Obj_Pat.CountOfPictures = Convert.ToInt16(Data_Set.Rows[i].ItemArray.GetValue(4));

                        Obj_All.Tbl_Patient.Add(Obj_Pat);
                        Obj_All.SaveChanges();
                    }
                }

                MetroMessageBox.Show(this, "لیست بیماران از اکسل با موفقیت به پایگاه داده افزوذه شد.", "Successfull !!!", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            }
            else if (flag_Add_To_Dr==true)
            {
                for (int i = 0; i < Data_Set.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(Data_Set.Rows[i].ItemArray.GetValue(0).ToString()) &&
                        string.IsNullOrEmpty(Data_Set.Rows[i].ItemArray.GetValue(1).ToString()) &&
                        string.IsNullOrEmpty(Data_Set.Rows[i].ItemArray.GetValue(2).ToString()) &&
                        string.IsNullOrEmpty(Data_Set.Rows[i].ItemArray.GetValue(3).ToString()))
                    {
                        Data_Set.Rows.RemoveAt(i);
                    }
                    else
                    {
                        Model.DB_ClinicEntities Obj_All = new Model.DB_ClinicEntities();
                        Model.Tbl_Doctor Obj_Dr = new Model.Tbl_Doctor();

                        Obj_Dr.name_dr = Data_Set.Rows[i].ItemArray.GetValue(0).ToString();
                        Obj_Dr.Skill = Data_Set.Rows[i].ItemArray.GetValue(1).ToString();
                        Obj_Dr.MedicalCode = Data_Set.Rows[i].ItemArray.GetValue(2).ToString();
                        Obj_Dr.Ncode = Data_Set.Rows[i].ItemArray.GetValue(3).ToString();
                        Obj_Dr.Mobile = Data_Set.Rows[i].ItemArray.GetValue(4).ToString();
                        Obj_Dr.adrs = Data_Set.Rows[i].ItemArray.GetValue(5).ToString();

                        Obj_All.Tbl_Doctor.Add(Obj_Dr);
                        Obj_All.SaveChanges();
                    }
                }
                MetroMessageBox.Show(this, "لیست دکتر ها از اکسل با موفقیت به پایگاه داده افزوذه شد.", "Successfull !!!", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            }
        }

        DataTable Data_Set = new DataTable();

        bool flag_Add_To_Recep = false;
        bool flag_Add_To_Dr = false;
        bool flag_Add_To_Pat = false;
        
        private void radMenuItemSub_Add_To_Recep_Click(object sender, EventArgs e)
        {
            flag_Add_To_Recep = true;
            flag_Add_To_Dr = false;
            flag_Add_To_Pat = false;

            Btn_Add_To_DB.Visible = true;

            GrdVw_Drs.Visible = false;
            GrdVw_Pats.Visible = false;
            GrdVw_Sec.Visible = false;
            GrdVw_Ser.Visible = false;
            GrdVw_Reception.Visible = true;
            Btn_Search.Visible = false;
            Btn_Shw_Othr.Visible = false;
            Btn_ShwReception.Visible = false;
            Btn_DelRecord.Visible = false;
            Btn_Edit.Visible = false;
            Btn_Save.Visible = false;

            openFileDialog1.FileName = "Upload From Excel To DB";
            openFileDialog1.Filter = "Excel Documents|*.xlsx";

            openFileDialog1.ShowDialog();

            string Adrs = openFileDialog1.FileName;

            Excel.Application XlApp = new Excel.Application();  // object of App

            Excel.Workbook xlworkbook = XlApp.Workbooks.Open(Adrs);

            Excel._Worksheet xlworksheet = xlworkbook.Sheets[1];

            Excel.Range xlRange = xlworksheet.UsedRange; // data scope of sheet

            Data_Set.Columns.Clear();
            
            Data_Set.Columns.Add("نام بیمار", typeof(string));
            Data_Set.Columns.Add("شماره همراه", typeof(string));
            Data_Set.Columns.Add("سرویس مربوطه", typeof(string));
            Data_Set.Columns.Add("بخش مربوطه", typeof(string));
            Data_Set.Columns.Add("نام دکتر مربوطه", typeof(string));
            Data_Set.Columns.Add("ساعت نوبت", typeof(string));
            Data_Set.Columns.Add("تاریخ نوبت", typeof(string));

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;


            for (int i = 1; i <= rowCount; i++)
            {
                Data_Set.Rows.Add(Data_Set.NewRow());
                for (int j = 1; j <= colCount; j++)
                {

                    string s = Convert.ToString(xlRange.Cells[i + 1, j].value2);
                    Data_Set.Rows[i - 1][j - 1] = s;
                }
            }

            xlworkbook.Close();
            GrdVw_Reception.DataSource = Data_Set;
            GrdVw_Reception.Refresh();
            
            MessageBox.Show(Data_Set.Rows[1].ItemArray.GetValue(4).ToString());
            MessageBox.Show(Data_Set.Rows[1].ItemArray.GetValue(5).ToString());
        }

        private void radMenuItem_Sub_Add_To_Patient_Click(object sender, EventArgs e)
        {
            flag_Add_To_Recep = false;
            flag_Add_To_Dr = false;
            flag_Add_To_Pat = true;

            Btn_Add_To_DB.Visible = true;

            GrdVw_Drs.Visible = false;
            GrdVw_Pats.Visible = false;
            GrdVw_Sec.Visible = false;
            GrdVw_Ser.Visible = false;
            GrdVw_Reception.Visible = true;
            Btn_Search.Visible = false;
            Btn_Shw_Othr.Visible = false;
            Btn_ShwReception.Visible = false;
            Btn_DelRecord.Visible = false;
            Btn_Edit.Visible = false;
            Btn_Save.Visible = false;

            openFileDialog1.FileName = "Upload From Excel To DB";
            openFileDialog1.Filter = "Excel Documents|*.xlsx";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string Adrs = openFileDialog1.FileName;

            Excel.Application XlApp = new Excel.Application();  // object of App

            Excel.Workbook xlworkbook = XlApp.Workbooks.Open(Adrs);

            Excel._Worksheet xlworksheet = xlworkbook.Sheets[1];

            Excel.Range xlRange = xlworksheet.UsedRange; // data scope of sheet

            Data_Set.Columns.Clear();

            Data_Set.Columns.Add("نام بیمار", typeof(string));
            Data_Set.Columns.Add("آدرس", typeof(string));
            Data_Set.Columns.Add("شماره تماس", typeof(string));
            Data_Set.Columns.Add("کدملی", typeof(string));
            Data_Set.Columns.Add("عکس", typeof(string));

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;


            for (int i = 1; i <= rowCount; i++)
            {
                Data_Set.Rows.Add(Data_Set.NewRow());
                for (int j = 1; j <= colCount; j++)
                {

                    string s = Convert.ToString(xlRange.Cells[i + 1, j].value2);
                    Data_Set.Rows[i - 1][j - 1] = s;
                }
            }

            xlworkbook.Close();
            GrdVw_Reception.DataSource = Data_Set;
            GrdVw_Reception.Refresh();
            }
            else
            {
                MetroMessageBox.Show(this, "فایل اکسل را به درستی انتخاب کنید.", "UnSuccessfull !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                Btn_Add_To_DB.Visible = false;
            }
        }

        private void radMenuItem_Sub_Add_To_Doctors_Click(object sender, EventArgs e)
        {
            
            flag_Add_To_Recep = false;
            flag_Add_To_Dr = true;
            flag_Add_To_Pat = false;

            Btn_Add_To_DB.Visible = true;

            GrdVw_Drs.Visible = false;
            GrdVw_Pats.Visible = false;
            GrdVw_Sec.Visible = false;
            GrdVw_Ser.Visible = false;
            GrdVw_Reception.Visible = true;
            Btn_Search.Visible = false;
            Btn_Shw_Othr.Visible = false;
            Btn_ShwReception.Visible = false;
            Btn_DelRecord.Visible = false;
            Btn_Edit.Visible = false;
            Btn_Save.Visible = false;

            openFileDialog1.FileName = "Upload From Excel To DB";
            openFileDialog1.Filter = "Excel Documents|*.xlsx";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Adrs = openFileDialog1.FileName;

                Excel.Application XlApp = new Excel.Application();  // object of App

                Excel.Workbook xlworkbook = XlApp.Workbooks.Open(Adrs);

                Excel._Worksheet xlworksheet = xlworkbook.Sheets[1];

                Excel.Range xlRange = xlworksheet.UsedRange; // data scope of sheet

                Data_Set.Columns.Clear();

                Data_Set.Columns.Add("نام", typeof(string));
                Data_Set.Columns.Add("تخصص", typeof(string));
                Data_Set.Columns.Add("کد نظام پزشکی", typeof(string));
                Data_Set.Columns.Add("کدملی", typeof(string));
                Data_Set.Columns.Add("شماره همراه", typeof(string));
                Data_Set.Columns.Add("آدرس", typeof(string));


                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;


                for (int i = 1; i <= rowCount; i++)
                {
                    Data_Set.Rows.Add(Data_Set.NewRow());
                    for (int j = 1; j <= colCount; j++)
                    {

                        string s = Convert.ToString(xlRange.Cells[i + 1, j].value2);
                        Data_Set.Rows[i - 1][j - 1] = s;
                    }
                }

                xlworkbook.Close();
                GrdVw_Reception.DataSource = Data_Set;
                GrdVw_Reception.Refresh();
            }
            else
            {
                MetroMessageBox.Show(this, "فایل اکسل را به درستی انتخاب کنید.", "UnSuccessfull !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                Btn_Add_To_DB.Visible = false;
            }
            
        }

        private void radMenuItem_Sub_Upload_Pat_From_DB_To_Excel_Click(object sender, EventArgs e)
        {
            //Excel.Application XlApp = new Excel.Application();
            //Excel.Workbook excelWorkbook = XlApp.Workbooks.Add(Excel.XlSheetType.xlWorksheet);

            ////  Excel.Worksheet xlworksheet = (Excel.Worksheet)(excelWorkbook.Worksheets[1]);

            ////  xlworksheet.DisplayRightToLeft = true;
            ////------------------------------------------------------------
            
            
            //var a = DS1.Tbl_Patient;
            //tableAdapterManager1.Tbl_PatientTableAdapter.Fill(dataSet11.Tbl_Patient);

            //DataTable table = a;

            //Excel.Worksheet excelworksheet = excelWorkbook.Sheets.Add();
            //excelworksheet.Name = table.TableName;

            //for (int i = 1; i < table.Columns.Count + 1; i++)
            //{
            //    excelworksheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
            //}



            //for (int j = 0; j < table.Rows.Count; j++)
            //{
            //    for (int k = 0; k < table.Columns.Count; k++)
            //    {
            //        excelworksheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
            //    }
            //}


            //try
            //{
            //    excelWorkbook.SaveAs("D:\\Shokri2.xlsx");
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("error file creation");
            //}

            //excelWorkbook.Close();
            //XlApp.Quit();
        }
    }
}




