namespace Clinic_App
{
    partial class Form_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Vw_ReceptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Clinic_App.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Vw_ReceptionTableAdapter = new Clinic_App.DataSet1TableAdapters.Vw_ReceptionTableAdapter();
            this.Btn_Cancel = new ns1.BunifuFlatButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.dotsSpinnerWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.DotsSpinnerWaitingBarIndicatorElement();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ReceptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Vw_ReceptionBindingSource
            // 
            this.Vw_ReceptionBindingSource.DataMember = "Vw_Reception";
            this.Vw_ReceptionBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 16;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Vw_ReceptionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clinic_App.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(824, 605);
            this.reportViewer1.TabIndex = 81;
            // 
            // Vw_ReceptionTableAdapter
            // 
            this.Vw_ReceptionTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Activecolor = System.Drawing.Color.IndianRed;
            this.Btn_Cancel.BackColor = System.Drawing.Color.LightPink;
            this.Btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cancel.BorderRadius = 0;
            this.Btn_Cancel.ButtonText = "";
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Cancel.Iconimage = global::Clinic_App.Properties.Resources.Very_Basic_Cancel;
            this.Btn_Cancel.Iconimage_right = null;
            this.Btn_Cancel.Iconimage_right_Selected = null;
            this.Btn_Cancel.Iconimage_Selected = null;
            this.Btn_Cancel.IconMarginLeft = 0;
            this.Btn_Cancel.IconMarginRight = 0;
            this.Btn_Cancel.IconRightVisible = false;
            this.Btn_Cancel.IconRightZoom = 0D;
            this.Btn_Cancel.IconVisible = true;
            this.Btn_Cancel.IconZoom = 60D;
            this.Btn_Cancel.IsTab = false;
            this.Btn_Cancel.Location = new System.Drawing.Point(656, 3);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Normalcolor = System.Drawing.Color.LightPink;
            this.Btn_Cancel.OnHovercolor = System.Drawing.Color.LightCoral;
            this.Btn_Cancel.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btn_Cancel.selected = false;
            this.Btn_Cancel.Size = new System.Drawing.Size(27, 27);
            this.Btn_Cancel.TabIndex = 82;
            this.Btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancel.Textcolor = System.Drawing.Color.White;
            this.Btn_Cancel.TextFont = new System.Drawing.Font("Far.Homa", 10F);
            this.Btn_Cancel.Visible = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.BackColor = System.Drawing.Color.White;
            this.radWaitingBar1.ForeColor = System.Drawing.Color.Black;
            this.radWaitingBar1.Location = new System.Drawing.Point(349, 286);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(110, 108);
            this.radWaitingBar1.TabIndex = 83;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.WaitingIndicators.Add(this.dotsSpinnerWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 100;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.DotsSpinner;
            // 
            // dotsSpinnerWaitingBarIndicatorElement1
            // 
            this.dotsSpinnerWaitingBarIndicatorElement1.AccelerationSpeed = 15D;
            this.dotsSpinnerWaitingBarIndicatorElement1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.dotsSpinnerWaitingBarIndicatorElement1.DrawBackgroundImage = false;
            this.dotsSpinnerWaitingBarIndicatorElement1.DrawImage = false;
            this.dotsSpinnerWaitingBarIndicatorElement1.ElementColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dotsSpinnerWaitingBarIndicatorElement1.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.dotsSpinnerWaitingBarIndicatorElement1.FlipText = false;
            this.dotsSpinnerWaitingBarIndicatorElement1.Name = "dotsSpinnerWaitingBarIndicatorElement1";
            this.dotsSpinnerWaitingBarIndicatorElement1.Text = "Waiting";
            this.dotsSpinnerWaitingBarIndicatorElement1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.dotsSpinnerWaitingBarIndicatorElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.dotsSpinnerWaitingBarIndicatorElement1.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 685);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_Report";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "صدور قبض";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vw_ReceptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource Vw_ReceptionBindingSource;
        private DataSet1TableAdapters.Vw_ReceptionTableAdapter Vw_ReceptionTableAdapter;
        private ns1.BunifuFlatButton Btn_Cancel;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.DotsSpinnerWaitingBarIndicatorElement dotsSpinnerWaitingBarIndicatorElement1;
    }
}