namespace SIS
{
    partial class StudentReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentInfoDataSet = new SIS.StudentInfoDataSet();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new SIS.StudentInfoDataSetTableAdapters.tblStudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblStudentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIS.StudentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(747, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // StudentInfoDataSet
            // 
            this.StudentInfoDataSet.DataSetName = "StudentInfoDataSet";
            this.StudentInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tblStudent";
            this.tblStudentBindingSource.DataSource = this.StudentInfoDataSet;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
            // 
            // StudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StudentReport";
            this.Text = "StudentReport";
            this.Load += new System.EventHandler(this.StudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private StudentInfoDataSet StudentInfoDataSet;
        private StudentInfoDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter;
    }
}