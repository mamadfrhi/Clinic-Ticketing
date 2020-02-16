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
    using MetroFramework;
    public partial class Form_Splash2 : MetroFramework.Forms.MetroForm
    {
        public Form_Splash2()
        {
            InitializeComponent();
        }
        private void Form_Splash2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

            timer2.Enabled = true;
            timer2.Start();
        }

        int timer_1_Tick_num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer_1_Tick_num++;

            if (timer_1_Tick_num == 1)
            {
                metroTile11.BackColor = Color.IndianRed;
                metroTile12.BackColor = Color.IndianRed;
                metroTile13.BackColor = Color.IndianRed;
            }

            if (timer_1_Tick_num == 2)
            {
                metroTile11.BackColor = Color.LightGreen;
                metroTile12.BackColor = Color.LightGreen;
                metroTile13.BackColor = Color.LightGreen;

                metroTile21.BackColor = Color.IndianRed;
                metroTile22.BackColor = Color.IndianRed;
                metroTile23.BackColor = Color.IndianRed;

                metroTile11.BackColor = Color.Black;
                metroTile12.BackColor = Color.Black;
                metroTile13.BackColor = Color.Black;
            }
            if (timer_1_Tick_num == 3)
            {
                metroTile21.BackColor = Color.LightGreen;
                metroTile22.BackColor = Color.LightGreen;
                metroTile23.BackColor = Color.LightGreen;

                metroTile31.BackColor = Color.IndianRed;
                metroTile32.BackColor = Color.IndianRed;
                metroTile33.BackColor = Color.IndianRed;

                metroTile21.BackColor = Color.Black;
                metroTile22.BackColor = Color.Black;
                metroTile23.BackColor = Color.Black;
            }
            if (timer_1_Tick_num == 4)
            {
                metroTile31.BackColor = Color.LightGreen;
                metroTile32.BackColor = Color.LightGreen;
                metroTile33.BackColor = Color.LightGreen;

                metroTile41.BackColor = Color.IndianRed;
                metroTile42.BackColor = Color.IndianRed;
                metroTile43.BackColor = Color.IndianRed;

                metroTile31.BackColor = Color.Black;
                metroTile32.BackColor = Color.Black;
                metroTile33.BackColor = Color.Black;
            }
            if (timer_1_Tick_num == 5)
            {
                metroTile41.BackColor = Color.LightGreen;
                metroTile42.BackColor = Color.LightGreen;
                metroTile43.BackColor = Color.LightGreen;

                metroTile51.BackColor = Color.IndianRed;
                metroTile52.BackColor = Color.IndianRed;
                metroTile53.BackColor = Color.IndianRed;

                metroTile41.BackColor = Color.Black;
                metroTile42.BackColor = Color.Black;
                metroTile43.BackColor = Color.Black;

            }
            if (timer_1_Tick_num == 6)
            {
                metroTile51.BackColor = Color.LightGreen;
                metroTile52.BackColor = Color.LightGreen;
                metroTile53.BackColor = Color.LightGreen;

                metroTile41.BackColor = Color.IndianRed;
                metroTile42.BackColor = Color.IndianRed;
                metroTile43.BackColor = Color.IndianRed;
                
            }

            if (timer_1_Tick_num == 7)
            {
                metroTile41.BackColor = Color.LightGreen;
                metroTile42.BackColor = Color.LightGreen;
                metroTile43.BackColor = Color.LightGreen;

                metroTile31.BackColor = Color.IndianRed;
                metroTile32.BackColor = Color.IndianRed;
                metroTile33.BackColor = Color.IndianRed;
                
            }
            if (timer_1_Tick_num == 8)
            {
                metroTile31.BackColor = Color.LightGreen;
                metroTile32.BackColor = Color.LightGreen;
                metroTile33.BackColor = Color.LightGreen;

                metroTile21.BackColor = Color.IndianRed;
                metroTile22.BackColor = Color.IndianRed;
                metroTile23.BackColor = Color.IndianRed;
            }
            if (timer_1_Tick_num == 9)
            {
                metroTile21.BackColor = Color.LightGreen;
                metroTile22.BackColor = Color.LightGreen;
                metroTile23.BackColor = Color.LightGreen;

                metroTile11.BackColor = Color.IndianRed;
                metroTile12.BackColor = Color.IndianRed;
                metroTile13.BackColor = Color.IndianRed;
            }

            if (timer_1_Tick_num == 10)
            {
                metroTile11.BackColor = Color.LightGreen;
                metroTile12.BackColor = Color.LightGreen;
                metroTile13.BackColor = Color.LightGreen;
                timer_1_Tick_num = 0;
            }
        }
        int timer_2_Tick_num = 0;
        int visiable_Num = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            timer_2_Tick_num++;

            if (timer_2_Tick_num == 1)
            {
                metroTile61.BackColor = Color.IndianRed;
                metroTile62.BackColor = Color.IndianRed;
                metroTile63.BackColor = Color.IndianRed;
            }

            if (timer_2_Tick_num == 2)
            {
                metroTile61.BackColor = Color.LightGreen;
                metroTile62.BackColor = Color.LightGreen;
                metroTile63.BackColor = Color.LightGreen;

                metroTile71.BackColor = Color.IndianRed;
                metroTile72.BackColor = Color.IndianRed;
                metroTile73.BackColor = Color.IndianRed;

                metroTile61.BackColor = Color.Black;
                metroTile62.BackColor = Color.Black;
                metroTile63.BackColor = Color.Black;
            }
            if (timer_2_Tick_num == 3)
            {
                metroTile71.BackColor = Color.LightGreen;
                metroTile72.BackColor = Color.LightGreen;
                metroTile73.BackColor = Color.LightGreen;

                metroTile81.BackColor = Color.IndianRed;
                metroTile82.BackColor = Color.IndianRed;
                metroTile83.BackColor = Color.IndianRed;

                metroTile71.BackColor = Color.Black;
                metroTile72.BackColor = Color.Black;
                metroTile73.BackColor = Color.Black;
            }
            if (timer_2_Tick_num == 4)
            {
                metroTile81.BackColor = Color.LightGreen;
                metroTile82.BackColor = Color.LightGreen;
                metroTile83.BackColor = Color.LightGreen;

                metroTile91.BackColor = Color.IndianRed;
                metroTile92.BackColor = Color.IndianRed;
                metroTile93.BackColor = Color.IndianRed;

                metroTile81.BackColor = Color.Black;
                metroTile82.BackColor = Color.Black;
                metroTile83.BackColor = Color.Black;
            }
            if (timer_2_Tick_num == 5)
            {
                metroTile91.BackColor = Color.LightGreen;
                metroTile92.BackColor = Color.LightGreen;
                metroTile93.BackColor = Color.LightGreen;

                metroTile101.BackColor = Color.IndianRed;
                metroTile102.BackColor = Color.IndianRed;
                metroTile103.BackColor = Color.IndianRed;

                metroTile91.BackColor = Color.Black;
                metroTile92.BackColor = Color.Black;
                metroTile93.BackColor = Color.Black;
            }
            if (timer_2_Tick_num == 6)
            {
                metroTile101.BackColor = Color.LightGreen;
                metroTile102.BackColor = Color.LightGreen;
                metroTile103.BackColor = Color.LightGreen;

                metroTile91.BackColor = Color.IndianRed;
                metroTile92.BackColor = Color.IndianRed;
                metroTile93.BackColor = Color.IndianRed;
            }
            if (timer_2_Tick_num == 7)
            {
                metroTile91.BackColor = Color.LightGreen;
                metroTile92.BackColor = Color.LightGreen;
                metroTile93.BackColor = Color.LightGreen;

                metroTile81.BackColor = Color.IndianRed;
                metroTile82.BackColor = Color.IndianRed;
                metroTile83.BackColor = Color.IndianRed;
            }
            if (timer_2_Tick_num == 8)
            {
                metroTile81.BackColor = Color.LightGreen;
                metroTile82.BackColor = Color.LightGreen;
                metroTile83.BackColor = Color.LightGreen;

                metroTile71.BackColor = Color.IndianRed;
                metroTile72.BackColor = Color.IndianRed;
                metroTile73.BackColor = Color.IndianRed;
            }

            if (timer_2_Tick_num == 9)
            {
                metroTile71.BackColor = Color.LightGreen;
                metroTile72.BackColor = Color.LightGreen;
                metroTile73.BackColor = Color.LightGreen;

                metroTile61.BackColor = Color.IndianRed;
                metroTile62.BackColor = Color.IndianRed;
                metroTile63.BackColor = Color.IndianRed;
            }
            if (timer_2_Tick_num == 10)
            {
                metroTile61.BackColor = Color.LightGreen;
                metroTile62.BackColor = Color.LightGreen;
                metroTile63.BackColor = Color.LightGreen;
                visiable_Num++;
                if (visiable_Num ==1)
                {
                    metroTile01.Visible = true;
                }
                if (visiable_Num == 2)
                {
                    metroTile02.Visible = true;
                }
                if (visiable_Num == 3)
                {
                    metroTile03.Visible = true;
                }
                if (visiable_Num==4)
                {
                    timer2.Stop();
                    timer1.Stop();

                    this.Hide();
                    Form_Main ObjMainForm = new Form_Main();
                    ObjMainForm.ShowDialog();
                }

                timer_2_Tick_num = 0;
            }
            
        }
    }
}
