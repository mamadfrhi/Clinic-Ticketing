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
using System.Threading;
using System.Globalization;

namespace Clinic_App
{
    public partial class Form_Visit_Timing : MetroFramework.Forms.MetroForm
    {
        public Form_Visit_Timing()
        {
            InitializeComponent();
            
        }

        int startPosX;
        int startPosY;
        int form_Center_Y;
        private void Form_Visit_Timing_Load(object sender, EventArgs e)
        {
            this.Hide();

            Form_Visit_Timing obj_Timing = new Form_Visit_Timing();

            startPosX = Screen.PrimaryScreen.Bounds.Location.Y + (Screen.PrimaryScreen.WorkingArea.Width - obj_Timing.Width) / 2;
            startPosY = -670;
            SetDesktopLocation(startPosX, startPosY);
            //base.OnLoad(e);
            timer1.Start();

            form_Center_Y = Screen.PrimaryScreen.Bounds.Location.Y + (Screen.PrimaryScreen.WorkingArea.Height - obj_Timing.Height) / 2;


            radTimePicker1.CloseButtonText = "ثبت";
            radCalendar1.TodayButton.Text = "امروز";
            radTimePicker1.Text.StartsWith("              ");
            radCalendar1.ClearButton.Text = "پاک کردن";
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            string Shamsi = string.Format("{0}/{1}/{2}", Lbl_int_Year.Text, Lbl_int_Month.Text, Lbl_int_Day.Text);

            Trans_Class.Date_Visit_Trans = Shamsi;
            Trans_Class.Time_Visit_Trans = radTimePicker1.Value.Value.ToShortTimeString();
            DialogResult = DialogResult.OK;
            this.Close();
        }
        PersianCalendar pc = new PersianCalendar();
        
        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            //PersianCalendar ps = new PersianCalendar();

            //DateTime Converted_Date = new DateTime();
            //Converted_Date = ps.ToDateTime(radCalendar1.SelectedDate.Year, radCalendar1.SelectedDate.Month, radCalendar1.SelectedDate.Day , radCalendar1.SelectedDate.Hour , radCalendar1.SelectedDate.Minute , radCalendar1.SelectedDate.Second , radCalendar1.SelectedDate.Millisecond);
            //MessageBox.Show(Converted_Date.ToShortDateString());

            //Lbl_int_Day.Text = Converted_Date.Day.ToString();
            //Lbl_int_Month.Text = Converted_Date.Month.ToString();
            //Lbl_int_Year.Text = Converted_Date.Year.ToString();

            Lbl_int_Day.Text = pc.GetDayOfMonth(radCalendar1.SelectedDate).ToString();
            Lbl_int_Month.Text = pc.GetMonth(radCalendar1.SelectedDate).ToString();
            Lbl_int_Year.Text = pc.GetYear(radCalendar1.SelectedDate).ToString();

            Lbl_int_Day.Font = new Font(Lbl_int_Day.Font.FontFamily, 20 , Lbl_int_Day.Font.Style);
            Lbl_int_Day.Location = new Point(23, 156);

            Lbl_int_Month.Font = new Font(Lbl_int_Day.Font.FontFamily, 20, Lbl_int_Day.Font.Style);
            Lbl_int_Month.Location = new Point(23, 216);

            Lbl_int_Year.Font = new Font(Lbl_int_Day.Font.FontFamily, 15, Lbl_int_Day.Font.Style);
            Lbl_int_Year.Location = new Point(23, 274);
        }

        private void radTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            radTimePicker1.TimePickerElement.PopupContentElement.SetClockTime(radTimePicker1.Value.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPosY += 10;
            if (startPosY >= form_Center_Y)
                timer1.Stop();
            else
                SetDesktopLocation(startPosX, startPosY);
        }

        private void radTimePicker1_MouseHover(object sender, EventArgs e)
        {
            radTimePicker1.TimePickerElement.ShowPopup();
        }
    }
}
