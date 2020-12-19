using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SIS
{
    public partial class CourseList : Form
    {
        StudentFormDb db = new StudentFormDb();
        SqlCommand command;
        public CourseList()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseList_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("Select * from tblCourse", db.getConnection);
            dgvCourseList.AllowUserToAddRows = false;
            dgvCourseList.DataSource = getStudentData(command);
         
        }
        public DataTable getStudentData(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this form", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Enter course to search", "Search Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {


                command = new SqlCommand("Select * from tblCourse where course LIKE '%" + txtname.Text + "%'", db.getConnection);
                
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgvCourseList.DataSource = table;
            }
            txtname.Text = "";
        }
    }
}
