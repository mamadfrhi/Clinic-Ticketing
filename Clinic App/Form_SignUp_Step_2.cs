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
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;



namespace Clinic_App
{
    public partial class Form_SignUp_Step_2 : MetroFramework.Forms.MetroForm
    {
        public Form_SignUp_Step_2()
        {
            InitializeComponent();
        }
        bool err = false;
        private void ValidateEmail()
        {
            string email = Txt_Email.Text;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            
            Match match = regex.Match(email);
            if (match.Success)
            {
                Lbl_EmailErr.Visible = false;
            }
            else
            {
                Lbl_EmailErr.Visible = true;
            }
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            err = false;
            Lbl_PhoneNo_Null_Err.Visible = false;
            Lbl_Family_Null_Err.Visible = false;

            if (Txt_NameAndFamily.Text== "نام و نام خانوادگی را وارد کنید." || Txt_NameAndFamily.Text == ""|| Txt_NameAndFamily.Text==null ||(char) Txt_NameAndFamily.Text[0] == 32 )
            {
                Lbl_Family_Null_Err.Visible = true;
                err = true;
            }

            if (Txt_Email.Text != "ایمیل را وارد کنید." )
            {
                ValidateEmail();
            }
            
            if (Txt_Mob.Text== "شماره همراه را وارد کنید." || Txt_Mob.Text=="" || Txt_Mob.Text.Count()<11)
            {
                err = true;
                Lbl_PhoneNo_Null_Err.Visible = true;
            }

            if (err == false )
            {
                try
                {
                    Trans_Class.PhoneNo = Txt_Mob.Text;
                    if (Txt_Email.Text == "ایمیل را وارد کنید."  || Txt_Email.Text == "")
                    {
                        Trans_Class.Email = "";
                    }
                    else
                    {
                        Trans_Class.Email = Txt_Email.Text;
                    }
                    if (Txt_Adrs.Text != "" || Txt_Adrs.Text != "آدرس را وارد کنید.")
                        Trans_Class.Adrs = Txt_Adrs.Text;
                    else
                        Trans_Class.Adrs = "";


                    Trans_Class.NameAndFam = Txt_NameAndFamily.Text;

                    this.Visible = false;
                    this.Close();
                    this.DialogResult = DialogResult.OK;

                    Form_SignUp_Step_3 Form_signUp__3 = new Form_SignUp_Step_3();
                    Form_signUp__3.ShowDialog();
                }
                catch (Exception)
                {

                    MetroMessageBox.Show(this, "فیلد ها را به درستی پر کنید", "Fail!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //else
            //{
            //    MessageBox.Show("فیلد ها را به درستی پر کنید");
            //}
            

        }

        private void Form_SignUp_Step_2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Opacity=0;
            this.Visible = false;
            this.DialogResult = DialogResult.Retry;
            this.Close();
            MetroMessageBox.Show(this, "کاربر جدید به پایگاه داده اضافه نشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Trans_Class.ParentFormTr.Opacity = 1;
            //Trans_Class.ParentFormTr.Visible = true;
            //Trans_Class.ParentFormTr.Show();
        }
        
        private void Txt_NameAndFamily_Enter(object sender, EventArgs e)
        {
            if (Txt_NameAndFamily.Text== "نام و نام خانوادگی را وارد کنید." )
            {
                Txt_NameAndFamily.Text = "";
                Txt_NameAndFamily.ForeColor = Color.Black;
            }
            
        }

        private void Txt_Mob_Enter(object sender, EventArgs e)
        {
            if (Txt_Mob.Text == "شماره همراه را وارد کنید.")
            {
                Txt_Mob.Text = "";
                Txt_Mob.ForeColor = Color.Black;
                Txt_Mob.RightToLeft = RightToLeft.No;
            }
        }

        private void Txt_Adrs_Enter(object sender, EventArgs e)
        {
            if (Txt_Adrs.Text == "آدرس را وارد کنید.")
            {
                Txt_Adrs.Text = "";
                Txt_Adrs.ForeColor = Color.Black;
            }
        }

        private void Txt_Email_Enter(object sender, EventArgs e)
        {
            if (Txt_Email.Text == "ایمیل را وارد کنید.")
            {
                Txt_Email.Text = "";
                Txt_Email.ForeColor = Color.Black;
                Txt_Email.RightToLeft = RightToLeft.No;
            }
            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                Toast_Notf('\0');
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            PB_Back.Cursor = Cursors.Hand;
        }

        private void Btn_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Choose Image";
            openFileDialog1.Title = "تصویر را انتخاب کنید";
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF; *.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF; *.PNG;*.JPEG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PB_User_Prv.ImageLocation = openFileDialog1.FileName;
                Trans_Class.Img = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
            }
        }

        private void Txt_NameAndFamily_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Toast_Notf(char Lang)
        {

            string Eng = "زبان سیستم خود را به انگلیسی تغییر دهید.\n\n(Ctrl+Space)";
            string Fa = "زبان سیستم خود را به فارسی تغییر دهید.\n\n(Ctrl+Space)";

            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            XmlNodeList stringElements = toastXml.GetElementsByTagName("text");

            stringElements[0].AppendChild(toastXml.CreateTextNode("توجه!!!\n\n\n"));
            if (Lang == 'f')
            {
                stringElements[1].AppendChild(toastXml.CreateTextNode(Fa));
            }
            else
            {
                stringElements[1].AppendChild(toastXml.CreateTextNode(Eng));
            }


            XmlNodeList imageElements = toastXml.GetElementsByTagName("image");


            ToastNotification toast = new ToastNotification(toastXml);
            //toast.RemoteId = "ss";
            //string appID = toast.RemoteId;
            //ToastNotificationManager.CreateToastNotifier(appID).Show(toast);

            toast.ExpirationTime = DateTime.Now.AddMinutes(1);
        }

        private void Txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputLanguage Current_Keyboard = InputLanguage.CurrentInputLanguage;
            string Current_Keyboard_Iso = Current_Keyboard.Culture.TwoLetterISOLanguageName;

            if (Current_Keyboard_Iso == "fa")
            {
                e.Handled = true;
            }
        }

        private void Txt_Mob_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
            if (Txt_Mob.Text.Count() == 11)
            {
                e.Handled = true;
            }
        }
        
        
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form_Settings Frm_Settings = new Form_Settings();
            //Frm_Settings.Visible = true;
        }

        private void Txt_NameAndFamily_Leave(object sender, EventArgs e)
        {
            if (Txt_NameAndFamily.Text == "")
            {
                Txt_NameAndFamily.Text = "نام و نام خانوادگی را وارد کنید.";
                //Txt_RetPw.UseSystemPasswordChar = false;
                //Txt_RetPw.RightToLeft = RightToLeft.Yes;

                Txt_NameAndFamily.ForeColor = Color.DarkGray;
                Txt_NameAndFamily.RightToLeft = RightToLeft.Yes;
            }
        }

        private void Txt_Adrs_Leave(object sender, EventArgs e)
        {
            if (Txt_Adrs.Text=="")
            {
                Txt_Adrs.Text = "آدرس را وارد کنید.";
                Txt_Adrs.ForeColor = Color.DarkGray;
                Txt_Adrs.RightToLeft = RightToLeft.Yes;
            }
        }

        private void Txt_Mob_Leave(object sender, EventArgs e)
        {
            if (Txt_Mob.Text == "")
            {
                Txt_Mob.Text = "شماره همراه را وارد کنید.";
                Txt_Mob.ForeColor = Color.DarkGray;
                Txt_Mob.RightToLeft = RightToLeft.Yes;
            }
        }

        private void Txt_Email_Leave(object sender, EventArgs e)
        {
            if (Txt_Email.Text == "")
            {
                Txt_Email.Text = "ایمیل را وارد کنید.";
                Txt_Email.ForeColor = Color.DarkGray;
                Txt_Email.RightToLeft = RightToLeft.Yes;
            }
        }
    }
}
