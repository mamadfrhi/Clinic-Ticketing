using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Clinic_App
{
    public partial class Form_Waiting : Form
    {
        public Form_Waiting()
        {
            InitializeComponent();
        }

        private void Form_Waiting_Load(object sender, EventArgs e)
        {
            RadWaitingBar radWaitingBar1 = new RadWaitingBar();
            radWaitingBar1.Size = new System.Drawing.Size(200, 200);
            radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsSpinner;
            radWaitingBar1.StartWaiting();
            int radius = 20;
            int elementCount = 5;
            for (int i = 0; i < 4; i++)
            {
                radius += 10;
                elementCount += 1;
                DotsSpinnerWaitingBarIndicatorElement dsi = new DotsSpinnerWaitingBarIndicatorElement();
                radWaitingBar1.WaitingIndicators.Add(dsi);
                dsi.Radius = radius;
                dsi.ElementCount = elementCount;
                dsi.RotationDirection = (RotationDirection)(i % 2);
            }
            DotsLineWaitingBarIndicatorElement dli = new DotsLineWaitingBarIndicatorElement();
            radWaitingBar1.WaitingIndicators.Add(dli);
            dli.PositionOffset = new SizeF(0, 50);
            DotsLineWaitingBarIndicatorElement dli1 = new DotsLineWaitingBarIndicatorElement();
            radWaitingBar1.WaitingIndicators.Add(dli1);
            dli1.WaitingDirection = Telerik.WinControls.ProgressOrientation.Left;
            dli1.PositionOffset = new SizeF(0, -50);
            DotsLineWaitingBarIndicatorElement dli2 = new DotsLineWaitingBarIndicatorElement();
            radWaitingBar1.WaitingIndicators.Add(dli2);
            dli2.WaitingDirection = Telerik.WinControls.ProgressOrientation.Bottom;
            dli2.PositionOffset = new SizeF(50, 0);
            DotsLineWaitingBarIndicatorElement dli4 = new DotsLineWaitingBarIndicatorElement();
            radWaitingBar1.WaitingIndicators.Add(dli4);
            dli4.WaitingDirection = Telerik.WinControls.ProgressOrientation.Top;
            dli4.PositionOffset = new SizeF(-50, 0);
            radWaitingBar1.Location = new Point(0, 0);
            radWaitingBar1.Visible = true;
            this.Controls.Add(radWaitingBar1);
            radWaitingBar1.StartWaiting();
        }
    }
}
