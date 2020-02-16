using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Clinic_App
{
    public partial class Form_SigIn : MetroFramework.Forms.MetroForm
    {
        public Form_SigIn()
        {
            InitializeComponent();
        }

        Model.DB_ClinicEntities obj_db = new Model.DB_ClinicEntities();
        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            byte[] c = System.Text.Encoding.UTF8.GetBytes(Txt_Pw.Text);
            System.Security.Cryptography.SHA1 h = SHA1.Create();
            byte[] Hash = h.ComputeHash(c);

            string d = Convert.ToBase64String(Hash);

            var q = from b in obj_db.Tbl_User
                    where b.UserName == Txt_UserName.Text && b.Pass == d
                    select b;
            //Admin

            if (Trans_Class.Settings_Btn_Click_Flag == true)
            {
                bool shwdlg_Flag = false;
                if (q.ToList().Exists(r => r.RoleID == 1) && q.ToList().Count == 1)
                {
                    string Role_String;

                    if (q.ToList().Exists(r => r.RoleID == 1))
                    {
                        Role_String = "مدیر";
                    }
                    else
                    {
                        Role_String = "منشی";
                    }

                    string msg = string.Format("ورود '{0}' به عنوان '{1}' موفقیت آمیز بود.", q.ToList().Select(r => r.NameAndFamily).FirstOrDefault().ToString(), Role_String);

                    Error_MessageBox(msg, "Succeced", MessageBoxIcon.Question);
                    
                    shwdlg_Flag = true;
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                    
                }

                if (shwdlg_Flag == false)
                {
                    if ((q.ToList().Exists(r => r.RoleID == 2) || q.ToList().Exists(r => r.RoleID == 3)) && q.ToList().Count == 1)
                    {
                        Error_MessageBox("ورود به این بخش فقط توسط ادمین امکان پذیر میباشد", "Isn't Reachable", MessageBoxIcon.Exclamation);
                    }
                    if (q.ToList().Count == 0)
                    {
                        Error_MessageBox("پسوورد یا نام کاربری نامعتبر میباشد", "Error", MessageBoxIcon.Stop);
                    }
                }
            }

            //Monshi
            if (Trans_Class.Reception_Btn_Click_Flag == true)
            {
                if ((q.ToList().Exists(r => r.RoleID == 1) || q.ToList().Exists(r => r.RoleID == 2)) && q.ToList().Count == 1) 
                {
                    string Role_String;

                    if (q.ToList().Exists(r => r.RoleID == 1))
                    {
                         Role_String = "مدیر";
                    }
                    else
                    {
                         Role_String = "منشی";
                    }

                    string msg = string.Format("ورود '{0}' به عنوان '{1}' موفقیت آمیز بود.", q.ToList().Select(r => r.NameAndFamily).FirstOrDefault().ToString() , Role_String);

                    Error_MessageBox(msg, "Succeced", MessageBoxIcon.Question);
                    this.Close();
                    Trans_Class.User = Txt_UserName.Text;

                    this.DialogResult = DialogResult.OK;
                }
                if (q.ToList().Count == 0)
                {
                    Error_MessageBox("پسوورد یا نام کاربری نامعتبر میباشد","Error", MessageBoxIcon.Error);
                }

                if ((q.ToList().Exists(r => r.RoleID == 3)) && q.ToList().Count == 1) 
                {
                    Error_MessageBox("ورود به این بخش فقط توسط ادمین و منشی امکان پذیر میباشد", "Isn't Reachable", MessageBoxIcon.Exclamation);
                }
            }
            
        }
        public void Error_MessageBox(string Msg ,string Title, MessageBoxIcon Color)
        {
            MetroMessageBox.Show(this, Msg.ToString(), Title, MessageBoxButtons.OK, Color);
        }
        private void Txt_UserName_Enter(object sender, EventArgs e)
        {
            Txt_UserName.Text = "";
            Txt_UserName.RightToLeft = RightToLeft.Yes;
            Txt_UserName.ForeColor = Color.Black;
            Txt_UserName.Focus();
        }

        private void Txt_Pw_Enter(object sender, EventArgs e)
        {
            Txt_Pw.Text = "";
            Txt_Pw.RightToLeft = RightToLeft.Yes;
            Txt_Pw.ForeColor = Color.Black;
            Txt_Pw.Focus();
        }

        private void Form_SignInAndSignUp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Lbl_Nothing;
            if (Trans_Class.Settings_Btn_Click_Flag == true && Trans_Class.Reception_Btn_Click_Flag == false)
            {
                this.Text = "ورود به بخش تنظیمات";
            }
            else
            {
                this.Text = "ورود به بخش پذیرش";
            }
        }

        private void Form_SignInAndSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        

        private void Txt_Pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar( Keys.Enter)) 
            {
                Btn_SignIn_Click(null, null);
            }
        }

        private void Form_SignInAndSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Btn_SignIn_Click(null, null);
            }
        }
    }
}
