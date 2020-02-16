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
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net.Mail;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications; // Notifications library
using Microsoft.QueryStringDotNET; // QueryString.NET
using Windows.Data.Xml.Dom;
using System.Xml;
using System.Xml.Linq;

namespace Clinic_App
{
    using MetroFramework;
    using System.Data.SqlClient;
    using System.IO;
    using System.Xml;

    public partial class Form_Reception : MetroFramework.Forms.MetroForm
    {
        public Form_Reception()
        {
            InitializeComponent();
        }


        
        private void Form_Reception_Load(object sender, EventArgs e)
        {
            

            Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
            PB_Menu_Static.Image = Properties.Resources.Menu_11;

            GrdVw_Dr.ColumnHeadersDefaultCellStyle.Font = new Font("B Titr", 11);
            GrdVw_Dr.Font = new Font("Iranian Sans", 9, FontStyle.Regular);
            GrdVw_Dr.ForeColor = Color.Black;

            GrdVw_Pat.ColumnHeadersDefaultCellStyle.Font = new Font("B Titr", 10);
            GrdVw_Pat.Font = new Font("Iranian Sans", 9);
            GrdVw_Pat.ForeColor = Color.Black;

            GrdVw_Sec.ColumnHeadersDefaultCellStyle.Font = new Font("B Titr", 11);
            GrdVw_Sec.Font = new Font("Iranian Sans", 9, FontStyle.Regular);
            GrdVw_Sec.ForeColor = Color.Black;

            GrdVw_Service.ColumnHeadersDefaultCellStyle.Font = new Font("B Titr", 11);
            GrdVw_Service.Font = new Font("Iranian Sans", 9, FontStyle.Regular);
            GrdVw_Service.ForeColor = Color.Black;


            GrdVw_Dr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdVw_Sec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdVw_Service.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Lbl_Name.BackColor = DefaultBackColor;  \\ baraye sakhte label e shisheyi

            Set_Grdvw_Pat_Headers();


            GrdVw_Sec.DataSource = "";
            GrdVw_Sec.DataSource = DB_Obj.Tbl_Section.ToList();

            GrdVw_Sec.Columns[0].HeaderText = "ردیف";
            GrdVw_Sec.Columns[1].HeaderText = "عنوان بخش";


            GrdVw_Sec.Columns[2].Visible = false;
            GrdVw_Sec.ClearSelection();
            GrdVw_Sec.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

            GrdVw_Sec.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Sec.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            GrdVw_Service.DataSource = "";
            GrdVw_Service.DataSource = DB_Obj.Tbl_Service.ToList();
            GrdVw_Service.Columns[0].HeaderText = "ردیف";
            GrdVw_Service.Columns[1].HeaderText = "نوع سرویس";


            GrdVw_Service.Columns[2].Visible = false;

            GrdVw_Dr.DataSource = "";
            GrdVw_Dr.DataSource = DB_Obj.Tbl_Doctor.ToList();

            for (int i = 3; i <= 7; i++)
            {
                GrdVw_Dr.Columns[i].Visible = false;
            }
            GrdVw_Dr.Columns[0].HeaderText = "ردیف";
            GrdVw_Dr.Columns[1].HeaderText = "نام پزشک";
            GrdVw_Dr.Columns["Skill"].HeaderText = "تخصص";
            GrdVw_Dr.Columns["Tbl_Reception"].Visible = false;


            
            GrdVw_Service.ClearSelection();
            GrdVw_Dr.ClearSelection();

            GrdVw_Dr.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            GrdVw_Pat.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            
            GrdVw_Service.DefaultCellStyle.SelectionBackColor = Color.LightGreen;

            GrdVw_Dr.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Dr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            GrdVw_Pat.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Pat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            

            GrdVw_Service.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Service.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Menu_SubReception_And_Pat.PerformClick();
            
            Reception_And_Pat_Click(null, null);
        }
        public void Error_MessageBox()
        {
            MetroMessageBox.Show(this, Error_texts_SB.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        StringBuilder Error_texts_SB = new StringBuilder();

        Model.Tbl_Reception Obj_Reception_Tbl = new Model.Tbl_Reception();

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
            if (Reception_And_Pat_Flag == true)
            {
                if (Text_Name.Text == "" || Text_NCode.Text == "" || Txt_PhoneNum.Text == "" || 
                    Doctors_Index <= -1 || Section_Index <= -1 || Services_Index <= -1||
                    Text_Name.Text == " نام بیمار را وارد کنید." || Text_NCode.Text == "کد ملی را وارد کنید." || Txt_PhoneNum.Text == "همراه  را وارد کنید.")
                {
                    Error_texts_SB.Clear();

                    if (Text_Name.Text == "" || Text_Name.Text== " نام بیمار را وارد کنید.")
                    {
                        Error_texts_SB.AppendLine("نام بیمار را وارد کنید.");
                    }

                     if (Text_NCode.Text == "" || Text_NCode.Text == "کد ملی را وارد کنید.")
                    {
                        Error_texts_SB.AppendLine("کد ملی بیمار را وارد کنید.");
                    }

                    //if (Text_Adrs.Text == "")
                    //{
                    //    MessageBox.Show("آدرس بیمار را وارد کنید.");
                    //}

                     if (Txt_PhoneNum.Text == "" || Txt_PhoneNum.Text== "همراه  را وارد کنید.")
                    {
                        Error_texts_SB.AppendLine("شماره تلفن بیمار را وارد کنید.");
                    }

                     if(Services_Index < 0)
                    {
                        Error_texts_SB.AppendLine("از سرویس های موجود یکی را برگزینید.");
                    }

                      if (Section_Index < 0)
                    {
                        Error_texts_SB.AppendLine("از بخش های موجود یکی را برگزینید");
                    }

                     if (Doctors_Index < 0)
                    {
                        Error_texts_SB.AppendLine("از دکترهای موجود یکی را انتحاب کنید");
                    }

                    Error_MessageBox();

                }
                else
                {
                    //DB_Obj.Entry(Obj_Reception_Tbl).State = System.Data.Entity.EntityState.Modified;
                    //DB_Obj.Entry(Obj_Pat_Tbl).State = System.Data.Entity.EntityState.Modified;
                    //DB_Obj.Entry(DB_Obj.Tbl_Patient).State = System.Data.Entity.EntityState.Modified;
                    //DB_Obj.Entry(DB_Obj.Tbl_Reception).State = System.Data.Entity.EntityState.Modified;

                    this.Opacity = 0.5;
                    Form_Visit_Timing Obj_Visit_Timing = new Form_Visit_Timing();
                    Obj_Visit_Timing.ShowDialog();
                    this.Opacity = 1;

                    if (Obj_Visit_Timing.DialogResult != DialogResult.Cancel)
                    {
                        try
                        {
                            Model.Tbl_Patient Obj_Pat_Tbl = new Model.Tbl_Patient();
                            Obj_Pat_Tbl.name = Text_Name.Text;
                            Obj_Pat_Tbl.mobile = Txt_PhoneNum.Text;
                            Obj_Pat_Tbl.Ncode = Text_NCode.Text;
                            Obj_Pat_Tbl.CountOfPictures = Form_EditImages.list_img.Count;

                            if (Text_Adrs.Text != "" && Text_Adrs.Text != "آدرس را وارد کنید.")
                            {
                                Obj_Pat_Tbl.adrs = Text_Adrs.Text;
                            }
                            else
                            {
                                Obj_Pat_Tbl.adrs = "وارد نشده";
                            }

                            if (Form_EditImages.list_img.Count > 0)
                            {
                                MemoryStream ms = new MemoryStream();
                                for (int i = 0; i < Form_EditImages.list_img.Count; i++)
                                {
                                    Model.Tbl_Pat_Images Obj_Tbl_PatImages = new Model.Tbl_Pat_Images();
                                    Image a = Form_EditImages.list_img[i];
                                    ImageConverter imgCon = new ImageConverter();
                                    var dadadadada = (byte[])imgCon.ConvertTo(a, typeof(byte[]));
                                    Obj_Tbl_PatImages.Image = dadadadada;
                                    DB_Obj.Tbl_Pat_Images.Add(Obj_Tbl_PatImages);
                                    obj_db.SaveChanges();
                                }

                            }

                            DB_Obj.Tbl_Patient.Add(Obj_Pat_Tbl);

                            Obj_Reception_Tbl.DocID = Doctors_Index;
                            Obj_Reception_Tbl.PatID = Obj_Pat_Tbl.ID;
                            Obj_Reception_Tbl.SecID = Section_Index;
                            Obj_Reception_Tbl.ServID = Services_Index;

                            Obj_Reception_Tbl.VisitTime = Trans_Class.Time_Visit_Trans;
                            Obj_Reception_Tbl.VisitDate = Trans_Class.Date_Visit_Trans;

                            DB_Obj.Tbl_Reception.Add(Obj_Reception_Tbl);

                            DB_Obj.SaveChanges();

                            this.Opacity = 0.5;
                            Form_Report obj_rep = new Form_Report();
                            obj_rep.ShowDialog();
                            this.Opacity = 1;

                            Text_Adrs.Width = 118;
                            Text_Adrs.Location = new Point(369, 139);

                            //var query = DB_Obj.Vw_Reception.Where(x => x.name.Contains(Text_Name.Text)).ToList();

                            ////var query = DB_Obj.Vw_Reception.Where(x => x.Name.Contains()).ToList();
                            ////// bind to related RDLC :
                            ////reportViewer1.LocalReport.LoadReportDefinition();

                            //string exeFolder = Application.StartupPath;
                            //string reportPath = Path.Combine(exeFolder, @"Clinic App\Clinic App\Report1.rdlc");

                            //reportViewer1.LocalReport.ReportPath = reportPath;

                            //reportViewer1.LocalReport.DataSources.Add
                            //    (new Microsoft.Reporting.WinForms.ReportDataSource("DataSet4Report", query));


                            //System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                            //string sh = string.Format("{0}/{1}/{2}", pc.GetYear(DateTime.Now),

                            //    pc.GetMonth(DateTime.Now), pc.GetDayOfMonth(DateTime.Now));

                            ////reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("P1", sh));

                            //reportViewer1.RefreshReport();
                            //reportViewer1.Visible = true;
                            //reportViewer1.Show();

                            Section_Index = -1;
                            Services_Index = -1;
                            Doctors_Index = -1;

                            GrdVw_Sec.ClearSelection();
                            GrdVw_Service.ClearSelection();
                            GrdVw_Dr.ClearSelection();

                            Txt_PhoneNum.Clear();
                            Text_Name.Clear();
                            Text_Adrs.Clear();
                            Text_NCode.Clear();

                            Txt_PhoneNum_Leave(null, null);
                            Text_Adrs_Leave(null, null);
                            Text_Name_Leave(null, null);
                            Text_NCode_Leave(null, null);

                            List_Local_Images.Clear();
                            Form_EditImages.list_img.Clear();
                            Btn_ShowUploadedImg.Visible = false;

                            MetroMessageBox.Show(this, "بیمار و نوبت ثبت شد!!!", "Succeced!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        }
                        catch (Exception)
                        {
                            MetroMessageBox.Show(this, "فیلدها را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "تاریخ و ساعت نوبت به درستی انتخاب نشد.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }

            if (Reception_For_Old_Pats_Flag == true) 
            {
                if (Pation_Index <= -1 || Doctors_Index <= -1 || Section_Index <= -1 || Services_Index <= -1)
                {
                    Error_texts_SB.Clear();
                    if (Pation_Index < 0)
                    {
                        Error_texts_SB.AppendLine("از لیست بیماران یکی را انتخاب کنید");
                    }
                    if (Services_Index < 0)
                    {
                        Error_texts_SB.AppendLine("از سرویس های موجود یکی را برگزینید.");
                    }

                    if (Section_Index < 0)
                    {
                        Error_texts_SB.AppendLine("از بخش های موجود یکی را برگزینید");
                    }

                    if (Doctors_Index < 0)
                    {
                        Error_texts_SB.AppendLine("از دکترهای موجود یکی را انتحاب کنید");
                    }
                    Error_MessageBox();

                }
                else
                {
                    this.Opacity = 0.15;
                    Form_Visit_Timing Obj_Visit_Timing = new Form_Visit_Timing();
                    Obj_Visit_Timing.ShowDialog();
                    this.Opacity = 1;

                    if (Obj_Visit_Timing.DialogResult != DialogResult.Cancel)
                    {
                        try
                        {
                            Obj_Reception_Tbl.DocID = Doctors_Index;
                            Obj_Reception_Tbl.PatID = Pation_Index;
                            Obj_Reception_Tbl.SecID = Section_Index;
                            Obj_Reception_Tbl.ServID = Services_Index;

                            Obj_Reception_Tbl.VisitTime = Trans_Class.Time_Visit_Trans.ToString();
                            Obj_Reception_Tbl.VisitDate = Trans_Class.Date_Visit_Trans.ToString();


                            DB_Obj.Tbl_Reception.Add(Obj_Reception_Tbl);
                            DB_Obj.SaveChanges();

                            this.Opacity = 0.5;
                            Form_Report obj_rep = new Form_Report();
                            obj_rep.ShowDialog();
                            this.Opacity = 1;

                            MetroMessageBox.Show(this, "بیمار و نوبت ثبت شد!!!", "Succeced!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                            Text_Adrs.Width = 118;
                            Text_Adrs.Location = new Point(369, 139);

                            Section_Index = -1;
                            Services_Index = -1;
                            Doctors_Index = -1;
                            Pation_Index = -1;

                            GrdVw_Sec.ClearSelection();
                            GrdVw_Service.ClearSelection();
                            GrdVw_Dr.ClearSelection();
                            GrdVw_Pat.ClearSelection();

                            List_Local_Images.Clear();
                            Form_EditImages.list_img.Clear();
                            Btn_ShowUploadedImg.Visible = false;
                        }
                        catch (Exception)
                        {
                            MetroMessageBox.Show(this, "فیلدها را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        

                    }
                    else
                    {
                        MetroMessageBox.Show(this, "تاریخ و ساعت نوبت به درستی انتخاب نشد.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }


            if (Only_Pat_Flag == true)
            {

                if (Text_Name.Text == "" || Text_NCode.Text == "" || Txt_PhoneNum.Text == "" ||
                    Text_Name.Text == " نام بیمار را وارد کنید." || Text_NCode.Text == "کد ملی را وارد کنید." || Txt_PhoneNum.Text == "همراه  را وارد کنید."
                        )
                {
                    Error_texts_SB.Clear();
                    if (Text_Name.Text == "" || Text_Name.Text == " نام بیمار را وارد کنید.")
                    {
                        Error_texts_SB.AppendLine("نام بیمار را وارد کنید.");
                    }

                    if (Text_NCode.Text == "" || Text_NCode.Text == "کد ملی را وارد کنید.")
                    {
                        Error_texts_SB.AppendLine("کد ملی بیمار را وارد کنید.");
                    }

                    if (Txt_PhoneNum.Text == "" || Txt_PhoneNum.Text == "همراه  را وارد کنید.")
                    {
                        Error_texts_SB.AppendLine("شماره تلفن بیمار را وارد کنید.");
                    }
                    
                    Error_MessageBox();
                }

                else
                {
                    try
                    {
                        Model.Tbl_Patient Obj_Pat_Tbl = new Model.Tbl_Patient();
                        Obj_Pat_Tbl.name = Text_Name.Text;
                        Obj_Pat_Tbl.mobile = Txt_PhoneNum.Text;
                        Obj_Pat_Tbl.adrs = Text_Adrs.Text;
                        Obj_Pat_Tbl.Ncode = Text_NCode.Text;
                        Obj_Pat_Tbl.CountOfPictures = Form_EditImages.list_img.Count;

                        if (Form_EditImages.list_img.Count > 0)
                        {
                            for (int i = 0; i < Form_EditImages.list_img.Count; i++)
                            {
                                Model.Tbl_Pat_Images Obj_Tbl_PatImages = new Model.Tbl_Pat_Images();
                                Image a = Form_EditImages.list_img[i];
                                ImageConverter imgCon = new ImageConverter();
                                var dadadadada = (byte[])imgCon.ConvertTo(a, typeof(byte[]));
                                Obj_Tbl_PatImages.Image = dadadadada;
                                DB_Obj.Tbl_Pat_Images.Add(Obj_Tbl_PatImages);
                            }
                        }

                        DB_Obj.Tbl_Patient.Add(Obj_Pat_Tbl);
                        DB_Obj.SaveChanges();

                        Set_Grdvw_Pat_Headers();

                        GrdVw_Pat.Rows[GrdVw_Pat.RowCount - 1].Selected = true;
                        GrdVw_Pat.FirstDisplayedScrollingRowIndex = GrdVw_Pat.RowCount - 1;

                        MetroMessageBox.Show(this, "بیمار با موفقیت ثبت شد.", "Success!!!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        Txt_PhoneNum.Clear();
                        Text_Name.Clear();
                        Text_Adrs.Clear();
                        Text_NCode.Clear();

                        Txt_PhoneNum_Leave(null, null);
                        Text_Adrs_Leave(null, null);
                        Text_Name_Leave(null, null);
                        Text_NCode_Leave(null, null);

                        Text_Adrs.Width = 118;
                        Text_Adrs.Location = new Point(369, 139);

                        List_Local_Images.Clear();
                        Form_EditImages.list_img.Clear();
                        Btn_ShowUploadedImg.Visible = false;
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "فیلدها را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
            }
            
            Trans_Class.NameAndFam = "";
            Trans_Class.PhoneNo = "";
            Trans_Class.Time_Visit_Trans= "";
            Trans_Class.Date_Visit_Trans = "";

        }
        Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
        private void Set_Grdvw_Pat_Headers()
        {
            GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdVw_Pat.RightToLeft = RightToLeft.No;

            
            GrdVw_Pat.DataSource = "";
            GrdVw_Pat.DataSource = DB_Obj.Tbl_Patient.ToList();

            GrdVw_Pat.Columns[0].HeaderText = "ردیف";
            GrdVw_Pat.Columns[1].HeaderText = "نام بیمار";
            GrdVw_Pat.Columns["adrs"].Visible = false;
            GrdVw_Pat.Columns[3].HeaderText = "شماره تماس";
            GrdVw_Pat.Columns[4].HeaderText = "شماره ملی";
            //GrdVw_Pat.Columns[5].Visible = false;
            GrdVw_Pat.Columns["Tbl_Reception"].Visible = false;
            GrdVw_Pat.Columns["CountOfPictures"].HeaderText = "تعداد عکس ذخیره شده";
            GrdVw_Pat.Columns["Tbl_Pat_Images"].Visible = false;


            //GrdVw_Pat.Columns.Add("CountOfImg", "عکس");
            //GrdVw_Pat.Columns["CountOfImg"].Visible = true;

            //for (int i = 0; i < GrdVw_Pat.Rows.Count; i++)
            //{
            //    int ID = (int)GrdVw_Pat.Rows[i].Cells["ID"].Value;
            //    int? result = DB_Obj.SP_Count_Of_Pat_Images(ID).FirstOrDefault();
            //    GrdVw_Pat.Rows[i].Cells["CountOfImg"].Value = result;
            //    //if (result ==0)
            //    //{
            //    //    string val = ".عکسی ثبت نشده.";
            //    //    GrdVw_Pat.Rows[i].Cells["CountOfImg"].Value = val;
            //    //}
            //    //else
            //    //{
            //    //    string val =" "+ result.ToString() + "عکس ثبت شده.";
            //    //    GrdVw_Pat.Rows[i].Cells["CountOfImg"].Value = val;
            //    //}

            //}
        }

        int Services_Index = -1;
        int Section_Index = -1;
        int Doctors_Index = -1;

        private void Text_PhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
            if (Txt_PhoneNum.Text.Count()>=11 && e.KeyChar != 8 ) //   8 is backspace keychar
            {
                e.Handled = true;
            }
        }

        private void Text_NCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void Text_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar);

            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                Text_Name.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                Text_Name.RightToLeft = RightToLeft.No;
            }

        }

        private void Text_Adrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsWhiteSpace(e.KeyChar) || (char.IsLetter(e.KeyChar)) || (char.IsNumber(e.KeyChar)) || e.KeyChar == Convert.ToChar(Keys.Back));

            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                Text_Adrs.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                Text_Adrs.RightToLeft = RightToLeft.No;
            }

            if (Text_Adrs.Text.Count() >= 10)
            {
                Text_Adrs.Location = new Point(369, 139);
                Text_Adrs.Width = 187;
            }
            else
            {
                Text_Adrs.Location = new Point(369, 139);
                Text_Adrs.Width = 118;
            }
        }

        private void Form_Reception_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trans_Class.Flag_Pat_Edit = false;
        }

        bool Reception_And_Pat_Flag = false;
        bool Only_Pat_Flag = false;
        bool Reception_For_Old_Pats_Flag = false;
        private void Reception_And_Pat_Click(object sender, EventArgs e)
        {
            List_Local_Images.Clear();
            Form_EditImages.list_img.Clear();

            Btn_Save.Visible = true;

            Only_Pat_Flag = false;
            Reception_And_Pat_Flag = true;
            Reception_For_Old_Pats_Flag = false;
            Flag_Reprint_Reception = false;
            Flag_Edit_Pat_Images = false;

            this.ActiveControl = this.pictureBox2;
            Btn_Browse.Visible = true;
            Lbl_UpPic.Visible = true;
            PB_UploadPic.Visible = true;
            radSeparator1.Visible = true;

            Btn_NextImg.Visible = false;
            Btn_PrevImg.Visible = false;
            Btn_ShowUploadedImg.Visible = false;

            Lbl_DigitLeft.Visible = false;
            Lbl_DigitRight.Visible = false;
            Lbl_ImgSlash.Visible = false;

            Btn_ShowUploadedImg.ButtonText = "مشاهده و اضافه کردن عکس";
            Btn_ShowUploadedImg.Location = new Point(527, 681);

            GrdVw_Dr.ColumnHeadersDefaultCellStyle.Font = new Font("B Titr", 10);

            GrdVw_Sec.ColumnHeadersDefaultCellStyle.Font = new Font("B Titr", 10);

            GrdVw_Service.ColumnHeadersDefaultCellStyle.Font = new Font("B Titr", 10);

            GrdVw_Dr.BackgroundColor = SystemColors.ButtonFace;
            GrdVw_Pat.BackgroundColor = SystemColors.ButtonFace;
            GrdVw_Sec.BackgroundColor = SystemColors.ButtonFace;
            GrdVw_Service.BackgroundColor = SystemColors.ButtonFace;

            //if (Form_EditImages.list_img.Count != 0)
            //{
            //    Btn_ShowUploadedImg.Visible = true;
            //}
            //else
            //{
            //    Btn_ShowUploadedImg.Visible = false;
            //}
            PB_MohrClinic.Visible = false;
            PB_MohrClinicLittle.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;

            GrdVw_Pat.Visible = true;
            Lbl_Pat.Visible = true;

            GrdVw_Pat.Size = new Size(303, 182);
            GrdVw_Pat.Location = new Point(373, 209);
            Lbl_Pat.Location = new Point(488, 174);
            GrdVw_Pat.Visible = false;
            Lbl_Pat.Visible = false;

            GrdVw_Dr.Location = new Point(215,215);
            GrdVw_Dr.Size = new Size(303, 182);
            Lbl_Dr.Location = new Point(312, 179);

            GrdVw_Service.Location = new Point(373, 432);
            GrdVw_Service.Size = new Size(303, 182);
            Lbl_Service.Location = new Point(501, 394);

            Lbl_Sec.Location = new Point(137, 394);
            GrdVw_Sec.Location = new Point(62, 432);
            GrdVw_Sec.Size = new Size(267, 182);

            Lbl_Adrs.Visible = true;
            Text_Adrs.Visible = true;

            Lbl_Name.Visible = true;
            Text_Name.Visible = true;

            Lbl_NCode.Visible = true;
            Text_NCode.Visible = true;

            Lbl_PhoneNum.Visible = true;
            Txt_PhoneNum.Visible = true;

            Lbl_Sec.Visible = true;
            GrdVw_Sec.Visible = true;

            Lbl_Service.Visible = true;
            GrdVw_Service.Visible = true;

            GrdVw_Dr.Visible = true;
            Lbl_Dr.Visible = true;

            Lbl_Sec.Location = new Point(137, 394);

            Reception_And_Pat_Flag = true;
            Only_Pat_Flag = false;
            Reception_For_Old_Pats_Flag = false;

            GrdVw_Dr.RightToLeft = RightToLeft.No;

            GrdVw_Dr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrdVw_Sec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrdVw_Service.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Reception_For_Old_Pats_Click(object sender, EventArgs e)
        {
            //GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //GrdVw_Pat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            //GrdVw_Pat.RightToLeft = RightToLeft.No;

            //GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //GrdVw_Pat.RightToLeft = RightToLeft.No;

            Btn_Save.Visible = true;

            GrdVw_Pat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Trans_Class.Flag_Pat_Edit = false;

            GrdVw_Pat.Columns["CountOfPictures"].HeaderText = "تعداد عکس";

            GrdVw_Pat.ColumnHeadersDefaultCellStyle.Font = new Font("B Titr", 10);
            GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            GrdVw_Pat.ColumnHeadersHeight = 25;

            GrdVw_Dr.RightToLeft = RightToLeft.No;

            PB_MohrClinic.Visible = true;
            PB_MohrClinicLittle.Visible = false;
            PB_MohrClinic.Location = new Point(284, 26);

            pictureBox1.Visible = false;
            Btn_ShowUploadedImg.Visible = false;
            Btn_Browse.Visible = false;
            Lbl_UpPic.Visible = false;
            PB_UploadPic.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            radSeparator1.Visible=false;

            Lbl_Pat.Text = "بیمار مورد نظر را انتخاب کنید:";

            GrdVw_Sec.ClearSelection();
            GrdVw_Service.ClearSelection();
            GrdVw_Dr.ClearSelection();
            GrdVw_Pat.ClearSelection();

            //GrdVw_Sec.Location = new Point(43, 158);
            //Lbl_Sec.Location = new Point();

            Lbl_Service.Location = new Point(125, 138);

            GrdVw_Service.Location = new Point(43, 178);
            GrdVw_Service.Size = new Size(257, 182);

            GrdVw_Dr.Location = new Point(340, 411);
            Lbl_Dr.Location = new Point(467, 373);
            GrdVw_Dr.Size = new Size(334, 182);

            GrdVw_Pat.Location = new Point(341, 176);
            GrdVw_Pat.Size = new Size(334, 182);
            Lbl_Pat.Location = new Point(487, 138);

            GrdVw_Sec.Location = new Point(43 , 411);
            Lbl_Sec.Location = new Point(125, 373);

            Lbl_Adrs.Visible = true;
            Lbl_Dr.Visible = true;
            Lbl_Name.Visible = true;
            Lbl_NCode.Visible = true;
            Lbl_Pat.Visible = true;
            Lbl_PhoneNum.Visible = true;
            Lbl_Sec.Visible = true;
            Lbl_Service.Visible = true;
            GrdVw_Dr.Visible = true;
            GrdVw_Pat.Visible = true;
            GrdVw_Service.Visible = true;
            GrdVw_Sec.Visible = true;

            Lbl_Adrs.Visible = false;
            Text_Adrs.Visible = false;
            Lbl_Name.Visible = false;
            Text_Name.Visible = false;
            Lbl_NCode.Visible = false;
            Text_NCode.Visible = false;
            Lbl_PhoneNum.Visible = false;
            Txt_PhoneNum.Visible = false;

            Only_Pat_Flag = false;
            Reception_And_Pat_Flag = false;
            Reception_For_Old_Pats_Flag = true;

            GrdVw_Pat.ClearSelection();
            GrdVw_Pat.FirstDisplayedScrollingRowIndex = GrdVw_Pat.RowCount - 1;
            GrdVw_Pat.Rows[GrdVw_Pat.RowCount - 1].Selected = true;

        }

        private void Only_Pat_Click(object sender, EventArgs e)
        {
            Set_Grdvw_Pat_Headers();

            List_Local_Images.Clear();
            Form_EditImages.list_img.Clear();
            Btn_ShowUploadedImg.Visible = false;

            Btn_NextImg.Visible = false;
            Btn_PrevImg.Visible = false;
            Btn_ShowUploadedImg.Visible = false;
            GrdVw_Pat.ClearSelection();
            GrdVw_Pat.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            Btn_ShowUploadedImg.Location = new Point(527, 681);

            //           FLAG ' s
            Only_Pat_Flag = true;
            Reception_And_Pat_Flag = false;
            Reception_For_Old_Pats_Flag = false;
            Flag_Reprint_Reception = false;
            Flag_Edit_Pat_Images = false;
            

            Btn_ShowUploadedImg.Visible = false;
            Btn_Browse.Visible = true;
            Lbl_UpPic.Visible = true;
            PB_UploadPic.Visible = true;

            pictureBox1.Visible = false;
            Lbl_DigitLeft.Visible = false;
            Lbl_DigitRight.Visible = false;
            Lbl_ImgSlash.Visible = false;

            GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GrdVw_Pat.RightToLeft = RightToLeft.No;
            
            PB_MohrClinic.Visible = false;
            PB_MohrClinicLittle.Visible = false;

            Lbl_Dr.Visible = false;
            Lbl_Sec.Visible = false;
            Lbl_Service.Visible = false;
            Lbl_Pat.Visible = true;
            GrdVw_Dr.Visible = false;
            GrdVw_Sec.Visible = false;
            GrdVw_Service.Visible = false;
            GrdVw_Pat.Visible = true;

            Lbl_Adrs.Visible = true;
            Text_Adrs.Visible = true;
            Lbl_Name.Visible = true;
            Text_Name.Visible = true;
            Lbl_NCode.Visible = true;
            Text_NCode.Visible = true;
            Lbl_PhoneNum.Visible = true;
            Txt_PhoneNum.Visible = true;

            radSeparator1.Visible = true;

            pictureBox1.Location = new Point(279, 530);

            GrdVw_Pat.Location = new Point(45, 210);
            GrdVw_Pat.Width = 631;
            GrdVw_Pat.Height = 320;

            Lbl_Pat.Text = "لیست بیماران ثبت شده:";
            
            Lbl_Pat.Location = new Point(515, 175);
            GrdVw_Pat.FirstDisplayedScrollingRowIndex = GrdVw_Pat.RowCount - 1;
            GrdVw_Pat.Rows[GrdVw_Pat.RowCount - 1].Cells["ID"].Selected = true;
            //GrdVw_Pat.SelectedRows = GrdVw_Pat.RowCount - 1;
        }

        int Pation_Index = -1;
        private void GrdVw_Service_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var Ser_grdvw_val = GrdVw_Service.CurrentRow.Cells["ID"].Value;
            Services_Index = (int)Ser_grdvw_val;
        }

        private void GrdVw_Sec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Sec_grdvw_val = GrdVw_Sec.CurrentRow.Cells["ID"].Value;
            Section_Index = (int)Sec_grdvw_val;
        }

        private void GrdVw_Dr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var Dr_grdvw_val = GrdVw_Dr.CurrentRow.Cells["ID"].Value;
            Doctors_Index = (int)Dr_grdvw_val;
        }
        Model.DB_ClinicEntities obj_db = new Model.DB_ClinicEntities();
        Model.Tbl_User obj_Users = new Model.Tbl_User();
        int Pat_grdvw_val;
        int Pat_grdvw_SelectIndx;
        List<Image> List_Local_Images = new List<Image>();
        bool Grdvw_Dr_Bind_Flag = false;
        private void GrdVw_Pat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Pat_grdvw_val = (int)GrdVw_Pat.Rows[e.RowIndex].Cells["ID"].Value;
                Pation_Index = Pat_grdvw_val;
                Trans_Class.ID_Pat_Trans = Pat_grdvw_val;

                if (Flag_Edit_Pat_Images == true)
                {
                    Pat_grdvw_SelectIndx = e.RowIndex;
                    Update_Pat_PictureBox(Pat_grdvw_val);
                    Trans_Class.NameAndFam = GrdVw_Pat.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    //Pat_grdvw_Select = e.RowIndex;
                    //Pat_grdvw_SelectIndx = GrdVw_Pat.FirstDisplayedScrollingRowIndex;
                }
            }

        }

        int LeftNum_Int = 0;
        int RightNum_Int = 0;
        private void Update_Pat_PictureBox(int patid)
        {
            var query = DB_Obj.SP_GetPatImages(patid).ToList();

            if (query.Count > 0)
            {
                List_Local_Images.Clear();
                for (int i = 0; i < query.Count ; i++)
                {
                    List_Local_Images.Add(System.Drawing.Image.FromStream(new System.IO.MemoryStream(query[i].Image)));
                }

                Btn_NextImg.Visible = true;
                Btn_PrevImg.Visible = true;

                Btn_ShowUploadedImg.ButtonText = "مشاهده و اضافه کردن عکس";

                Btn_ShowUploadedImg.Visible = true;
                Lbl_UpPic.Visible = true;
                PB_UploadPic.Visible = true;

                pictureBox1.Location = new Point(279, 530);
                pictureBox1.Image = null;
                pictureBox1.Image = List_Local_Images[0];
                pictureBox1.Show();
                Pb_CurrentImg_Index = 0;
                IncLbl(true, 'f');
                Lbl_DigitLeft.Visible = true;
                Lbl_DigitRight.Visible = true;
                Lbl_ImgSlash.Visible = true;
                query.Clear();
                
            }
            else
            {
                Btn_ShowUploadedImg.Visible = true;
                Btn_ShowUploadedImg.ButtonText = "اضافه کردن عکس";
                Lbl_UpPic.Visible = true;
                PB_UploadPic.Visible = true;
                Btn_Browse.Visible = false;
                Btn_NextImg.Visible = false;
                Btn_PrevImg.Visible = false;
                Lbl_DigitLeft.Visible = false;
                Lbl_DigitRight.Visible = false;
                Lbl_ImgSlash.Visible = false;
                pictureBox1.Location = new Point(279, 554);
                pictureBox1.Image = null;
                pictureBox1.Image = Properties.Resources.marty_mcfly_512;
                List_Local_Images.Clear();
                
            }

        }
        static int Pb_CurrentImg_Index = 0;
        private void IncLbl(bool inp, char Side)
        {
            RightNum_Int = List_Local_Images.Count;

            if (inp)
            {
                if (Side == 'f')
                {
                    LeftNum_Int = 1;
                }
            }
            else
            {
                if (Side == 'r' && (RightNum_Int != LeftNum_Int))
                {
                    ++LeftNum_Int;
                    ++Pb_CurrentImg_Index;
                    pictureBox1.Image = null;
                    pictureBox1.Image = List_Local_Images[Pb_CurrentImg_Index];
                    pictureBox1.Show();
                }
                if (Side == 'L' && (LeftNum_Int != 1))
                {
                    --LeftNum_Int;
                    --Pb_CurrentImg_Index;
                    pictureBox1.Image = null;
                    pictureBox1.Image = List_Local_Images[Pb_CurrentImg_Index];
                    pictureBox1.Show();
                }
            }


            Lbl_DigitLeft.Text = LeftNum_Int.ToString();
            Lbl_DigitRight.Text = RightNum_Int.ToString();
        }
        private void Btn_NextImg_Click(object sender, EventArgs e)
        {
            IncLbl(false, 'r');
        }

        private void Btn_PrevImg_Click(object sender, EventArgs e)
        {
            IncLbl(false, 'L');
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF; *.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF; *.PNG;*.JPEG";
            openFileDialog1.Title = "تصویر را انتخاب کنید";
            openFileDialog1.FileName = "Choose Image";
            openFileDialog1.Multiselect = true;
            //"All files (*.jpg)|*.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Trans_Class.Flag_Pat_Edit == true)
                {
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    Btn_ShowUploadedImg.ButtonText = "ویرایش عکس بیمار انتخاب شده";
                }
                else
                {
                    Btn_ShowUploadedImg.ButtonText = "مشاهده و اضافه کردن عکس";
                }

                for (int i = 0; i < openFileDialog1.FileNames.Length; i++) 
                {
                    Image img = Image.FromFile(openFileDialog1.FileNames[i]);
                    Form_EditImages.list_img.Add(img);
                }

                
                Btn_ShowUploadedImg.Visible = true;
                
            }
        }

        private void Btn_Browse_MouseHover(object sender, EventArgs e)
        {
            PB_UploadPic.Image = Properties.Resources.Camera_Flashing1;
        }

        private void Btn_Browse_MouseLeave(object sender, EventArgs e)
        {
            PB_UploadPic.Image = Properties.Resources.UploadPhotos_512;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void LinkLbl_ShowUploadedImg_LinkClicked(object sender, EventArgs e)
        {

            if (Flag_Edit_Pat_Images == true)
            {
                Form_EditImages.list_img.Clear();
                Form_EditImages.list_img.AddRange(List_Local_Images);

                Form_EditImages Obj_Frm_EditImg = new Form_EditImages(2);
                this.Opacity = 0.75;
                Obj_Frm_EditImg.ShowDialog();
                this.Opacity = 1;
                Set_Grdvw_Pat_Headers();

                //GrdVw_Pat.RefreshEdit();
                //GrdVw_Pat.Refresh();

                GrdVw_Pat.FirstDisplayedScrollingRowIndex = Pat_grdvw_SelectIndx;
                GrdVw_Pat.Rows[Pat_grdvw_SelectIndx].Selected = true;
                Update_Pat_PictureBox(Trans_Class.ID_Pat_Trans);
                GrdVw_Pat.Rows[Pat_grdvw_SelectIndx].Cells["CountOfPictures"].Value = List_Local_Images.Count;


                //GrdVw_Pat.ClearSelection();
                //for (int i = 0; i < GrdVw_Pat.Rows.Count; i++)
                //{
                //    if( Convert.ToInt32(GrdVw_Pat.Rows[i].Cells["ID"].Value )== Trans_Class.ID_Pat_Trans)
                //    {
                //        GrdVw_Pat.FirstDisplayedScrollingRowIndex = i;
                //        GrdVw_Pat.Rows[i].Selected = true;

                //    }
                //}
                //GrdVw_Pat.Rows[Pat_grdvw_Select].Selected = true;
                //GrdVw_Pat.FirstDisplayedScrollingRowIndex = Pat_grdvw_SelectIndx;
            }
            else
            {
                Trans_Class.NameAndFam = Text_Name.Text;
                Form_EditImages Obj_Frm_EditImg = new Form_EditImages(1);
                this.Opacity = 0.75;
                Obj_Frm_EditImg.ShowDialog();
                this.Opacity = 1;

                if (Form_EditImages.list_img.Count != 0)
                    Btn_ShowUploadedImg.Visible = true;
                else
                    Btn_ShowUploadedImg.Visible = false;
            }
        }

        private void Btn_ShowUploadedImg_MouseHover(object sender, EventArgs e)
        {
            PB_UploadPic.Image = Properties.Resources.CameraAdd1;
        }

        private void Btn_ShowUploadedImg_MouseLeave(object sender, EventArgs e)
        {
            PB_UploadPic.Image = Properties.Resources.UploadPhotos_512;
        }

        private void Btn_Exit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btn_Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        private void PB_Menu_MouseHover(object sender, EventArgs e)
        {
            radApplicationMenu1_MouseEnter(null, null);
        }
        private void radApplicationMenu1_MouseEnter(object sender, EventArgs e)
        {      
            //long a = 90055555555000;
            //while (a < 0)
            //{
            //    --a;
            //    PB_Menu.Enabled = true;
            //}
            //PB_Menu.Enabled = false;
        }
        

        private void radMenuButtonItem_BackToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
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
        private void timer_OpenMenu_Tick(object sender, EventArgs e)
        {
            PB_Menu_Static.Image = Properties.Resources.Menu_21;
            PB_Menu_Dynamic.Visible = false;
            PB_Menu_Static.Visible = true;
            timer_OpenMenu.Enabled = false;
            timer_OpenMenu.Stop();
        }

        private void radApplicationMenu1_DropDownClosed(object sender, EventArgs e)
        {
            PB_Menu_Static.Visible = false;
            PB_Menu_Dynamic.Image = Properties.Resources.Menu_Close_Dynamic1;
            PB_Menu_Dynamic.Visible = true;

            timer_CloseMenu.Start();
        }

        private void timer_CloseMenu_Tick(object sender, EventArgs e)
        {
            
            PB_Menu_Static.Image = Properties.Resources.Menu_11;
            PB_Menu_Dynamic.Visible = false;
            PB_Menu_Static.Visible = true;
            timer_CloseMenu.Stop();
        }

        private void radApplicationMenu1_MouseHover(object sender, EventArgs e)
        {
            PB_Menu_Static_MouseHover(null, null);
        }

        private void Text_Name_Enter(object sender, EventArgs e)
        {
            if (Text_Name.Text == " نام بیمار را وارد کنید." || Text_Name.Text=="") 
            {
                Text_Name.Text = "";
                Text_Name.ForeColor = Color.Black;
            }
            //else
            //{
            //    Text_Name.ForeColor = Color.Gray;
            //}
        }

        private void Text_Name_Leave(object sender, EventArgs e)
        {
             if (Text_Name.Text == "")
            {
                Text_Name.RightToLeft = RightToLeft.Yes;
                Text_Name.Text = " نام بیمار را وارد کنید.";
                Text_Name.ForeColor = Color.Gray;
            }
        }

        private void Text_Adrs_Enter(object sender, EventArgs e)
        {
            if (Text_Adrs.Text == "آدرس را وارد کنید." || Text_Adrs.Text == "")
            {
                Text_Adrs.Text = "";
                Text_Adrs.ForeColor = Color.Black;
            }
            //else
            //{
            //    Text_Adrs.ForeColor = Color.Gray;
            //}
        }

        private void Text_Adrs_Leave(object sender, EventArgs e)
        {
            if (Text_Adrs.Text == "")
            {
                Text_Adrs.RightToLeft = RightToLeft.Yes;
                Text_Adrs.Text = "آدرس را وارد کنید.";
                Text_Adrs.ForeColor = Color.Gray;
            }
        }

        private void Txt_PhoneNum_Enter(object sender, EventArgs e)
        {
            if (Txt_PhoneNum.Text == "همراه  را وارد کنید." || Txt_PhoneNum.Text == "")
            {
                Txt_PhoneNum.Text = "";
                Txt_PhoneNum.ForeColor = Color.Black;
                Txt_PhoneNum.TextAlign = HorizontalAlignment.Right;
                Txt_PhoneNum.Font = new Font(FontFamily.GenericSansSerif , 10, FontStyle.Bold);
            }
            //else
            //{
            //    Txt_PhoneNum.ForeColor = Color.Gray;
            //    Txt_PhoneNum.TextAlign = HorizontalAlignment.Left;
            //}
        }

        private void Txt_PhoneNum_Leave(object sender, EventArgs e)
        {
            if (Txt_PhoneNum.Text == "")
            {
                Txt_PhoneNum.Text = "همراه  را وارد کنید.";
                Txt_PhoneNum.RightToLeft = RightToLeft.Yes;
                Txt_PhoneNum.ForeColor = Color.Gray;
                Txt_PhoneNum.TextAlign = HorizontalAlignment.Left;
                Txt_PhoneNum.Font = new Font("B Yekan", 10,FontStyle.Regular);
            }
        }

        private void Text_NCode_Enter(object sender, EventArgs e)
        {
            if (Text_NCode.Text == "کد ملی را وارد کنید." || Text_NCode.Text == "")
            {
                Text_NCode.Text = "";
                Text_NCode.ForeColor = Color.Black;
                Text_NCode.TextAlign = HorizontalAlignment.Right;
                Text_NCode.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            }
            //else
            //{
            //    Text_NCode.ForeColor = Color.Gray;
            //    Txt_PhoneNum.TextAlign = HorizontalAlignment.Left;
            //}
        }

        private void Text_NCode_Leave(object sender, EventArgs e)
        {
            if (Text_NCode.Text == "")
            {
                Text_NCode.Text = "کد ملی را وارد کنید.";
                Text_NCode.ForeColor = Color.Gray;
                Text_NCode.RightToLeft = RightToLeft.Yes;
                Text_NCode.TextAlign = HorizontalAlignment.Left;
                Text_NCode.Font = new Font("B Yekan", 10, FontStyle.Regular);
            }
        }
        
        static bool Flag_Edit_Pat_Images = false;
        static bool Flag_Reprint_Reception = false;
        private void Menu_Edit_PatImages_Click(object sender, EventArgs e)
        {
            Set_Grdvw_Pat_Headers();

            Btn_Save.Visible = false;

            GrdVw_Pat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Only_Pat_Flag = false;
            Reception_And_Pat_Flag = false;
            Reception_For_Old_Pats_Flag = false;
            Flag_Reprint_Reception = false;
            Flag_Edit_Pat_Images = true;

            Btn_ShowUploadedImg.Visible = true;
            Btn_Browse.Visible = false;
            Lbl_UpPic.Visible = true;
            PB_UploadPic.Visible = true;

            pictureBox1.Visible = true;
            Lbl_DigitLeft.Visible = true;
            Lbl_DigitRight.Visible = true;
            Lbl_ImgSlash.Visible = true;

            GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            GrdVw_Pat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //GrdVw_Pat.RightToLeft = RightToLeft.Yes;

            GrdVw_Pat.RightToLeft = RightToLeft.No;

            PB_MohrClinic.Visible = false;
            PB_MohrClinicLittle.Visible = false;
            
            Lbl_Dr.Visible = false;
            Lbl_Sec.Visible = false;
            Lbl_Service.Visible = false;
            Lbl_Pat.Visible = true;
            GrdVw_Dr.Visible = false;
            GrdVw_Sec.Visible = false;
            GrdVw_Service.Visible = false;
            GrdVw_Pat.Visible = true;

            Lbl_Adrs.Visible = false;
            Text_Adrs.Visible = false;
            Lbl_Name.Visible = false;
            Text_Name.Visible = false;
            Lbl_NCode.Visible = false;
            Text_NCode.Visible = false;
            Lbl_PhoneNum.Visible = false;
            Txt_PhoneNum.Visible = false;

            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            radSeparator1.Visible = false;

            pictureBox1.Location = new Point(279, 530);

            Lbl_Pat.Location = new Point(515, 80);
            GrdVw_Pat.Location = new Point(45, 120);

            GrdVw_Pat.Width = 631;
            GrdVw_Pat.Height = 380;

            Btn_ShowUploadedImg.Location = Btn_Browse.Location;
            Btn_ShowUploadedImg.ButtonText = "مشاهده و ویرایش عکس";

            Lbl_Pat.Text = "لیست بیماران ثبت شده:";

            int last_row;
            last_row = GrdVw_Pat.RowCount - 1;
            GrdVw_Pat.FirstDisplayedScrollingRowIndex = last_row;
            GrdVw_Pat.Rows[last_row].Selected = true;

            Trans_Class.ID_Pat_Trans = Convert.ToInt32(GrdVw_Pat.Rows[last_row].Cells["ID"].Value);
            Trans_Class.NameAndFam = GrdVw_Pat.Rows[last_row].Cells["name"].Value.ToString();
            
            Pat_grdvw_SelectIndx = last_row;
            
            Update_Pat_PictureBox(Trans_Class.ID_Pat_Trans);
            //GrdVw_Pat.SelectedRows = GrdVw_Pat.RowCount - 1;

        }

        private void Menu_RePrintReception_Click(object sender, EventArgs e)
        {
            Flag_Reprint_Reception = true;
            Flag_Edit_Pat_Images = false;
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }


        //private void Toast_Notf(char Lang)
        //{
        //    string Eng = "زبان سیستم خود را به انگلیسی تغییر دهید.\n\n(Ctrl+Space)";
        //    string Fa = "زبان سیستم خود را به فارسی تغییر دهید.\n\n(Ctrl+Space)";

        //    XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText01);

        //    XmlNodeList stringElements = toastXml.GetElementsByTagName("text");

        //    stringElements[0].AppendChild(toastXml.CreateTextNode("توجه!!!\n\n\n"));
        //    if (Lang == 'f')
        //    {
        //        stringElements[1].AppendChild(toastXml.CreateTextNode(Fa));
        //    }
        //    else
        //    {
        //        stringElements[1].AppendChild(toastXml.CreateTextNode(Eng));
        //    }


        //    XmlNodeList imageElements = toastXml.GetElementsByTagName(Properties.Resources.thin_0060_error_warning_danger_stop_delete_exit.ToString());


        //    ToastNotification toast = new ToastNotification(toastXml);
        //    toast.RemoteId = "ss";
        //    string appID = toast.RemoteId;
        //    ToastNotificationManager.CreateToastNotifier(appID).Show(toast);

        //}

    }
}
