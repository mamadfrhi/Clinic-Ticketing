using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Threading;

namespace Clinic_App
{
    using MetroFramework;
    public partial class Form_Searching : MetroFramework.Forms.MetroForm
    {
        public Form_Searching()
        {
            InitializeComponent();
        }

        private void Btn_BackToSettings_Click(object sender, EventArgs e)
        {
            Form_PopDown();
        }
        Model.DB_ClinicEntities Obj_ClinicDB = new Model.DB_ClinicEntities();

        int StartX;
        int StartY;

        private void Form_PopUp()
        {
            StartX = (Screen.PrimaryScreen.WorkingArea.X) - (this.Width);
            StartY = (Screen.PrimaryScreen.WorkingArea.Y) - (this.Height);

            SetDesktopLocation(StartX, StartY);
            timer1.Enabled = true;
            timer1.Start();
        }
        private void Form_PopDown()
        {
            ///////////////////////////////////////Find Middle of Screeeeeeeeeeeeeeeeeeeeeeeeeeeeen///////////////////////////////////////

            StartX = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) - ((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2);
            StartY = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) - ((Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            SetDesktopLocation(StartX, StartY);
            timer_Out.Enabled = true;
            timer_Out.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) - ((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2);

            if (StartX <= a)
            {
                StartX += 11;
                StartY += 8;
            }
            else
            {
                timer1.Stop();
            }
            SetDesktopLocation(StartX, StartY);
        }

        private void timer_Out_Tick(object sender, EventArgs e)
        {
            int a = (Screen.PrimaryScreen.WorkingArea.Width + this.Width);

            if (StartX < (a - 10))
            {
                StartX += 10;
                StartY -= 7;
            }
            else
            {
                timer1.Stop();
                this.Close();
            }
            SetDesktopLocation(StartX, StartY);
        }
        private void Form_Searching_Load(object sender, EventArgs e)
        {
            Form_PopUp();
            //GrdVw_Searching.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.AllCells;
            //GrdVw_Searching.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            CmbBx_Searching_Section.Items.Add("بخش مورد نظر را انتخاب کنید.");
            CmbBx_Searching_Section.Items.Add("جست و جو در لیست بیماران"); //1
            CmbBx_Searching_Section.Items.Add("جست و جو در لیست دکتر ها"); //2
            CmbBx_Searching_Section.Items.Add("جست و جو در لیست بخش های کلینیک");//3
            //CmbBx_Searching_Section.Items.Add("جست و جو در لیست سرویس های کلینیک");//3

            CmbBx_Searching_Section.SelectedIndex = 0;

            GpBox_Searching.Width = 206;
            GpBox_Searching.Height = 61;

            GrdVw_Searching.DefaultCellStyle.Font = new Font("Vazir", 9, FontStyle.Bold);
            GrdVw_Searching.ColumnHeadersDefaultCellStyle.Font = new Font("Vazir", 12, FontStyle.Bold);
            GrdVw_Searching.ColumnHeadersHeight = 45;
            //MessageBox.Show()
            GrdVw_Searching.ForeColor = Color.Black;

            DataGridViewCheckBoxColumn checkColumnSearching = new DataGridViewCheckBoxColumn();

            checkColumnSearching.Name = "checkColumnSearching";
            checkColumnSearching.DataPropertyName = "checkColumnSearching";
            checkColumnSearching.HeaderText = "انتخاب";
            checkColumnSearching.Width = 100;
            checkColumnSearching.ReadOnly = false;
            checkColumnSearching.FillWeight = 800;
            GrdVw_Searching.Columns.Insert(0, checkColumnSearching);
            GrdVw_Searching.Columns[0].Visible = false;

            GrdVw_Searching.DefaultCellStyle.SelectionBackColor = Color.BlueViolet;
            GrdVw_Searching.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            GrdVw_Searching.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Searching.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            GrdVw_Searching.ColumnHeadersHeight = 60;
        }
        public void Set_Headers_Text()
        {
            Lbl_SelectedCount.Visible = false;
            Lbl_SelectedCount_Int.Visible = false;
            GrdVw_Searching.ColumnHeadersHeight = 50;

            GrdVw_Searching.ClearSelection();

            //if (CmbBx_SearchingModel.SelectedIndex >= 0)
            //{
                if (Trans_Class.Flag_Pat_Edit == true)
                {
                    GrdVw_Searching.Columns["Tbl_Reception"].Visible = false;
                    GrdVw_Searching.Columns["ID"].HeaderText = "ردیف";
                    GrdVw_Searching.Columns["name"].HeaderText = "نام بیمار";
                    GrdVw_Searching.Columns["adrs"].HeaderText = "آدرس";
                    GrdVw_Searching.Columns["mobile"].HeaderText = "شماره همراه";
                    GrdVw_Searching.Columns["Ncode"].HeaderText = "کد ملی";
                    GrdVw_Searching.Columns["checkColumnSearching"].Width = 40;
                    GrdVw_Searching.Columns["CountOfPictures"].HeaderText = "تعداد عکس";
                    GrdVw_Searching.Columns["Tbl_Pat_Images"].Visible = false;
                    Btn_EditImages.Visible = false;
                    GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                    GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
                }
                if (Trans_Class.Flag_Doc_Edit == true || Trans_Class.Flag_Doc_Add == true)
                {
                    GrdVw_Searching.Columns["Tbl_Reception"].Visible = false;
                    GrdVw_Searching.Columns["ID"].HeaderText = "ردیف";
                    GrdVw_Searching.Columns["name_dr"].HeaderText = "نام دکتر";
                    GrdVw_Searching.Columns["adrs"].HeaderText = "آدرس";
                    GrdVw_Searching.Columns["mobile"].HeaderText = "شماره همراه";
                    GrdVw_Searching.Columns["Ncode"].HeaderText = "کد ملی";
                    GrdVw_Searching.Columns["Medicalcode"].HeaderText = "کد نظام پزشکی";
                    GrdVw_Searching.Columns["Skill"].HeaderText = "تخصص";
                    GrdVw_Searching.Columns["Image_Dr"].Visible = false;
                    GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                    GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
                }
                if (Trans_Class.Flag_Edit_Sections == true || CmbBx_SearchingModel.Text == "جست و جو در بخش ها")
                {
                    GrdVw_Searching.Columns["Tbl_Reception"].Visible = false;
                    GrdVw_Searching.Columns["ID"].HeaderText = "ردیف";
                    GrdVw_Searching.Columns["SecTitle"].HeaderText = "عنوان بخش";
                    GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                    GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
                }
                if (Trans_Class.Flag_Edit_Services == true || CmbBx_SearchingModel.Text == "جست و جو در سرویس ها")
                {
                    //GrdVw_Searching.DataSource = "";
                    //GrdVw_Searching.DataSource = Obj_ClinicDB.Tbl_Service.ToList();
                    GrdVw_Searching.Columns["Tbl_Reception"].Visible = false;
                    GrdVw_Searching.Columns["ID"].HeaderText = "ردیف";
                    GrdVw_Searching.Columns["ServTitle"].HeaderText = "عنوان سرویس";
                    GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                    GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
                }
            //}

            GrdVw_Searching.Columns[0].Visible = true;
            GrdVw_Searching.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void CmbBx_Searching_Section_DropDown(object sender, EventArgs e)
        {
            CmbBx_Searching_Section.Items.Remove("بخش مورد نظر را انتخاب کنید.");
        }

        private void CmbBx_Searching_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_EditImages.Visible = false;
            if (CmbBx_Searching_Section.Text == "جست و جو در لیست بیماران")
            {
                Btn_EditImages.Visible = false;
                Btn_Add.Visible = false;
                CmbBx_SearchingModel.Items.Clear();
                CmbBx_SearchingModel.Visible = true;
                GpBox_Searching.Height = 101;

                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Doc_Edit = false;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Add_SeRR = false;
                Trans_Class.Flag_Add_SeCC = false;
                Trans_Class.Flag_Pat_Edit = true;

                GrdVw_Searching.DataSource = "";
                GrdVw_Searching.DataSource = Obj_ClinicDB.Tbl_Patient.ToList();
                //GrdVw_Searching.Columns["Image"].Visible = false;
                Set_Headers_Text();
                
                

                //CmbBx_Searching_Section.Items.Add("بخش مورد نظر را انتخاب کنید.");

                CmbBx_SearchingModel.Items.Insert(0, "عامل جست و جو را مشخص کنید.");
                CmbBx_SearchingModel.Items.Add("جست و جو بر اساس نام بیمار");
                CmbBx_SearchingModel.Items.Add("جست و جو بر اساس شماره همراه بیمار");
                CmbBx_SearchingModel.Items.Add("جست و جو بر اساس کد ملی بیمار");
                CmbBx_SearchingModel.Items.Add("جست و جو بر اساس آدرس بیمار");

                CmbBx_SearchingModel.SelectedIndex = 0;

                Btn_Edit.reset();
                Btn_Edit.ResetText();
                Btn_Edit.Width = 173;

                this.Btn_Edit.Text = "ویرایش اطلاعات\nبیمار انتخاب شده";
                Btn_Edit.Location = new Point(169, 522);

                Btn_EditImages.Visible = true;
                Btn_EditImages.Location = new Point(16, 522);

                

            }

            if (CmbBx_Searching_Section.Text == "جست و جو در لیست دکتر ها")
            {
                Btn_EditImages.Visible = false;

                Btn_Edit.reset();
                Btn_Edit.ResetText();
                Btn_Edit.Width = 168;
                this.Btn_Edit.Text = "ویرایش اطلاعات\nپزشک انتخاب شده";
                Btn_Edit.Location = new Point(14, 522);
                Btn_Add.Visible = true;

                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Add_SeRR = false;
                Trans_Class.Flag_Add_SeCC = false;
                Trans_Class.Flag_Pat_Edit = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Doc_Edit = true;

                CmbBx_SearchingModel.Items.Clear();
                CmbBx_SearchingModel.Visible = true;
                GpBox_Searching.Height = 101;

                CmbBx_SearchingModel.Items.Insert(0, "عامل جست و جو را مشخص کنید.");
                CmbBx_SearchingModel.Items.Add("جست و جو بر اساس نام پزشک");
                CmbBx_SearchingModel.Items.Add("جست و جو بر اساس کد ملی پزشک");
                CmbBx_SearchingModel.Items.Add("جست و جو بر اساس تخصص پزشک");

                CmbBx_SearchingModel.SelectedIndex = 0;

                GrdVw_Searching.DataSource = "";
                GrdVw_Searching.DataSource = Obj_ClinicDB.Tbl_Doctor.ToList();
                Set_Headers_Text();
            }
            if (CmbBx_Searching_Section.Text == "جست و جو در لیست بخش های کلینیک")
            {
                Btn_EditImages.Visible = false;

                Btn_Edit.reset();
                Btn_Edit.ResetText();
                Btn_Edit.Width = 168;
                this.Btn_Edit.Text = "ویرایش گزینه\nانتخاب شده";
                Btn_Edit.Location = new Point(13, 522);
                Btn_Add.Visible = true;

                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Add_SeRR = false;
                Trans_Class.Flag_Add_SeCC = false;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Doc_Edit = false;
                Trans_Class.Flag_Pat_Edit = false;
                

                CmbBx_SearchingModel.Items.Clear();
                CmbBx_SearchingModel.Visible = true;
                
                CmbBx_SearchingModel_DropDownClosed(null, null);

                CmbBx_SearchingModel.Items.Insert(0, "عامل جست و جو را مشخص کنید.");
                CmbBx_SearchingModel.Items.Add("جست و جو در بخش ها");
                CmbBx_SearchingModel.Items.Add("جست و جو در سرویس ها");
                //CmbBx_SearchingModel.Items.Add("جست و جو بر اساس تخصص پزشک");

                CmbBx_SearchingModel.SelectedIndex = 1;

                //GrdVw_Searching.DataSource = "";
                //GrdVw_Searching.DataSource = Obj_ClinicDB.Tbl_Section.ToList();
                //Set_Headers_Text();
            }


            Btn_DelRecord.Visible = false;
            Btn_Edit.Visible = false;
            Btn_EditImages.Visible = false;
        }

        private void CmbBx_SearchingModel_DropDown(object sender, EventArgs e)
        {
            CmbBx_SearchingModel.Items.Remove("عامل جست و جو را مشخص کنید.");
        }

        private void CmbBx_SearchingModel_SelectedIndexChanged(object sender, EventArgs e)
        {

            Btn_Edit.Visible = false;
            if (CmbBx_Searching_Section.Text == "جست و جو در لیست بخش های کلینیک")
            {
                GrdVw_Searching.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                if (CmbBx_SearchingModel.Text == "جست و جو در بخش ها")
                {
                    Trans_Class.Flag_Edit_Sections = true;
                    Trans_Class.Flag_Visit_Edit = false;
                    Trans_Class.Flag_Doc_Add = false;
                    Trans_Class.Flag_Edit_Services = false;
                    Trans_Class.Flag_Doc_Edit = false;
                    Trans_Class.Flag_Pat_Edit = false;
                    Trans_Class.Flag_Add_SeRR = false;
                    Trans_Class.Flag_Add_SeCC = false;

                    GrdVw_Searching.DataSource = "";
                    GrdVw_Searching.DataSource = Obj_ClinicDB.Tbl_Section.ToList();
                    Set_Headers_Text();
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "نام بخش را وارد کنید";
                    
                }
                if (CmbBx_SearchingModel.Text == "جست و جو در سرویس ها")
                {
                    Trans_Class.Flag_Edit_Sections = false;
                    Trans_Class.Flag_Visit_Edit = false;
                    Trans_Class.Flag_Doc_Add = false;
                    Trans_Class.Flag_Edit_Services = true;
                    Trans_Class.Flag_Doc_Edit = false;
                    Trans_Class.Flag_Pat_Edit = false;
                    Trans_Class.Flag_Add_SeRR = false;
                    Trans_Class.Flag_Add_SeCC = false;

                    GrdVw_Searching.DataSource = "";
                    GrdVw_Searching.DataSource = Obj_ClinicDB.Tbl_Service.ToList();
                    Set_Headers_Text();
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "نام سرویس را وارد کنید";
                }
            }
            if (CmbBx_Searching_Section.Text == "جست و جو در لیست بیماران")
            {

                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس نام بیمار")
                {
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "نام بیمار را وارد کنید";
                }


                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس شماره همراه بیمار")
                {
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "شماره همراه بیمار را وارد کنید";
                }


                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس کد ملی بیمار")
                {
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "کد ملی بیمار را وارد کنید";
                }


                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس آدرس بیمار")
                {
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "آدرس بیمار را وارد کنید";
                }
            }


            if (CmbBx_Searching_Section.Text == "جست و جو در لیست دکتر ها")
            {
                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس نام پزشک")
                {
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "نام پزشک را وارد کنید";
                }

                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس کد ملی پزشک")
                {
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "کد ملی پزشک را وارد کنید";
                }

                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس تخصص پزشک")
                {
                    TxtBx_SearchingValue.Visible = true;
                    TxtBx_SearchingValue.Text = "تخصص پزشک را وارد کنید";
                }
            }

        }

        private void TxtBx_ValueSearch_Enter(object sender, EventArgs e)
        {
            TxtBx_SearchingValue.Text = "";
            TxtBx_SearchingValue.ForeColor = SystemColors.WindowText;
        }

        private void TxtBx_ValueSearch_TextChanged(object sender, EventArgs e)
        {
            
                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس نام بیمار")
                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Patient.Where(w => w.name.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }

                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس شماره همراه بیمار")
                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Patient.Where(w => w.mobile.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = "";
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }
                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس کد ملی بیمار")

                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Patient.Where(w => w.Ncode.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = "";
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }

                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس آدرس بیمار")

                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Patient.Where(w => w.adrs.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = "";
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }
            


            /////////////////////////////////////-------------------------------------------------------------

            if (/*TxtBx_SearchingValue.Text != "" &&*/ CmbBx_Searching_Section.Text == "جست و جو در لیست دکتر ها")
            {
                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس نام پزشک")
                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Doctor.Where(w => w.name_dr.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = "";
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }

                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس کد ملی پزشک")
                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Doctor.Where(w => w.Ncode.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = "";
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }

                if (CmbBx_SearchingModel.Text == "جست و جو بر اساس تخصص پزشک")
                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Doctor.Where(w => w.Skill.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = "";
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }


            }

            /////////////////////////////////////-------------------------------------------------------------

            if (/*TxtBx_SearchingValue.Text != "" &&*/ CmbBx_Searching_Section.Text == "جست و جو در لیست بخش های کلینیک")
            {
                if (CmbBx_SearchingModel.Text == "جست و جو در بخش ها")
                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Section.Where(w => w.SecTitle.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = "";
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }
                if (CmbBx_SearchingModel.Text == "جست و جو در سرویس ها")
                {
                    var SearchingSqlQuery = Obj_ClinicDB.Tbl_Service.Where(w => w.ServTitle.Contains(TxtBx_SearchingValue.Text)).ToList();
                    if (SearchingSqlQuery.Count > 0)
                    {
                        GrdVw_Searching.DataSource = "";
                        GrdVw_Searching.DataSource = SearchingSqlQuery.ToList();
                    }
                }
            }
            Set_Headers_Text();
        }

        private void GrdVw_Searching_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = false;
            Btn_Refresh.Visible = true;
            Btn_Edit.Visible = false;
        }

        private void CmbBx_SearchingModel_DropDownClosed(object sender, EventArgs e)
        {
            GpBox_Searching.Size = new Size(206, 155);
        }

        private void Btn_Refresh_Ar()
        {
            if (Trans_Class.Flag_Visit_Edit == true)
            {
                

                Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
                GrdVw_Searching.DataSource = "";
                GrdVw_Searching.DataSource = DB_Obj.Vw_Reception.ToList();

                GrdVw_Searching.ClearSelection();
                GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
            }
            if (Trans_Class.Flag_Pat_Edit == true)
            {
                Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
                GrdVw_Searching.DataSource = "";
                GrdVw_Searching.DataSource = DB_Obj.Tbl_Patient.ToList();
                Set_Headers_Text();

                GrdVw_Searching.ClearSelection();
                GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
            }

            if (Trans_Class.Flag_Doc_Edit == true)
            {
                Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
                GrdVw_Searching.DataSource = "";
                GrdVw_Searching.DataSource = DB_Obj.Tbl_Doctor.ToList();
                Set_Headers_Text();

                GrdVw_Searching.ClearSelection();
                GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
            }
            if (Trans_Class.Flag_Edit_Sections == true || Trans_Class.Flag_Add_SeCC == true)
            {
                Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
                GrdVw_Searching.DataSource = "";
                GrdVw_Searching.DataSource = DB_Obj.Tbl_Section.ToList();
                Set_Headers_Text();

                GrdVw_Searching.ClearSelection();
                GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
            }
            if (Trans_Class.Flag_Edit_Services == true || Trans_Class.Flag_Add_SeRR == true)
            {
                Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
                GrdVw_Searching.DataSource = "";
                GrdVw_Searching.DataSource = DB_Obj.Tbl_Service.ToList();
                Set_Headers_Text();

                GrdVw_Searching.ClearSelection();
                GrdVw_Searching.FirstDisplayedScrollingRowIndex = GrdVw_Searching.RowCount - 1;
                GrdVw_Searching.Rows[GrdVw_Searching.RowCount - 1].Selected = true;
            }

            Btn_Edit.Visible = false;
            Btn_DelRecord.Visible = false;
        }

        private void Form_Searching_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trans_Class.Flag_Back_from_srchingfrm = true;
            Trans_Class.Flag_Visit_Edit = false;
            Trans_Class.Flag_Doc_Add = false;
            Trans_Class.Flag_Doc_Edit = false;
            Trans_Class.Flag_Edit_Services = false;
            Trans_Class.Flag_Edit_Sections = false;
            Trans_Class.Flag_Add_SeRR = false;
            Trans_Class.Flag_Add_SeCC = false;
            Trans_Class.Flag_Pat_Edit = false;
            GrdVw_Searching.DataSource = "";
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Btn_Refresh_Ar();
            Pat_ID = -1;
            if (TxtBx_SearchingValue.TextLength >= 0)
            {
                TxtBx_SearchingValue.Clear();
            }
        }
        List<DataGridViewRow> SelectedReceptionRows = new List<DataGridViewRow>();

        private void Btn_DelRecord_Click(object sender, EventArgs e)
        {
            if (Trans_Class.Flag_Pat_Edit == true)
            {
                if (MetroMessageBox.Show(this, "آیا برای حذف مطمعا هستید ؟", "پاک شوند ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    SelectedReceptionRows = (from Rows in GrdVw_Searching.Rows.Cast<DataGridViewRow>()
                                             where Convert.ToBoolean(Rows.Cells["checkColumnSearching"].Value) == true
                                             select Rows).ToList();

                    var GetSqlID = SelectedReceptionRows.Select(x => (int)x.Cells["ID"].Value).ToList();

                    var GetSqlRecord = Obj_ClinicDB.Tbl_Patient.Where(x => GetSqlID.Contains(x.ID));

                    //for (int i = 0; i < GetSqlID.Count; i++)
                    //{
                    //    Obj_ClinicDB.SP_Del_Recep_By_PatID(GetSqlID[i]);
                    //}
                    //for (int i = 0; i < GetSqlID.Count; i++)
                    //{
                    //    Obj_ClinicDB.SP_Del_PatImages(GetSqlID[i]);
                    //}
                    for (int i = 0; i < GetSqlID.Count; i++)
                    {
                        Obj_ClinicDB.SP_Del_One_OF_PatImage(GetSqlID[i]);
                    }
                    


                    foreach (var item in GetSqlRecord)
                    {
                        Obj_ClinicDB.Tbl_Patient.Remove(item);
                    }

                    


                }
            }
            if (Trans_Class.Flag_Doc_Edit == true)
            {

                if (MetroMessageBox.Show(this, "آیا برای حذف مطمعا هستید ؟", "پاک شوند ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    SelectedReceptionRows = (from Rows in GrdVw_Searching.Rows.Cast<DataGridViewRow>()
                                             where Convert.ToBoolean(Rows.Cells["checkColumnSearching"].Value) == true
                                             select Rows).ToList();

                    var GetSqlID = SelectedReceptionRows.Select(x => (int)x.Cells["ID"].Value).ToList();

                    var GetSqlRecord = Obj_ClinicDB.Tbl_Doctor.Where(x => GetSqlID.Contains(x.ID));

                    foreach (var item in GetSqlRecord)
                    {
                        Obj_ClinicDB.Tbl_Doctor.Remove(item);
                    }


                }
            }

            if (Trans_Class.Flag_Edit_Services == true || Trans_Class.Flag_Add_SeRR == true)
            {
                if (MetroMessageBox.Show(this, "آیا برای حذف مطمعا هستید ؟", "پاک شوند ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    SelectedReceptionRows = (from Rows in GrdVw_Searching.Rows.Cast<DataGridViewRow>()
                                             where Convert.ToBoolean(Rows.Cells["checkColumnSearching"].Value) == true
                                             select Rows).ToList();

                    var GetSqlID = SelectedReceptionRows.Select(x => (int)x.Cells["ID"].Value).ToList();

                    var GetSqlRecord = Obj_ClinicDB.Tbl_Service.Where(x => GetSqlID.Contains(x.ID));

                    foreach (var item in GetSqlRecord)
                    {
                        Obj_ClinicDB.Tbl_Service.Remove(item);
                    }


                }
            }

            if (Trans_Class.Flag_Edit_Sections == true || Trans_Class.Flag_Add_SeCC == true)
            {
                if (MetroMessageBox.Show(this, "آیا برای حذف مطمعا هستید ؟", "پاک شوند ؟", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    SelectedReceptionRows = (from Rows in GrdVw_Searching.Rows.Cast<DataGridViewRow>()
                                             where Convert.ToBoolean(Rows.Cells["checkColumnSearching"].Value) == true
                                             select Rows).ToList();

                    var GetSqlID = SelectedReceptionRows.Select(x => (int)x.Cells["ID"].Value).ToList();

                    var GetSqlRecord = Obj_ClinicDB.Tbl_Section.Where(x => GetSqlID.Contains(x.ID));

                    foreach (var item in GetSqlRecord)
                    {
                        Obj_ClinicDB.Tbl_Section.Remove(item);
                    }
                }
            }

            Obj_ClinicDB.SaveChanges();
            SelectedReceptionRows.Clear();

            Btn_Refresh_Ar();

            Btn_DelRecord.Visible = false;
            Btn_Edit.Visible = false;
            Btn_DelRecord.Activecolor = Btn_DelRecord.BackColor;
            Set_Headers_Text();
        }

        int Pat_ID = -1;
        int Doc_ID = -1;
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Btn_Edit.Text == "ویرایش اطلاعات\nبیمار انتخاب شده")
            {
                //for (int i = 0; i < GrdVw_Searching.Rows.Count; i++)
                //{
                //    if (Convert.ToBoolean(GrdVw_Searching.Rows[i].Cells["checkColumnSearching"].Value) == true)
                //    {
                //        Pat_ID = (int)GrdVw_Searching.Rows[i].Cells["ID"].Value;
                //        Trans_Class.ID_Pat_Trans = Pat_ID;
                //    }
                //}



                Trans_Class.Flag_Pat_Edit = true;
                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Doc_Edit = false;
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Add_SeCC = false;
                Trans_Class.Flag_Add_SeRR = false;

                this.Opacity = 0.75;

                Form_Edit1 FrmEdit = new Form_Edit1();
                FrmEdit.ShowDialog();
                this.Opacity = 1;
                Btn_Refresh_Ar();
                GrdVw_Searching.ClearSelection();

            }

            if (Btn_Edit.Text == "ویرایش اطلاعات\nپزشک انتخاب شده")
            {

                for (int i = 0; i < GrdVw_Searching.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(GrdVw_Searching.Rows[i].Cells["checkColumnSearching"].Value) == true)
                    {
                        Doc_ID = (int)GrdVw_Searching.Rows[i].Cells["ID"].Value;
                        Trans_Class.ID_Dr_Trans = Doc_ID;
                    }
                }



                Trans_Class.Flag_Pat_Edit = false;
                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Doc_Edit = true;
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Add_SeCC = false;
                Trans_Class.Flag_Add_SeRR = false;

                this.Opacity = 0.75;

                Form_Edit1 FrmEdit = new Form_Edit1();
                FrmEdit.ShowDialog();
                this.Opacity = 1;
                Btn_Refresh_Ar();
                GrdVw_Searching.ClearSelection();
            }

            if (CmbBx_SearchingModel.Text == "جست و جو در سرویس ها")
            {
                for (int i = 0; i < GrdVw_Searching.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(GrdVw_Searching.Rows[i].Cells["checkColumnSearching"].Value) == true)
                    {
                        Trans_Class.ID_SecSer_Trans = (int)GrdVw_Searching.Rows[i].Cells["ID"].Value;

                    }
                }
                Trans_Class.Flag_Edit_Services = true;
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Pat_Edit = false;
                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Doc_Edit = false;
                Trans_Class.Flag_Add_SeCC = false;
                Trans_Class.Flag_Add_SeRR = false;

                this.Opacity = 0.75;

                Form_Edit1 FrmEdit = new Form_Edit1();
                FrmEdit.ShowDialog();
                this.Opacity = 1;
                Btn_Refresh_Ar();
                GrdVw_Searching.ClearSelection();
            }

            if (CmbBx_SearchingModel.Text == "جست و جو در بخش ها")
            {
                for (int i = 0; i < GrdVw_Searching.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(GrdVw_Searching.Rows[i].Cells["checkColumnSearching"].Value) == true)
                    {
                        Trans_Class.ID_SecSer_Trans = (int)GrdVw_Searching.Rows[i].Cells["ID"].Value;

                    }
                }
                Trans_Class.Flag_Edit_Sections = true;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Pat_Edit = false;
                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Doc_Edit = false;
                Trans_Class.Flag_Add_SeCC = false;
                Trans_Class.Flag_Add_SeRR = false;

                this.Opacity = 0.75;

                Form_Edit1 FrmEdit = new Form_Edit1();
                FrmEdit.ShowDialog();
                this.Opacity = 1;
                Btn_Refresh_Ar();
                GrdVw_Searching.ClearSelection();
            }

            GrdVw_Searching.FirstDisplayedScrollingRowIndex = Rec_GridView_Selected_Index;
            GrdVw_Searching.Rows[Rec_GridView_Selected_Index].Selected = true;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (CmbBx_Searching_Section.Text == "جست و جو در لیست دکتر ها")
            {
                Trans_Class.Flag_Pat_Edit = false;
                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Doc_Edit = true;
                Trans_Class.Flag_Doc_Add = true;
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Add_SeRR = false;
                Trans_Class.Flag_Add_SeCC = false;

            }
            if (CmbBx_SearchingModel.Text == "جست و جو در بخش ها")
            {
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Doc_Edit = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Pat_Edit = false;
                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Add_SeRR = false;
                Trans_Class.Flag_Add_SeCC = true;
            }
            if (CmbBx_SearchingModel.Text == "جست و جو در سرویس ها")
            {
                Trans_Class.Flag_Visit_Edit = false;
                Trans_Class.Flag_Edit_Sections = false;
                Trans_Class.Flag_Doc_Edit = false;
                Trans_Class.Flag_Doc_Add = false;
                Trans_Class.Flag_Pat_Edit = false;
                Trans_Class.Flag_Edit_Services = false;
                Trans_Class.Flag_Add_SeRR = true;
                Trans_Class.Flag_Add_SeCC = false;
            }


            this.Opacity = 0.75;

            Form_Edit1 FrmEdit = new Form_Edit1();
            FrmEdit.ShowDialog();
            this.Opacity = 1;
            Btn_Refresh_Ar();
            GrdVw_Searching.ClearSelection();

            int Last_Row = GrdVw_Searching.Rows.Count - 1;
            GrdVw_Searching.FirstDisplayedScrollingRowIndex = Last_Row;
            GrdVw_Searching.Rows[Last_Row].Selected = true;

        }

        private void GrdVw_Searching_Change_CheckBox_Value()
        {
            //int Row_Index = GrdVw_Searching.CurrentCellAddress.Y;
            //if (Convert.ToBoolean(GrdVw_Searching.Rows[Row_Index].Cells[0].Value))
            //{
            //    GrdVw_Searching.Rows[Row_Index].Cells[0].Value = false;
            //}
            //else
            //{
            //    GrdVw_Searching.Rows[Row_Index].Cells[0].Value = true;
            //}
            //GrdVw_Searching_CellContentClick(null, null);
            //Timer_SelectCheckBox.Stop();
        }

        private void GrdVw_Searching_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Timer_SelectCheckBox.Interval = 500;
            //Timer_SelectCheckBox.Enabled = true;
            //Timer_SelectCheckBox.Start();
        }

        ToolTip tt = new ToolTip();

        private void Timer_SelectCheckBox_Tick(object sender, EventArgs e)
        {
            //    //float counter = 0;
            //    //counter++;
            //    //IWin32Window win = this;
            //    //tt.Show(counter.ToString(), win, MousePosition);

            //    //GrdVw_Searching_Change_CheckBox_Value();

            //    int Row_Index = GrdVw_Searching.CurrentCellAddress.Y;

            //    if (Convert.ToBoolean(GrdVw_Searching.Rows[Row_Index].Cells[0].Value) == false)
            //    {
            //        GrdVw_Searching.Rows[Row_Index].Cells[0].Value = CheckState.Checked;
            //    }
            //    else
            //    {
            //        GrdVw_Searching.Rows[Row_Index].Cells[0].Value = CheckState.Unchecked;
            //    }

            //    int UpTpOne = 0;

            //    bool flag = false;

            //    for (int i = 0; i < GrdVw_Searching.Rows.Count; i++)
            //    {
            //        if (Convert.ToBoolean(GrdVw_Searching.Rows[i].Cells["checkColumnSearching"].Value) == true)
            //        {
            //            UpTpOne++;

            //            if (UpTpOne == 1)
            //            {
            //                flag = true;
            //                GrdVw_Searching.Rows[i].Selected = true;
            //            }
            //            else
            //            {
            //                flag = false;
            //                GrdVw_Searching.Rows[Row_Index].Selected = true;
            //            }
            //        }
            //    }

            //    if (UpTpOne == 0)
            //    {
            //        Btn_DelRecord.Visible = false;

            //    }
            //    else
            //    {
            //        Btn_DelRecord.Visible = true;
            //    }

            //    if (flag == true)
            //    {
            //        Btn_Edit.Visible = true;
            //    }
            //    else
            //    {
            //        Btn_Edit.Visible = false;
            //    }
            //    Timer_SelectCheckBox.Stop();
        }

        private void GrdVw_Searching_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            Timer_SelectCheckBox.Stop();
        }

        private void GrdVw_Searching_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Timer_SelectCheckBox_Tick(null, null);
        }

        int Current_Selected_Row = -1;
        private void GrdVw_Searching_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(GrdVw_Searching.Rows[e.RowIndex].Cells[0].Value) == false && e.RowIndex != -1)
            {
                GrdVw_Searching.Rows[e.RowIndex].Cells[0].Value = CheckState.Checked;
            }
            else
            {
                GrdVw_Searching.Rows[e.RowIndex].Cells[0].Value = CheckState.Unchecked;
            }

            int UpTpOne = 0;

            Lbl_SelectedCount.Visible = true;
            Lbl_SelectedCount_Int.Visible = true;

            //int __1_selected = '\0';

            for (int i = 0; i < GrdVw_Searching.Rows.Count; i++)
            {
                if (Convert.ToBoolean(GrdVw_Searching.Rows[i].Cells[0].Value) == true)
                {
                    GrdVw_Searching.Rows[i].Selected = true;
                    Current_Selected_Row = i;
                    ++UpTpOne;
                }
                else
                {
                    GrdVw_Searching.Rows[i].Selected = false;
                }
                //if (UpTpOne == 1 && Convert.ToBoolean(GrdVw_Searching.Rows[i].Cells[0].Value) == true)

            }

            if (UpTpOne == 0)
            {
                Btn_DelRecord.Visible = false;
            }
            else
            {
                Btn_DelRecord.Visible = true;
            }

            if (UpTpOne == 1)
            {
                Btn_Edit.Visible = true;
                if (Trans_Class.Flag_Pat_Edit==true)
                    Btn_EditImages.Visible = true;

                Rec_GridView_Selected_Index = Current_Selected_Row;
                Trans_Class.ID_Pat_Trans = Convert.ToInt32(GrdVw_Searching.Rows[Current_Selected_Row].Cells["ID"].Value);
                //Current_Selected_Row = e.RowIndex;
            }
            else
            {
                Btn_Edit.Visible = false;
                Btn_EditImages.Visible = false;
            }
            Lbl_SelectedCount_Int.Text = UpTpOne.ToString();
        }

        int Rec_GridView_Selected_Index;

        private void Btn_EditImages_Click(object sender, EventArgs e)
        {
            var query = Obj_ClinicDB.SP_GetPatImages(Trans_Class.ID_Pat_Trans).ToList();

            if (query.Count > 0)
            {
                Form_EditImages.list_img.Clear();
                for (int i = 0; i < query.Count; i++)
                {
                    Form_EditImages.list_img.Add(System.Drawing.Image.FromStream(new System.IO.MemoryStream(query[i].Image)));
                }

                this.Opacity = 0.3;
                Form_EditImages Obj_Edit_Images_Form = new Form_EditImages(2);

                Trans_Class.NameAndFam = GrdVw_Searching.Rows[Current_Selected_Row].Cells["name"].Value.ToString();

                Obj_Edit_Images_Form.ShowDialog();
                this.Opacity = 1;
                Obj_ClinicDB.SP_Update_TblPatient_ColImgCoutn(Trans_Class.ID_Pat_Trans);

                GrdVw_Searching.Rows[Current_Selected_Row].Cells["CountOfPictures"].Value = Form_EditImages.list_img.Count;
            }
            else
            {
                MetroMessageBox.Show(this, "عکسی برای بیمار مورد نظر وارد نشده است", "Image Not Found!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}

