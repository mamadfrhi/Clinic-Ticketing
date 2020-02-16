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
using System.Security.Cryptography;

namespace Clinic_App
{
    public partial class Form_SignUp : MetroFramework.Forms.MetroForm
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void Txt_UserName_Enter(object sender, EventArgs e)
        {
            Txt_UserName.Text = "";
            Txt_UserName.ForeColor = Color.Black;
        }

        private void Txt_Pw_Enter(object sender, EventArgs e)
        {
            Txt_Pw.Text = "";
            Txt_Pw.ForeColor = Color.Black;
        }

        private void Txt_RetPw_Enter(object sender, EventArgs e)
        {
            Txt_RetPw.Text = "";
            Txt_RetPw.ForeColor = Color.Black;
        }

        private void Txt_Mob_Enter(object sender, EventArgs e)
        {
            Txt_Mob.Text = "";
            Txt_Mob.ForeColor = Color.Black;
        }

        private void Txt_Adrs_Enter(object sender, EventArgs e)
        {
            Txt_Adrs.Text = "";
            Txt_Adrs.ForeColor = Color.Black;
        }

        private void Txt_Email_Enter(object sender, EventArgs e)
        {
            Txt_Email.Text = "";
            Txt_Email.ForeColor = Color.Black;
        }
        private void Txt_NameAndFamily_Enter(object sender, EventArgs e)
        {
            Txt_NameAndFamily.Text = "";
            Txt_NameAndFamily.ForeColor = Color.Black;
        }

        int step = 0;
        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Btn_Cancel;
            step = 1;
            Cmb_Role.Items.Add("کاربر     (منشی)");
            Cmb_Role.Items.Add("مدیر    (کنترل کامل)");
            Cmb_Role.Items.Add("اپراتور");
            //  Cmb_Role.Text = "سطح کاربر را معین کنید.";

            Lbl_UserName.Visible = true;
            Txt_UserName.Visible = true;

            Lbl_UserName.Location = new Point(222, 172);

            Txt_UserName.Location = new Point(96, 197);



            Lbl_PW.Visible = true;
            Txt_Pw.Visible = true;

            Lbl_PW.Location = new Point(225, 228);

            Txt_Pw.Location = new Point(96, 253);

            Lbl_RetPw.Visible = true;
            Txt_RetPw.Visible = true;

            Lbl_RetPw.Location = new Point(195, 284);

            Txt_RetPw.Location = new Point(96, 309);

            Btn_Save.Visible = true;

            Btn_Cancel.Location = new Point(221, 367);
            Btn_Save.Location = new Point(96, 367);



        }
        Model.DB_ClinicEntities Obj_DB = new Model.DB_ClinicEntities();

        Model.Tbl_Role Obj_Role = new Model.Tbl_Role();


        private void Btn_Save_Click(object sender, EventArgs e)
        {
            bool err = false;

            var q = from b in Obj_DB.Tbl_User
                    where b.UserName == Txt_UserName.Text
                    select b;

            switch (step)
            {
                case 1:

                    if (q.ToList().Count > 0)
                    {
                        Lbl_UserErr.Visible = true;
                        err = true;
                    }
                    if (Txt_UserName.Text == Txt_UserName.Text || Txt_UserName.Text == "")
                    {
                        LblUser_Null.Visible = true;
                        err = true;
                    }

                    if (Txt_Pw.Text != Txt_RetPw.Text)
                    {
                        Lbl_RetPwErr.Visible = true;
                        err = true;
                    }

                    if (Txt_Pw.Text != Txt_RetPw.Text)
                    {
                        Lbl_RetPwErr.Visible = true;
                        err = true;
                    }
                    if (err)
                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    break;
                    //case2:
                    //break;
                    //case3:
                    //break;
            }

            
            

            

            if (err==false)
            {
                try
                {

                    Model.Tbl_User obj_user = new Model.Tbl_User();

                    byte[] c = System.Text.Encoding.UTF8.GetBytes(Txt_Pw.Text);
                    System.Security.Cryptography.SHA1 h = SHA1.Create();
                    byte[] Hash = h.ComputeHash(c);

                    string d = Convert.ToBase64String(Hash);

                    obj_user.UserName = Txt_UserName.Text;
                    obj_user.Pass = d.ToString();
                    obj_user.Mob = Txt_Mob.Text;
                    obj_user.RoleID = Cmb_Role.SelectedIndex + 1;
                    obj_user.Mail = Txt_Email.Text;
                    obj_user.NameAndFamily = Txt_NameAndFamily.Text;
                    Obj_DB.Tbl_User.Add(obj_user);
                    Obj_DB.SaveChanges();
                    MessageBox.Show("کاربر جدید ذخیره شد");

                    Lbl_RetPwErr.Visible = false;
                    Lbl_UserErr.Visible = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("فیلد ها را به درستی پر کنید");
                }
                
            }
        }

        private void Txt_Role_Enter(object sender, EventArgs e)
        {
            //Cmb_Role.Size = new Size(188, 23);
            // Cmb_Role.Visible = true;
            //    Txt_Role.Visible = false;


            //Cmb_Role.ValueMember = "ID";
            //Cmb_Role.DisplayMember = "Role";
            //Cmb_Role.DataSource = Obj_DB.Tbl_Role.ToList();


            //Cmb_Role.AllowDrop = true;
            //Cmb_Role.DroppedDown = true;
            Txt_Role.Visible = false;
            Cmb_Role.Visible = true;
            Cmb_Role.AllowDrop = true;
            Cmb_Role.DroppedDown = true;

        }

        
    }
}
