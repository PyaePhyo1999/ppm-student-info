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
    public partial class StudentReport : Form
    {
        public StudentReport()
        {
            InitializeComponent();
        }

        private void StudentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StudentInfoDataSet.tblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.StudentInfoDataSet.tblStudent);

            this.reportViewer1.RefreshReport();
        }
    }
}
