using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_App
{
    using MetroFramework;
    public partial class Form_Main : MetroFramework.Forms.MetroForm
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        
        private void Btn_Reception_Click_1(object sender, EventArgs e)
        {
            
            Trans_Class.Reception_Btn_Click_Flag = true;
            Trans_Class.Settings_Btn_Click_Flag = false;

            var Form_Signin = new Form_SigIn();
            this.Opacity = 0.5;
            DialogResult DS = Form_Signin.ShowDialog();
            this.Opacity = 1;

            if (DS==DialogResult.OK)
            {
                this.Hide();
                var Form_Reception = new Form_Reception();
                DialogResult DS_rec = Form_Reception.ShowDialog();

                if (DS_rec == DialogResult.OK) 
                {
                    this.Show();
                    this.Activate();
                }
            }
            else
            {
                //MetroMessageBox.Show(this, "ورود موفقیت آمیز نبود.", "unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_ViewTbls_Click(object sender, EventArgs e)
        {
            
            //this.Close();
            //Form_View_All_Tbls Obj_View_All_Tbls = new Form_View_All_Tbls();
            //Obj_View_All_Tbls.ShowDialog();
            this.Hide();
            var Form = new Form_View_All_Tbls();
            //Form.Closed += (s, args) => this.Close();
            DialogResult DS_rec= Form.ShowDialog();
            if (DS_rec == DialogResult.OK)
            {
                this.Show();
                this.Activate();
            }

        }

        private void Btn_Settings_Click(object sender, EventArgs e)
        {
            Trans_Class.Reception_Btn_Click_Flag = false;
            Trans_Class.Settings_Btn_Click_Flag = true;

            

            var Form_Signin = new Form_SigIn();
            this.Opacity = 0.5;
            DialogResult DS = Form_Signin.ShowDialog();
            this.Opacity = 1;

            if (DS == DialogResult.OK)
            {
                this.Hide();
                var Form_Settings = new Form_Settings();
                //Form_Settings.Owner = this;
                //Form_Settings.Closed += (s, args) => this.Close();
                DialogResult DS_Setings= Form_Settings.ShowDialog();
                if (DS_Setings == DialogResult.Cancel)
                {
                    this.Show();
                    this.Activate();
                }
                
            }
            else
            {
                //MetroMessageBox.Show(this, "ورود موفقیت آمیز نبود.", "unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //this.Hide();
            //var Form_SignIn = new Form_SigIn();
            //Form_SignIn.Closed += (s, args) => this.Close();
            //Form_SignIn.ShowDialog();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.Activate();
            Trans_Class.Reception_Btn_Click_Flag = false;
            Trans_Class.Settings_Btn_Click_Flag = false;
        }
    }
}
