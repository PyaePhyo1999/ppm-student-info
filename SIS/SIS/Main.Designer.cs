namespace SIS
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Student = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnStdsList = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNewStd = new System.Windows.Forms.Button();
            this.Course = new System.Windows.Forms.TabPage();
            this.btnViewCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnReportCourse = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.TabPage();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.Student.SuspendLayout();
            this.Course.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Student);
            this.tabControl1.Controls.Add(this.Course);
            this.tabControl1.Controls.Add(this.Score);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 454);
            this.tabControl1.TabIndex = 2;
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.DodgerBlue;
            this.Student.Controls.Add(this.btnReport);
            this.Student.Controls.Add(this.btnStdsList);
            this.Student.Controls.Add(this.btnEdit);
            this.Student.Controls.Add(this.btnAddNewStd);
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(4, 33);
            this.Student.Name = "Student";
            this.Student.Padding = new System.Windows.Forms.Padding(3);
            this.Student.Size = new System.Drawing.Size(791, 417);
            this.Student.TabIndex = 0;
            this.Student.Text = "Student";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DimGray;
            this.btnReport.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(286, 245);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(185, 37);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnStdsList
            // 
            this.btnStdsList.BackColor = System.Drawing.Color.Silver;
            this.btnStdsList.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdsList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStdsList.Location = new System.Drawing.Point(286, 128);
            this.btnStdsList.Name = "btnStdsList";
            this.btnStdsList.Size = new System.Drawing.Size(185, 34);
            this.btnStdsList.TabIndex = 2;
            this.btnStdsList.Text = "Students List";
            this.btnStdsList.UseVisualStyleBackColor = false;
            this.btnStdsList.Click += new System.EventHandler(this.btnStdsList_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkGray;
            this.btnEdit.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(286, 188);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(185, 34);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit/Remove";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNewStd
            // 
            this.btnAddNewStd.BackColor = System.Drawing.Color.LightGray;
            this.btnAddNewStd.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewStd.Location = new System.Drawing.Point(286, 70);
            this.btnAddNewStd.Name = "btnAddNewStd";
            this.btnAddNewStd.Size = new System.Drawing.Size(185, 34);
            this.btnAddNewStd.TabIndex = 0;
            this.btnAddNewStd.Text = "Add New Student";
            this.btnAddNewStd.UseVisualStyleBackColor = false;
            this.btnAddNewStd.Click += new System.EventHandler(this.btnAddNewStd_Click);
            // 
            // Course
            // 
            this.Course.BackColor = System.Drawing.Color.Azure;
            this.Course.Controls.Add(this.btnViewCourse);
            this.Course.Controls.Add(this.btnEditCourse);
            this.Course.Controls.Add(this.btnReportCourse);
            this.Course.Controls.Add(this.btnAddNew);
            this.Course.Location = new System.Drawing.Point(4, 33);
            this.Course.Name = "Course";
            this.Course.Padding = new System.Windows.Forms.Padding(3);
            this.Course.Size = new System.Drawing.Size(791, 417);
            this.Course.TabIndex = 1;
            this.Course.Text = "Course";
            this.Course.Click += new System.EventHandler(this.Course_Click);
            // 
            // btnViewCourse
            // 
            this.btnViewCourse.BackColor = System.Drawing.Color.Silver;
            this.btnViewCourse.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCourse.Location = new System.Drawing.Point(284, 135);
            this.btnViewCourse.Name = "btnViewCourse";
            this.btnViewCourse.Size = new System.Drawing.Size(185, 34);
            this.btnViewCourse.TabIndex = 4;
            this.btnViewCourse.Text = "View Course";
            this.btnViewCourse.UseVisualStyleBackColor = false;
            this.btnViewCourse.Click += new System.EventHandler(this.btnViewCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditCourse.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditCourse.Location = new System.Drawing.Point(284, 188);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(185, 34);
            this.btnEditCourse.TabIndex = 3;
            this.btnEditCourse.Text = "Edit Course";
            this.btnEditCourse.UseVisualStyleBackColor = false;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnReportCourse
            // 
            this.btnReportCourse.BackColor = System.Drawing.Color.DimGray;
            this.btnReportCourse.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportCourse.Location = new System.Drawing.Point(284, 240);
            this.btnReportCourse.Name = "btnReportCourse";
            this.btnReportCourse.Size = new System.Drawing.Size(185, 34);
            this.btnReportCourse.TabIndex = 2;
            this.btnReportCourse.Text = "Report Course Data";
            this.btnReportCourse.UseVisualStyleBackColor = false;
            this.btnReportCourse.Click += new System.EventHandler(this.btnReportCourse_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.LightGray;
            this.btnAddNew.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(284, 84);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(185, 34);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add Course";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.DodgerBlue;
            this.Score.Location = new System.Drawing.Point(4, 33);
            this.Score.Name = "Score";
            this.Score.Padding = new System.Windows.Forms.Padding(3);
            this.Score.Size = new System.Drawing.Size(791, 417);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.Student.ResumeLayout(false);
            this.Course.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Student;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnStdsList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNewStd;
        private System.Windows.Forms.TabPage Course;
        private System.Windows.Forms.TabPage Score;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnReportCourse;
        private System.Windows.Forms.Button btnAddNew;
    }
}