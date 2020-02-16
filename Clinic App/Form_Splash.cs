using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Clinic_App
{
    using Bunifu;
    using MetroFramework;
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
        }
        public void Form_Splash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;

            this.Opacity = this.Opacity + 0.004;
            if (progressBar1.Value == 90)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = Clinic_App.Properties.Resources.clinic_clipart_4531;
            }


            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                timer2.Enabled = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity =this.Opacity-0.005;
            if (this.Opacity==0)
            {
                timer2.Stop();
                this.Hide();
                Form_Main ObjMainForm = new Form_Main();
                ObjMainForm.ShowDialog();
            }
        }

        
    }
}
