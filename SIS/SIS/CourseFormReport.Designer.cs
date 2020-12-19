namespace SIS
{
    partial class CourseFormReport
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
            this.StudentInfoDataSet1 = new SIS.StudentInfoDataSet1();
            this.tblCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCourseTableAdapter = new SIS.StudentInfoDataSet1TableAdapters.tblCourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblCourseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SIS.CourseFormReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(388, 369);
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
            // StudentInfoDataSet1
            // 
            this.StudentInfoDataSet1.DataSetName = "StudentInfoDataSet1";
            this.StudentInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCourseBindingSource
            // 
            this.tblCourseBindingSource.DataMember = "tblCourse";
            this.tblCourseBindingSource.DataSource = this.StudentInfoDataSet1;
            // 
            // tblCourseTableAdapter
            // 
            this.tblCourseTableAdapter.ClearBeforeFill = true;
            // 
            // CourseFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 369);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CourseFormReport";
            this.Text = "CourseFormReport";
            this.Load += new System.EventHandler(this.CourseFormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInfoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCourseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private StudentInfoDataSet StudentInfoDataSet;
        private StudentInfoDataSetTableAdapters.tblStudentTableAdapter tblStudentTableAdapter;
        private System.Windows.Forms.BindingSource tblCourseBindingSource;
        private StudentInfoDataSet1 StudentInfoDataSet1;
        private StudentInfoDataSet1TableAdapters.tblCourseTableAdapter tblCourseTableAdapter;
    }
}