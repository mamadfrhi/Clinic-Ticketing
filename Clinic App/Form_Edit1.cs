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
using System.Text.RegularExpressions;

namespace Clinic_App
{
    public partial class Form_Edit1 : MetroFramework.Forms.MetroForm
    {
        public Form_Edit1()
        {
            InitializeComponent();
        }
        List<int> List_Doc_ID = new List<int>();
        private void Form_Edit_Load(object sender, EventArgs e)
        {
            if (Trans_Class.Flag_Visit_Edit == true)
            {
                Form_Edit_For_Visits();
            }

            if (Trans_Class.Flag_Pat_Edit == true)
            {
                Form_Edit_For_Pats();
            }
            if (Trans_Class.Flag_Doc_Edit == true)
            {
                Form_Edit_For_docs();
            }
            if ((Trans_Class.Flag_Edit_Sections == true) || (Trans_Class.Flag_Edit_Services == true) || (Trans_Class.Flag_Add_SeRR == true) || (Trans_Class.Flag_Add_SeCC == true))
            {
                Form_Edit_For_Add_SecSer();
            }
            this.ActiveControl = PB_MohrClinic;
        }
        private void Form_Edit_For_Add_SecSer()
        {
            Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();

            PB_MohrClinic.Visible = true;

            Txt_Doc_Adrs.Visible = false;
            Txt_Doc_Mcode.Visible = false;
            Txt_Mob.Visible = false;
            Txt_Name.Visible = false;
            Txt_PatAdrs.Visible = false;
            Txt_Mob.Visible = false;
            Txt_PatNcode.Visible = false;

            Cmb_Dr.Visible = false;
            Cmb_Sec.Visible = false;
            Cmb_Ser.Visible = false;

            Lbl_AddServices.Visible = false;
            Lbl_Doc.Visible = false;
            Lbl_DrMedicalCode.Visible = false;
            Lbl_DrSkill.Visible = false;
            Lbl_Mob.Visible = false;
            Lbl_Name.Visible = false;
            Lbl_Adrs.Visible = false;
            //Lbl_Patmob.Visible = false;
            Lbl_PatNcode.Visible = false;
            Lbl_Sec.Visible = false;
            Lbl_Ser.Visible = false;
            TxtTime.Visible = false;
            Lbl_Date.Visible = false;
            Txt_Date.Visible = false;

            Btn_Save.Location = new Point(25, 200);
            Btn_Cancel.Location = new Point(120, 200);

            Lbl_AddServices.Visible = true;
            Txt_SerSec.Visible = true;
            PB_MohrClinic.Location = new Point(75, 26);
            Txt_SerSec.Location = new Point(25, 157);
            Lbl_AddServices.Location = new Point(22, 115);
            this.Size = new Size(286, 280);

            //txt_sersec.text = "";

            if (Trans_Class.Flag_Add_SeRR == false && Trans_Class.Flag_Add_SeCC == false)
            {
                Txt_SerSec.ForeColor = Color.Black;

                if (Trans_Class.Flag_Edit_Sections == true)
                {
                    var query = Obj_Db.Tbl_Section.ToList().Find(s => s.ID == Trans_Class.ID_SecSer_Trans);
                    Txt_SerSec.Text = query.SecTitle;
                }
                if (Trans_Class.Flag_Edit_Services == true)
                {
                    var query = Obj_Db.Tbl_Service.ToList().Find(s => s.ID == Trans_Class.ID_SecSer_Trans);
                    Txt_SerSec.Text = query.ServTitle;
                }
            }
            else
            {
                Txt_SerSec.Text = "نام را وارد کنید.";
                Txt_SerSec.ForeColor = SystemColors.ControlDark;
                //Txt_SerSec.Text = "";
            }
        }
        private void Form_Edit_For_Visits()
        {
            Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();

            Model.Tbl_Doctor Obj_Tbl_Doctor = new Model.Tbl_Doctor();
            Model.Tbl_Section Obj_Tbl_SeC = new Model.Tbl_Section();
            Model.Tbl_Service Obj_Tbl_SeR = new Model.Tbl_Service();

            Cmb_Sec.DataSource = Obj_Tbl_SeC.SecTitle;
            Cmb_Ser.DataSource = Obj_Tbl_SeR.ServTitle;
            
            /////////////////////////////////////JODA

            PB_MohrClinic.Visible = false;

            Txt_Doc_Adrs.Visible = false;
            Txt_Doc_Mcode.Visible = false;

            Txt_PatAdrs.Visible = false;
            Txt_PatNcode.Visible = false;


            Lbl_AddServices.Visible = false;
            Lbl_DrMedicalCode.Visible = false;
            Lbl_DrSkill.Visible = false;

            Lbl_Adrs.Visible = false;
            //Lbl_Patmob.Visible = false;
            Lbl_PatNcode.Visible = false;


            Lbl_AddServices.Visible = false;
            Txt_SerSec.Visible = false;

            Lbl_Mob.Visible = true;
            Txt_Mob.Visible = true;
            Lbl_Name.Visible = true;
            Txt_Name.Visible = true;

            Lbl_Time.Visible = true;
            TxtTime.Visible = true;

            Lbl_Date.Visible = true;
            Txt_Date.Visible = true;

            Cmb_Ser.Visible = true;
            Cmb_Sec.Visible = true;
            Cmb_Dr.Visible = true;
            Lbl_Ser.Visible = true;
            Lbl_Sec.Visible = true;
            Lbl_Doc.Visible = true;

            Txt_SerSec.Visible = false;

            TxtTime.ForeColor = Color.Black;
            Txt_Date.ForeColor = Color.Black;

            this.Size = new Size(289, 317);

            Btn_Cancel.Location = new Point(118, 256);
            Btn_Save.Location = new Point(23, 256);

            var queryy = Obj_Db.Vw_Reception.ToList().Find(f => f.ID == Trans_Class.ID_Visit_Trans);

            ///////////////Date
            if (queryy.VisitDate == null)
            {
                Txt_Date.Clear();
                Txt_Date.Text = "ثبت نشده است.";
                Txt_Date.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                Txt_Date.Clear();
                Txt_Date.Text = queryy.VisitDate.ToString();
                Txt_Date.RightToLeft = RightToLeft.No;
            }
            ///////////////Time
            if (queryy.VisitTime == null)
            {
                Trans_Class.Time_Visit_Trans = null;
                TxtTime.Clear();
                TxtTime.RightToLeft = RightToLeft.Yes;
                TxtTime.Text = "ثبت نشده است.";
            }
            else
            {
                Trans_Class.Time_Visit_Trans = queryy.VisitTime.ToString();
                TxtTime.Clear();
                TxtTime.RightToLeft = RightToLeft.No;
                TxtTime.Text = queryy.VisitTime.ToString();
            }

            Txt_Name.Text = queryy.name;
            Txt_Mob.Text = queryy.mobile;


            Cmb_Dr.DataSource = Obj_Db.Tbl_Doctor.ToList();
            Cmb_Dr.DisplayMember = "name_dr";
            Cmb_Dr.ValueMember = "ID";
            Cmb_Dr.SelectedIndex = Cmb_Dr.FindStringExact(queryy.Dr_Name.ToString());

            Cmb_Sec.DataSource = Obj_Db.Tbl_Section.ToList();
            Cmb_Sec.DisplayMember = "SecTitle";
            Cmb_Sec.ValueMember = "ID";
            Cmb_Sec.SelectedIndex = Cmb_Sec.FindStringExact(queryy.SecTitle.ToString());

            Cmb_Ser.DataSource = Obj_Db.Tbl_Service.ToList();
            Cmb_Ser.DisplayMember = "ServTitle";
            Cmb_Ser.ValueMember = "ID";
            Cmb_Ser.SelectedIndex = Cmb_Ser.FindStringExact(queryy.ServTitle.ToString());

        }
        private void Form_Edit_For_Pats()
        {
            Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();

            PB_MohrClinic.Visible = false;


            TxtTime.Visible = false;
            Txt_Date.Visible = false;
            Txt_SerSec.Visible = false;
            Txt_Doc_Adrs.Visible = false;
            Txt_Doc_Mcode.Visible = false;
            Txt_Mob.Visible = false;


            Cmb_Dr.Visible = false;
            Cmb_Sec.Visible = false;
            Cmb_Ser.Visible = false;

            Lbl_AddServices.Visible = false;
            Lbl_Doc.Visible = false;
            Lbl_DrMedicalCode.Visible = false;
            Lbl_DrSkill.Visible = false;
            Lbl_Mob.Visible = false;

            Lbl_Sec.Visible = false;
            Lbl_Ser.Visible = false;



            Lbl_Adrs.Visible = true;
            Lbl_PatNcode.Visible = true;
            Lbl_Name.Visible = true;
            Lbl_Mob.Visible = true;

            Txt_Mob.Visible = true;
            Txt_Name.Visible = true;
            Txt_PatAdrs.Visible = true;
            Txt_PatNcode.Visible = true;

            //نام
            Txt_Name.TabIndex = 0;

            //ادرس
            Lbl_Adrs.Location = new Point(161, 59);
            Txt_PatAdrs.Location = new Point(23, 61);
            Txt_PatAdrs.TabIndex = 1;

            //شماره همراه
            Lbl_Mob.Location = new Point(162, 88);
            Txt_Mob.Location = new Point(23, 92);
            Txt_Mob.TabIndex = 2;

            Btn_Save.TabIndex = 3;
            Btn_Cancel.TabIndex = 4;


            Lbl_PatNcode.Location = new Point(160, 119);
            Txt_PatNcode.Location = new Point(23, 123);
            Txt_PatNcode.TabIndex = 3;

            Btn_Cancel.Location = new Point(117, 166);
            Btn_Save.Location = new Point(24, 166);

            this.Size = new Size(281, 228);

            var query = Obj_Db.Tbl_Patient.ToList().Find(s => s.ID == Trans_Class.ID_Pat_Trans);
            Txt_Name.Text = query.name;
            Txt_Mob.Text = query.mobile;
            Txt_PatAdrs.Text = query.adrs;
            Txt_PatNcode.Text = query.Ncode;
        }
        private void Form_Edit_For_docs()
        {
            Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();

            this.Size = new Size(288, 290);
            Btn_Save.Location = new Point(24, 218 + 10);
            Btn_Cancel.Location = new Point(119, 218 + 10);


            Cmb_Ser.Visible = false;
            Cmb_Sec.Visible = false;
            Cmb_Dr.Visible = false;

            TxtTime.Visible = false;
            Txt_Date.Visible = false;
            Txt_Doc_Adrs.Visible = false;
            Txt_Doc_Mcode.Visible = false;
            Txt_Mob.Visible = false;
            Txt_Name.Visible = false;
            Txt_PatAdrs.Visible = false;
            Txt_PatNcode.Visible = false;
            Txt_SerSec.Visible = false;

            Lbl_AddServices.Visible = false;
            Lbl_Date.Visible = false;
            Lbl_Doc.Visible = false;
            Lbl_DrMedicalCode.Visible = false;
            Lbl_DrSkill.Visible = false;
            Lbl_Mob.Visible = false;
            Lbl_Name.Visible = false;
            Lbl_Adrs.Visible = false;
            Lbl_PatNcode.Visible = false;
            Lbl_Sec.Visible = false;
            Lbl_Ser.Visible = false;
            Lbl_Time.Visible = false;


            this.Txt_Doc_Adrs.Visible = false;
            this.Txt_Mob.Visible = false;
            this.Txt_Name.Visible = false;
            this.Txt_SerSec.Visible = false;

            //نام1
            Lbl_Name.Visible = true;
            Txt_Name.Visible = true;

            Lbl_Name.Location = new Point(161, 26);
            Txt_Name.Location = new Point(23, 30);
            Txt_Name.TabIndex = 0;

            //تخصص2
            Lbl_DrSkill.Visible = true;
            Txt_PatAdrs.Visible = true;

            Lbl_DrSkill.Location = new Point(162, 57);
            Txt_PatAdrs.Location = new Point(23, 61);
            Txt_PatAdrs.TabIndex = 1;

            //ادرس3
            Lbl_Adrs.Visible = true;
            Txt_Doc_Adrs.Visible = true;

            Lbl_Adrs.Location = new Point(161, 88);
            Txt_Doc_Adrs.Location = new Point(23, 92);
            Txt_Doc_Adrs.TabIndex = 2;

            //موبایل
            Lbl_Mob.Visible = true;
            Txt_Mob.Visible = true;

            Lbl_Mob.Location = new Point(161, 119);
            Txt_Mob.Location = new Point(23, 123);
            Txt_Mob.TabIndex = 3;

            //کذملی
            Txt_PatNcode.Visible = true;
            Lbl_PatNcode.Visible = true;

            Lbl_PatNcode.Location = new Point(161, 150);
            Txt_PatNcode.Location = new Point(23, 154);
            Txt_PatNcode.TabIndex = 4;

            //کد پزشکی
            Lbl_DrMedicalCode.Visible = true;
            Txt_Doc_Mcode.Visible = true;

            Lbl_DrMedicalCode.Location = new Point(162, 181);
            Txt_Doc_Mcode.Location = new Point(23, 185);
            Txt_Doc_Mcode.TabIndex = 5;


            Btn_Save.TabIndex = 6;
            Btn_Cancel.TabIndex = 6;

            //   Doc_q.name = Txt_Name.Text;
            //    Doc_q.Mobile = Txt_Mob.Text;
            //   Doc_q.Skill = Txt_PatAdrs.Text;
            //Doc_q.Ncode = Txt_PatNcode.Text;
            //Doc_q.MedicalCode = Txt_Doc_Mcode.Text;
            //      Doc_q.adrs = Txt_Doc_Adrs.Text;

            //Lbl_Doc.Text = "تخصص :";
            //Lbl_Doc.Location = new Point(60, 85); ;
            //Txt_PatAdrs.Location = Cmb_Dr.Location;

            //Lbl_Sec.Text = "کد نظام پزشکی :";
            //Lbl_Sec.Location = new Point(26, 117);

            //Lbl_Ser.Text = "کد ملی پزشک :";
            //Lbl_Ser.Location = new Point(35, 143);


            //TextBox Txt_Doc_Mcode = new TextBox();
            //Txt_Doc_Mcode.Size = new System.Drawing.Size(126, 26);
            //Txt_Doc_Mcode.Location = new Point(126, 116);
            //Txt_Doc_Mcode.Visible = true;
            //this.Controls.Add(Txt_Doc_Mcode);

            //Label Lbl_Doc_adrs = new Label();
            //Lbl_Doc_adrs.Location = new Point(45, 171);
            //Lbl_Doc_adrs.Text = "آدرس دکتر:";
            //var lblDocInfo = Lbl_Doc.Font;
            //Lbl_Doc_adrs.Font = new Font("Microsoft Sans Serif", 12);
            //this.Controls.Add(Lbl_Doc_adrs);

            if (Trans_Class.Flag_Doc_Add != true)
            {
                var query = Obj_Db.Tbl_Doctor.ToList().Find(s => s.ID == Trans_Class.ID_Dr_Trans);
                Txt_Name.Text = query.name_dr;
                Txt_Mob.Text = query.Mobile;
                Txt_PatAdrs.Text = query.Skill;
                Txt_PatNcode.Text = query.Ncode;
                Txt_Doc_Mcode.Text = query.MedicalCode;
                Txt_Doc_Adrs.Text = query.adrs;
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();

            if (Trans_Class.Flag_Visit_Edit == true)
            {
                Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();
                try
                {
                    var PatID = Obj_Db.Tbl_Reception.ToList().Find(x => x.ID == Trans_Class.ID_Visit_Trans).PatID.Value;
                    var PatRow = Obj_Db.Tbl_Patient.ToList().Find(x => x.ID == PatID);
                    //var RecRow = Obj_Db.Tbl_Reception.ToList().Find(x => x.ID == Trans_Class.ID_Visit_Trans);

                    PatRow.name = Txt_Name.Text;
                    PatRow.mobile = Txt_Mob.Text;


                    Obj_Db.SaveChanges();

                    var Visit_q = Obj_Db.Tbl_Reception.ToList().Find(s => s.ID == Trans_Class.ID_Visit_Trans);

                    if (Trans_Class.Time_Visit_Trans == null || Trans_Class.Time_Visit_Trans == "")
                    {
                        Visit_q.VisitTime = null;
                    }
                    else
                    {
                        Visit_q.VisitTime = Trans_Class.Time_Visit_Trans;
                    }

                    if (Trans_Class.Date_Visit_Trans == null || Trans_Class.Date_Visit_Trans == "")
                    {
                        Visit_q.VisitDate = null;
                    }
                    else
                    {
                        Visit_q.VisitDate = Trans_Class.Date_Visit_Trans;
                    }

                    Visit_q.DocID = Convert.ToInt32(Cmb_Dr.SelectedValue);
                    Visit_q.SecID = Convert.ToInt32(Cmb_Sec.SelectedValue);
                    Visit_q.ServID = Convert.ToInt32(Cmb_Ser.SelectedValue);

                    Obj_Db.SaveChanges();


                    MetroMessageBox.Show(this, "تغییرات نوبت با موفقیت ثبت شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "فیلدها را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            if (Trans_Class.Flag_Pat_Edit == true)
            {
                Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();
                try
                {
                    var Pat_q = Obj_Db.Tbl_Patient.ToList().Find(s => s.ID == Trans_Class.ID_Pat_Trans);
                    Pat_q.name = Txt_Name.Text;
                    Pat_q.mobile = Txt_Mob.Text;
                    Pat_q.adrs = Txt_PatAdrs.Text;
                    Pat_q.Ncode = Txt_PatNcode.Text;


                    MetroMessageBox.Show(this, "تغییرات مشخصات بیمار موفقیت ثبت شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                    Obj_Db.SaveChanges();
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "فیلدها را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            if (Trans_Class.Flag_Doc_Edit == true || Trans_Class.Flag_Doc_Edit == true)
            {
                Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();
                try
                {
                    if (Trans_Class.Flag_Doc_Edit == true && Trans_Class.Flag_Doc_Add == false)
                    {
                        var Doc_q = Obj_Db.Tbl_Doctor.ToList().Find(s => s.ID == Trans_Class.ID_Dr_Trans);
                        Doc_q.name_dr = Txt_Name.Text;
                        Doc_q.Mobile = Txt_Mob.Text;
                        Doc_q.Skill = Txt_PatAdrs.Text;
                        Doc_q.Ncode = Txt_PatNcode.Text;
                        Doc_q.MedicalCode = Txt_Doc_Mcode.Text;
                        Doc_q.adrs = Txt_Doc_Adrs.Text;

                        Obj_Db.SaveChanges();

                        MetroMessageBox.Show(this, "تغییرات مشخصات دکتر موفقیت ثبت شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }
                    else  //Trans_Class.Flag_Doc_Add == true;
                    {

                        Model.Tbl_Doctor Obj_Doc_Tbl = new Model.Tbl_Doctor();
                        if (Txt_Name.Text != "" && Txt_PatNcode.Text != "" && Txt_Mob.Text != "")
                        {
                            Obj_Doc_Tbl.name_dr = Txt_Name.Text;
                            Obj_Doc_Tbl.Mobile = Txt_Mob.Text;
                            Obj_Doc_Tbl.Skill = Txt_PatAdrs.Text;
                            Obj_Doc_Tbl.Ncode = Txt_PatNcode.Text;
                            Obj_Doc_Tbl.MedicalCode = Txt_Doc_Mcode.Text;
                            Obj_Doc_Tbl.adrs = Txt_Doc_Adrs.Text;

                            Obj_Db.Tbl_Doctor.Add(Obj_Doc_Tbl);
                            Obj_Db.SaveChanges();
                            MetroMessageBox.Show(this, "تغییرات مشخصات دکتر موفقیت ثبت شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Close();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "فیلدها را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "فیلدها را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            //EDIT SECTION & SERVICES

            if (Trans_Class.Flag_Edit_Sections == true || Trans_Class.Flag_Edit_Services == true || Trans_Class.Flag_Add_SeCC == true || Trans_Class.Flag_Add_SeRR == true)
            {
                Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();

                //EDIT SEC
                if (Trans_Class.Flag_Edit_Sections == true && (Txt_SerSec.Text != ""))
                {
                    try
                    {
                        var Sec_query = Obj_Db.Tbl_Section.ToList().Find(s => s.ID == Trans_Class.ID_SecSer_Trans);
                        Sec_query.SecTitle = Txt_SerSec.Text;

                        Obj_Db.SaveChanges();
                        MetroMessageBox.Show(this, "بخش با موفقیت اصلاح شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "فیلد را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (Trans_Class.Flag_Edit_Services == true && (Txt_SerSec.Text != ""))
                {
                    try
                    {
                        var Ser_query = Obj_Db.Tbl_Service.ToList().Find(s => s.ID == Trans_Class.ID_SecSer_Trans);
                        Ser_query.ServTitle = Txt_SerSec.Text;

                        Obj_Db.SaveChanges();
                        MetroMessageBox.Show(this, "سرویس با موفقیت اصلاح شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "فیلد را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if ((Txt_SerSec.Text != "") && Trans_Class.Flag_Add_SeCC == true)
                {
                    try
                    {
                        Model.Tbl_Section Obj_Tbl_Section = new Model.Tbl_Section();
                        Obj_Tbl_Section.SecTitle = Txt_SerSec.Text;
                        Obj_Db.Tbl_Section.Add(Obj_Tbl_Section);

                        Obj_Db.SaveChanges();

                        MetroMessageBox.Show(this, "بخش با موفقیت اضافه شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "خطایی رخ داده است.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                if ((Txt_SerSec.Text != "") && Trans_Class.Flag_Add_SeRR == true)
                {
                    try
                    {
                        Model.Tbl_Service Obj_Tbl_Services = new Model.Tbl_Service();
                        Obj_Tbl_Services.ServTitle = Txt_SerSec.Text;
                        Obj_Db.Tbl_Service.Add(Obj_Tbl_Services);

                        Obj_Db.SaveChanges();

                        MetroMessageBox.Show(this, "سرویس با موفقیت اضافه شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "خطایی رخ داده است.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                if (Txt_SerSec.Text == "")
                {
                    MetroMessageBox.Show(this, "جهت اضافه کردن سرویس/بخش باید نامی انتحاب کیند.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Form_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Trans_Class.Flag_Visit_Edit == true)
            {
                Form_Settings FrmSettings = new Form_Settings();
                FrmSettings.Set_Form_Settings();

            }
            if (Trans_Class.Flag_Doc_Edit == true || Trans_Class.Flag_Pat_Edit == true)
            {
                Form_Searching frmsrching = new Form_Searching();
                frmsrching.Btn_Refresh.Visible = true;
            }
        }
        private void TxtTime_Click(object sender, EventArgs e)
        {
            Form_Visit_Timing Timing_Form = new Form_Visit_Timing();
            Timing_Form.ShowDialog();
            Txt_Date.Text = Trans_Class.Date_Visit_Trans;
            TxtTime.Text = Trans_Class.Time_Visit_Trans;
        }

        private void Txt_Date_Click(object sender, EventArgs e)
        {
            TxtTime_Click(null, null);
        }

        private void Txt_SerSec_Enter(object sender, EventArgs e)
        {
            if (Txt_SerSec.Text == "نام را وارد کنید.")
            {
                Txt_SerSec.Clear();
                Txt_SerSec.ForeColor = Color.Black;
            }
        }

        private void Txt_SerSec_Leave(object sender, EventArgs e)
        {
            if (Txt_SerSec.Text == "")
            {
                Txt_SerSec.Text = "نام را وارد کنید.";
                Txt_SerSec.ForeColor = SystemColors.ControlDark;
            }
        }

        private void Form_Edit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_Save_Click(null, null);
            }
        }

        private void Txt_Mob_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Regex regex = new Regex(@"[^0-9+]");
            //if (regex.IsMatch(e.KeyChar.ToString()))
            //    e.Handled = false;
            //else
            //    e.Handled = true;

            //if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back )
            //{
            //    e.Handled = true;
            //}

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Txt_Mob.Text.Count() >= 11)
            {
                e.Handled = true;
            }
        }

        private void Txt_PatNcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Txt_PatNcode.Text.Count() >= 10)
            {
                e.Handled = true;
            }
        }

        private void Txt_Doc_Mcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Txt_Doc_Mcode.Text.Count() >= 14)
            {
                e.Handled = true;
            }
        }
    }
}
