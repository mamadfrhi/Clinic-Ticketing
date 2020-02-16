using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework;

namespace Clinic_App
{
    public partial class Form_Report : MetroFramework.Forms.MetroForm
    {
        public Form_Report()
        {
            InitializeComponent();
           
        }
        Model.DB_ClinicEntities DB_Obj = new Model.DB_ClinicEntities();
        private void timer_Tick(object sender, EventArgs e)
        {
            //timer.Stop();
            //this.radWaitingBar1.AssociatedControl = null;
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(dotsSpinnerWaitingBarIndicatorElement1);

                this.radWaitingBar1.StartWaiting();

                //this.dotsSpinnerWaitingBarIndicatorElement1.Text = "Calculations in process...";
            }

            //backgroundWorker1.RunWorkerAsync();

            //timer.Interval = 3000;
            //this.radWaitingBar1.AssociatedControl = this.reportViewer1;
            //this.radWaitingBar1.StartWaiting();
            //timer.Start();

            //DataSet ds = new DataSet();

            //DataTable dt = new DataTable("Rep_Tbl");

            //dt.Columns.Add(new DataColumn("ID", typeof(int)));
            //dt.Columns.Add(new DataColumn("name", typeof(string)));
            //dt.Columns.Add(new DataColumn("mobile", typeof(string)));
            //dt.Columns.Add(new DataColumn("ServTitle", typeof(string)));
            //dt.Columns.Add(new DataColumn("SecTitle", typeof(string)));
            //dt.Columns.Add(new DataColumn("Dr_Name", typeof(string)));
            //dt.Columns.Add(new DataColumn("VisitDate", typeof(string)));
            //dt.Columns.Add(new DataColumn("VisitTime", typeof(string)));

            //DataRow dr = dt.NewRow();
            //dr["ID"] = 12;
            //dr["name"] = Trans_Class.NameAndFam;
            //dr["mobile"] = Trans_Class.PhoneNo;
            //dr["ServTitle"] = "SERV";
            //dr["SecTitle"] = "Sec";
            //dr["Dr_Name"] = "asdasd";
            //dr["VisitDate"] = "30";
            //dr["VisitTime"] = "2";


            //dt.Rows.Add(dr);
            //ds.Tables.Add(dt);
            //Vw_ReceptionBindingSource.DataSource = ds;
            


        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            this.ActiveControl = reportViewer1;
            //reportViewer1.Focus();

            var a = DB_Obj.SP_FindLast();

            Vw_ReceptionBindingSource.DataSource = a.ToList();

            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            string sh = string.Format("{0}/{1}/{2}", pc.GetYear(DateTime.Now),

                pc.GetMonth(DateTime.Now), pc.GetDayOfMonth(DateTime.Now));

            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Param_NowTime", sh));

            if ((Trans_Class.User != "") || (Trans_Class.User != null))
            {
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Param_UserName", Trans_Class.User));
            }
            else
            {
                //Trans_Class.User = "وارد نشده";
                reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Param_UserName", "وارد نشده"));
            }

            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            reportViewer1.RefreshReport();
            dotsSpinnerWaitingBarIndicatorElement1.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            this.radWaitingBar1.StopWaiting();
            this.radWaitingBar1.ResetWaiting();
            radWaitingBar1.Visible = false;
            
        }
    }
}
