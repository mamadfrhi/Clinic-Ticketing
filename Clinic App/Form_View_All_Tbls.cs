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
    public partial class Form_View_All_Tbls : MetroFramework.Forms.MetroForm
    {
        public Form_View_All_Tbls()
        {
            InitializeComponent();
        }

        private void Form_View_All_Tbls_Load(object sender, EventArgs e)
        {
            this.Activate();

            Model.DB_ClinicEntities ObjDB = new Model.DB_ClinicEntities();

            //GrdVw_Drs.DataSource = Obj_DB.Tbl_Doctor.ToList();
            //GrdVw_Drs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //GrdVw_Drs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



            GrdVw_Drs.DataSource = ObjDB.Vw_Dr.ToList();
            GrdVw_Drs.Columns[0].HeaderText = "ردیف";
            GrdVw_Drs.Columns[1].HeaderText = "نام و نام خانوادگی";
            GrdVw_Drs.Columns[2].HeaderText = "کد پزشکی";
            GrdVw_Drs.Columns[3].HeaderText = "کد ملی";
            GrdVw_Drs.Columns[4].HeaderText = "تخصص";
            GrdVw_Drs.Columns[5].HeaderText = "شماره تماس";
            GrdVw_Drs.Columns[6].HeaderText = "آدرس";

            GrdVw_Drs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrdVw_Drs.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Drs.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            GrdVw_Drs.DefaultCellStyle.SelectionForeColor = Color.White;

            GrdVw_Drs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //GrdVw_Drs.Columns[7].Visible = false;
            //GrdVw_Drs.Columns[2].Visible = false;

            GrdVw_Pats.DataSource = ObjDB.Vw_Pat.ToList();
            
            GrdVw_Pats.Columns[0].HeaderText = "ردیف";
            GrdVw_Pats.Columns[1].HeaderText = "نام و نام خانوادگی";
            GrdVw_Pats.Columns[2].HeaderText = "شماره تماس";
            GrdVw_Pats.Columns[3].HeaderText = "کد ملی";
            GrdVw_Pats.Columns[4].HeaderText = "آدرس";
            
            GrdVw_Pats.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrdVw_Pats.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Pats.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            GrdVw_Pats.DefaultCellStyle.SelectionForeColor = Color.White;
            GrdVw_Pats.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            GrdVw_Sec.DataSource = ObjDB.Vw_Sec.ToList();
            GrdVw_Sec.Columns[0].HeaderText = "ردیف";
            GrdVw_Sec.Columns[1].HeaderText = "عنوان بخش";

            GrdVw_Sec.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrdVw_Sec.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Sec.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            GrdVw_Sec.DefaultCellStyle.SelectionForeColor = Color.White;
            GrdVw_Sec.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            GrdVw_Serv.DataSource = ObjDB.Vw_Ser.ToList();
            GrdVw_Serv.Columns[0].HeaderText = "ردیف";
            GrdVw_Serv.Columns[1].HeaderText = "عنوان سرویس";

            GrdVw_Serv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrdVw_Serv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Serv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            GrdVw_Serv.DefaultCellStyle.SelectionForeColor = Color.White;
            GrdVw_Serv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            GrdVw_Reception.DataSource = ObjDB.Vw_Reception.ToList();
            GrdVw_Reception.Columns[0].HeaderText = "نام بیمار";
            GrdVw_Reception.Columns[1].HeaderText = "شماره تماس";
            GrdVw_Reception.Columns[2].HeaderText = "نوع سرویس";
            GrdVw_Reception.Columns[3].HeaderText = "بخش";
            GrdVw_Reception.Columns[4].HeaderText = "نام دکتر مربوطه";
            GrdVw_Reception.Columns["ID"].HeaderText = "ردیف";
            GrdVw_Reception.Columns["VisitTime"].HeaderText = "ساعت نوبت";
            GrdVw_Reception.Columns["VisitDate"].HeaderText = "تاریخ نوبت";
            GrdVw_Reception.Columns["SecTitle"].HeaderText = "بخش";

            GrdVw_Reception.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GrdVw_Reception.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            GrdVw_Reception.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            GrdVw_Reception.DefaultCellStyle.SelectionForeColor = Color.White;

            GrdVw_Reception.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //GrdVw_Reception.Columns[5].Visible = false;
            //GrdVw_Reception.Columns[6].Visible = false;
            //GrdVw_Reception.Columns[7].Visible = false;
            //GrdVw_Reception.Columns[8].Visible = false;
        }

        private void Form_View_All_Tbls_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //var Form = new Form_Main();
            //Form.Closed += (s, args) => this.Close();
            //Form.ShowDialog();
        }

        private void Btn_Bck_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
    }
}
