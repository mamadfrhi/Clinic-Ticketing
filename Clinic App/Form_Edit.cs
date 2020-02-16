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

namespace Clinic_App
{
    public partial class Form_Edit : MetroFramework.Forms.MetroForm
    {
        public Form_Edit()
        {
            InitializeComponent();
        }
        Model.DB_ClinicEntities Obj_Db = new Model.DB_ClinicEntities();
        Model.Tbl_Doctor Obj_Doc_Tbl = new Model.Tbl_Doctor();
        private void Form_Edit_Load(object sender, EventArgs e)
        {
            if (Trans_Class.Flag_Visit_Edit==true)
            {
                Form_Edit_For_Visits();
            }

            if (Trans_Class.Flag_Pat_Edit==true)
            {
                Form_Edit_For_Pats();
            }
            if (Trans_Class.Flag_Doc_Edit == true)
            {
                Form_Edit_For_docs();
            }

        }
        private void Form_Edit_For_Visits()
        {
            Cmb_Ser.Visible = true;
            Cmb_Sec.Visible = true;
            Cmb_Dr.Visible = true;
            Lbl_Ser.Visible = true;
            Lbl_Sec.Visible = true;
            Lbl_Doc.Visible = true;

           
            var queryy = Obj_Db.Vw_Reception.ToList().Find(f => f.ID == Trans_Class.ID_Visit_Trans);
            Txt_Name.Text = queryy.name;
            Txt_Mob.Text = queryy.mobile;

            //Cmb_Dr.DataSource = Obj_Db.Tbl_Doctor.ToList();
            //Cmb_Dr.DisplayMember = "Dr_Name";
            ////Cmb_Dr.ValueMember = "ID";
            //Cmb_Dr.SelectedIndex = Cmb_Dr.FindStringExact(queryy.Dr_Name.ToString());

            Cmb_Sec.DataSource = Obj_Db.Tbl_Section.ToList();
            Cmb_Sec.DisplayMember = "SecTitle";
            Cmb_Sec.ValueMember = "ID";
            Cmb_Sec.SelectedIndex = Cmb_Sec.FindStringExact(queryy.SecTitle.ToString());

            Cmb_Ser.DataSource = Obj_Db.Tbl_Service.ToList();
            Cmb_Ser.DisplayMember = "ServTitle";
            Cmb_Ser.ValueMember = "ID";
            Cmb_Ser.SelectedIndex =  Cmb_Ser.FindStringExact(queryy.ServTitle.ToString());
        }
        private void Form_Edit_For_Pats()
        {
            Cmb_Ser.Visible = false;
            Cmb_Sec.Visible = false;
            Cmb_Dr.Visible = false;
            Lbl_Ser.Visible = false;
            Lbl_Sec.Visible = false;
            Lbl_Doc.Visible = false;

            Txt_PatAdrs.Visible = true;
            Txt_PatNcode.Visible = true;
            Lbl_PatAdrs.Visible = true;
            Lbl_PatNcode.Visible = true;


            Txt_PatNcode.Location = new Point(23, 94);
            Lbl_PatNcode.Location = new Point(157, 90);
            
            Txt_PatAdrs.Location = new Point(23, 123);
            Lbl_PatAdrs.Location = new Point(159, 121);

            Btn_Cancel.Location = new Point(117, 166);
            Btn_Save.Location = new Point(24, 166);

            this.Size = new Size(281, 228);

            var query = Obj_Db.Tbl_Patient.ToList().Find(s => s.ID == Trans_Class.ID_Pat_Trans);
            Txt_Name.Text = query.name;
            Txt_Mob.Text = query.mobile;
            Txt_PatAdrs.Text = query.adrs;
            Txt_PatMob.Text = query.mobile;
            Txt_PatNcode.Text = query.Ncode;
        }
        public TextBox Txt_Doc_Mcode = new TextBox();
        TextBox Txt_Doc_Adrs = new TextBox();
        private void Form_Edit_For_docs()
        {
            //this.Size = new Size(283, 287);


            

            Cmb_Ser.Visible = false;
            Cmb_Sec.Visible = false;
            Cmb_Dr.Visible = false;

            //Lbl_Ser.Visible = true;
            //Lbl_Sec.Visible = true;
            //Lbl_Doc.Visible = true;
            Lbl_PatNcode.Visible = true;
            Txt_PatAdrs.Visible = true;
            Txt_PatNcode.Visible = true;



            Lbl_DrMedicalCode.Visible = true;
            Txt_Doc_Mcode.Visible = true;
            Txt_Doc_Mcode.Location = new Point(23, 156);



            Txt_PatMob.Location = Cmb_Dr.Location;


            Txt_PatAdrs.Location = new Point(23, 94);


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

            var query = Obj_Db.Tbl_Doctor.ToList().Find(s => s.ID == Trans_Class.ID_Dr_Trans);
            Txt_Name.Text = query.name_dr;
            Txt_Mob.Text = query.Mobile;
            Txt_PatAdrs.Text = query.Ncode;
            Txt_PatNcode.Text = query.Skill;
            Txt_Doc_Mcode.Text = query.MedicalCode;
            Txt_Doc_Adrs.Text = query.adrs;
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Trans_Class.Flag_Visit_Edit == true)
            {
                try
                {
                    var PatID = Obj_Db.Tbl_Reception.ToList().Find(x => x.ID == Trans_Class.ID_Visit_Trans).PatID.Value;
                    var PatRow = Obj_Db.Tbl_Patient.ToList().Find(x => x.ID == PatID);

                    PatRow.name = Txt_Name.Text;
                    PatRow.mobile = Txt_Mob.Text;
                    Obj_Db.SaveChanges();

                    var Visit_q = Obj_Db.Tbl_Reception.ToList().Find(s => s.ID == Trans_Class.ID_Visit_Trans);

                    Visit_q.DocID = Cmb_Dr.SelectedIndex + 1;
                    Visit_q.SecID = Cmb_Sec.SelectedIndex + 1;
                    Visit_q.ServID = Cmb_Ser.SelectedIndex + 1;

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

            if (Trans_Class.Flag_Doc_Edit == true)
            {
                try
                {
                    var Doc_q = Obj_Db.Tbl_Doctor.ToList().Find(s => s.ID == Trans_Class.ID_Dr_Trans);
                    Doc_q.name_dr = Txt_Name.Text;
                    Doc_q.Mobile = Txt_Mob.Text;
                    Doc_q.Skill = Txt_PatAdrs.Text;
                    Doc_q.Ncode = Txt_PatNcode.Text;
                    Doc_q.MedicalCode = Txt_Doc_Mcode.Text;
                    Doc_q.adrs = Txt_Doc_Adrs.Text;

                    Obj_Db.SaveChanges();

                    MetroMessageBox.Show(this, "تغییرات مشخصات بیمار موفقیت ثبت شد.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "فیلدها را به درستی پر کنید", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void Form_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Trans_Class.Flag_Visit_Edit == true)
            //{
            //    Form_Settings FrmSettings = new Form_Settings();
            //    FrmSettings.Set_Form_Settings();

            //}
            //if (Trans_Class.Flag_Doc_Edit== true || Trans_Class.Flag_Pat_Edit==true)
            //{
            //    Form_Searching frmsrching = new Form_Searching();
            //    frmsrching.Btn_Refresh.Visible = true;
            //}
        }
    }
}
