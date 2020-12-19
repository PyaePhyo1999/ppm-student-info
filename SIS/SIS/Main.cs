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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAddNewStd_Click(object sender, EventArgs e)
        {
            AddNewStudent addNewStudent = new AddNewStudent();
            addNewStudent.Show();
        }

        private void btnStdsList_Click(object sender, EventArgs e)
        {
            StudentLists studentLists = new StudentLists();
            studentLists.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStudentInformation  editStudent = new EditStudentInformation();
            editStudent.Show();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           StudentReport studentReport = new StudentReport();
            studentReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewCourse addNewCourse = new AddNewCourse();
            addNewCourse.Show();
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            CourseList courseList = new CourseList();
            courseList.Show();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            EditCourse editCourse = new EditCourse();
            editCourse.Show();
        }

        private void btnReportCourse_Click(object sender, EventArgs e)
        {
            CourseFormReport courseFormReport = new CourseFormReport();
            courseFormReport.Show();
        }

        private void Course_Click(object sender, EventArgs e)
        {

        }
    }
}
