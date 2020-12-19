using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS
{
    public partial class CourseFormReport : Form
    {
        public CourseFormReport()
        {
            InitializeComponent();
        }

        private void CourseFormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StudentInfoDataSet1.tblCourse' table. You can move, or remove it, as needed.
            this.tblCourseTableAdapter.Fill(this.StudentInfoDataSet1.tblCourse);
            // TODO: This line of code loads data into the 'StudentInfoDataSet.tblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.StudentInfoDataSet.tblStudent);

            this.reportViewer1.RefreshReport();
        }
    }
}
