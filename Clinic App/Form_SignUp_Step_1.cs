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
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications; // Notifications library
using Microsoft.QueryStringDotNET; // QueryString.NET
using Windows.Data.Xml.Dom;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Globalization;
using Windows.UI.StartScreen;




namespace Clinic_App
{
    using Windows.UI.Notifications;
    public partial class Form_SignUp_Step_1 : MetroFramework.Forms.MetroForm
    {
        
        public Form_SignUp_Step_1()
        {
            InitializeComponent();
        }
        private void Form_SignUp_Step_1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;

            startPosX = Screen.PrimaryScreen.Bounds.Location.Y + (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            startPosY = -670;
            SetDesktopLocation(startPosX, startPosY);
            //base.OnLoad(e);
            timer1.Start();
            form_Center_Y = Screen.PrimaryScreen.Bounds.Location.Y + (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            Cmb_Role.Items.Insert(0, "نقش کاربر را انتخاب کنید.");
            Cmb_Role.Items.Add("مدیر    (کنترل کامل)");
            Cmb_Role.Items.Add("کاربر     (منشی)");
            Cmb_Role.Items.Add("اپراتور");

            Cmb_Role.SelectedIndex = 0;

            Cmb_Role.RightToLeft =RightToLeft.Yes;
            //First_form_Load = true;
            //}

        }
        
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            
            LblUser_Null.Visible = false;
            Lbl_UserErr.Visible = false;
            Lbl_Role_Err.Visible = false;
            Lbl_RetPwErr.Visible = false;
            Lbl_Pw_Null.Visible = false;

            bool err = false;

            var q = from b in Obj_DB.Tbl_User
                    where b.UserName == Txt_UserName.Text
                    select b;

            //USER NAME
            if (Txt_UserName.Text == "نام کاربری را وارد کنید." || Txt_UserName.Text == "")
            {
                LblUser_Null.Visible = true;
                err = true;
            }
            else if (Txt_UserName.Text != "نام کاربری را وارد کنید." || Txt_UserName.Text != "")
            {
                LblUser_Null.Visible = false;
            }



            //USER NAME DB Check

            if (q.ToList().Count > 0)
            {
                Lbl_UserErr.Visible = true;
                LblUser_Null.Visible = false;
                err = true;
            }
            else
            {
                Lbl_UserErr.Visible = false;
                //LblUser_Null.Visible = false;
            }

            //USER NAME Count

            if (/*(char)*/Txt_UserName.Text.Count() <= 8)
            {
                Lbl_User_small.Visible = true;
                LblUser_Null.Visible = false;
                Lbl_UserNameCharErr.Visible = false;
                err = true;
            }
            else
            {
                Lbl_User_small.Visible = false;
            }

            if (Lbl_UserNameCharErr.Visible == true)
            {
                err = true;
            }

            //PASSWORD

            if (Txt_Pw.Text == "" || Txt_Pw.Text == "کلمه عبور را وارد کنید.")
            {
                Lbl_Pw_Null.Visible = true;
                err = true;
            }
            else
            {
                Lbl_Pw_Null.Visible = false;
            }

            //PASSWORD Count

            if (Txt_Pw.Text.Count() <= 8)
            {
                Lbl_PwCounErr.Visible = true;
                err = true;
            }
            else
            {
                Lbl_PwCounErr.Visible = false;
            }


            //PASSWORD retype check


            if (Txt_RetPw.Text != Txt_Pw.Text)
            {
                Lbl_RetPwErr.Visible = true;
                err = true;
            }
            else
            {
                Lbl_RetPwErr.Visible = false;
            }

            //Role Check

            if (Cmb_Role.Text == "نقش کاربر را انتخاب کنید." || Cmb_Role.SelectedIndex == -1)
            {
                err = true;
                Lbl_Role_Err.Visible = true;
            }
            else
            {
                Lbl_Role_Err.Visible = false;
            }
            if (err == false)
            {

                byte[] c = System.Text.Encoding.UTF8.GetBytes(Txt_Pw.Text);
                System.Security.Cryptography.SHA1 h = SHA1.Create();
                byte[] Hash = h.ComputeHash(c);
                string d = Convert.ToBase64String(Hash);

                Trans_Class.Pw = d;

                Trans_Class.User = Txt_UserName.Text;

                Trans_Class.RoleID = Cmb_Role.SelectedIndex + 1;  //       +1   is    important
                
                //this.Hide();
                //this.Visible = false;

                this.DialogResult = DialogResult.OK;
                //Trans_Class.ParentFormTr = this;

                //this.Dispose();
                //this.Opacity = 0;
                //this.Close();
                this.Visible = false;
                this.Close();
                
                Form_SignUp_Step_2 Form_signUp__2 = new Form_SignUp_Step_2();
                Form_signUp__2.ShowDialog();

                //Btn_Cancel_Click(null, null);
                //this.DialogResult = DialogResult.OK;
                //MessageBox.Show(this.DialogResult.ToString());
                //this.DialogResult = DialogResult.OK;
            }
        }

        int startPosX;
        int startPosY;
        
        int form_Center_Y;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPosY += 12;
            if (startPosY >= form_Center_Y)
                timer1.Stop();
            else
                SetDesktopLocation(startPosX, startPosY);
        }

        
        private void Txt_UserName_Enter(object sender, EventArgs e)
        {
            if (Txt_UserName.Text== "نام کاربری را وارد کنید.")
            {
                Txt_UserName.Text = "";
                Txt_UserName.ForeColor = Color.Black;
                Txt_UserName.RightToLeft = RightToLeft.No;
            }
            
            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                toast_notf();
            }
            
        }

        private void Txt_Pw_Enter(object sender, EventArgs e)
        {
            if (Txt_Pw.Text == "کلمه عبور را وارد کنید.")
            {
                Txt_Pw.Text = "";
                Txt_Pw.ForeColor = Color.Black;
                //Txt_Pw.UseSystemPasswordChar = true;
                Txt_Pw.PasswordChar = '•';
                Txt_Pw.RightToLeft = RightToLeft.No;
            }
            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                toast_notf();
            }
        }

        private void Txt_RetPw_Enter(object sender, EventArgs e)
        {
            if (Txt_RetPw.Text == "کلمه عبور را وارد کنید.")
            {
                Txt_RetPw.Text = "";
                Txt_RetPw.ForeColor = Color.Black;
                //Txt_RetPw.UseSystemPasswordChar = true;
                Txt_RetPw.PasswordChar = '•';
                Txt_RetPw.RightToLeft = RightToLeft.No;
            }

            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                MetroMessageBox.Show(this, "زبان سیستم را به انگلیسی تغییر دهید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        Model.DB_ClinicEntities Obj_DB = new Model.DB_ClinicEntities();

        private void toast_notf()
        {

            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            XmlNodeList stringElements = toastXml.GetElementsByTagName("text");

            stringElements[0].AppendChild(toastXml.CreateTextNode("توجه!!!\n\n\n"));

            stringElements[1].AppendChild(toastXml.CreateTextNode("عملیات اضافه کردن کاربر بصورت کامل انجام نگرفت."));


            XmlNodeList imageElements = toastXml.GetElementsByTagName("text");

            ToastNotification toast = new ToastNotification(toastXml);
            toast.RemoteId = "ss";
            string appID = toast.RemoteId;
            ToastNotificationManager.CreateToastNotifier(appID).Show(toast);
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            //MetroMessageBox.Show(this, "کاربر جدید به پایگاه داده اضافه نشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void Txt_UserName_Leave(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == "")
            {
                Txt_UserName.Text = "نام کاربری را وارد کنید.";
                //Txt_RetPw.UseSystemPasswordChar = false;
                //Txt_RetPw.RightToLeft = RightToLeft.Yes;

                Txt_UserName.ForeColor = Color.DarkGray;
                Txt_UserName.RightToLeft = RightToLeft.Yes;
            }
            Lbl_UserNameCharErr.Visible = false;

            var regexItem = new Regex("^[!@#$%^&*()|/*+]*$'34'");

            char [] chars = Txt_UserName.Text.ToCharArray();

            for (int i = 0; i < chars.Length ; i++)
            {
                if (regexItem.IsMatch(chars[i].ToString()))
                {
                    Lbl_UserNameCharErr.Visible = true;
                    break;
                }
                else
                {
                    Lbl_UserNameCharErr.Visible = false;
                }
            }
            
        }

        private void Txt_RetPw_Leave(object sender, EventArgs e)
        {
            if (Txt_RetPw.Text == "")
            {
                Txt_RetPw.Text = "کلمه عبور را وارد کنید.";
                Txt_RetPw.ForeColor = Color.DarkGray;
                Txt_RetPw.PasswordChar = '\0';
                Txt_RetPw.UseSystemPasswordChar = false;
                Txt_RetPw.RightToLeft = RightToLeft.Yes;
            }
        }

        private void Txt_Pw_Leave(object sender, EventArgs e)
        {
            if (Txt_Pw.Text == "")
            {
                Txt_Pw.Text = "کلمه عبور را وارد کنید.";
                Txt_Pw.ForeColor = Color.DarkGray;
                Txt_Pw.PasswordChar = '\0';
                Txt_Pw.UseSystemPasswordChar = false;
                Txt_Pw.RightToLeft = RightToLeft.Yes;
            }

            
        }
        
        private void Cmb_Role_DropDown(object sender, EventArgs e)
        {
            Cmb_Role.Items.Remove("نقش کاربر را انتخاب کنید.");
        }

        private void Txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                e.Handled = true;
                MetroMessageBox.Show(this, "زبان سیستم را به انگلیسی تغییر دهید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var regex = new Regex(@"[^a-zA-Z0-9_.\s]");

            if (   ( e.KeyChar == Convert.ToChar(Keys.Space) || regex.IsMatch(e.KeyChar.ToString()) || Txt_UserName.Text.Count() > 15 )       && e.KeyChar != Convert.ToChar(Keys.Back)) 
                e.Handled = true;
        }

        private void Txt_Pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                MetroMessageBox.Show(this, "زبان سیستم را به انگلیسی تغییر دهید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Txt_RetPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                MetroMessageBox.Show(this, "زبان سیستم را به انگلیسی تغییر دهید.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Form_SignUp_Step_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            //toast_notf();
        }
    }
}
