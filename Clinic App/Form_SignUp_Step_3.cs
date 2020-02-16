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


namespace Clinic_App
{
    public partial class Form_SignUp_Step_3 : MetroFramework.Forms.MetroForm
    {
        public Form_SignUp_Step_3()
        {
            InitializeComponent();
        }
        Model.DB_ClinicEntities Obj_DB = new Model.DB_ClinicEntities();
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Tbl_User obj_user = new Model.Tbl_User();

                obj_user.UserName = Trans_Class.User;
                obj_user.Pass = Trans_Class.Pw;
                obj_user.Mob = Trans_Class.PhoneNo;
                obj_user.RoleID = Trans_Class.RoleID;
                //if (Trans_Class.RoleID == 2)
                //{
                    //obj_user.Tbl_Role.Role = "User";
                //}
                obj_user.NameAndFamily = Trans_Class.NameAndFam;
                obj_user.img = Trans_Class.Img;
                if (Trans_Class.Email == "0")
                {
                    obj_user.Mail = /*DBNull.Value.ToString()*/ "0";
                }
                else
                {
                    obj_user.Mail = Trans_Class.Email;
                }

                //DateTime time = DateTime.Now;              // Use current time
                //string format = "yyyy-MM-dd HH:MM:ss";    // modify the format depending upon input required in the column in database 
                //string insert = @" insert into Tbl_User(DateTime) values ('" + time.ToString(format) + "')";

                Obj_DB.Tbl_User.Add(obj_user);
                Obj_DB.SaveChanges();

                this.Close();

                this.DialogResult = DialogResult.OK;

                Error_MessageBox("کاربر با موفقیت به پایگاه داده افزوده شد.");

            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "خطایی در اتصال رخ داده.\nاز اول شروع کنید.", "Fail!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void Error_MessageBox(string Msg )
        {
            MetroMessageBox.Show(this, Msg.ToString(), "Done!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        
        private void Form_SignUp_Step_3_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
            Txt_UserName.Text = Trans_Class.User;
            Txt_Phone.Text = Trans_Class.PhoneNo;
            Txt_NameAndFam.Text = Trans_Class.NameAndFam;
            Txt_Adrs.Text = Trans_Class.Adrs;
            if (Trans_Class.Img != null)
            {
                PB_User_Prv.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(Trans_Class.Img));
            }

            if (Trans_Class.Email == "0")
            {
                Txt_Email.Text = "ایمیل وارد نشده است.";
            }
            else
            {
                Txt_Email.Text = Trans_Class.Email;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Retry;
            MetroMessageBox.Show(this, "کاربر جدید به پایگاه داده اضافه نشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
