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
    public partial class EditCourse : Form
    {
        SqlCommand command;
        StudentFormDb db = new StudentFormDb();
        public EditCourse()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtnumber.Text = "";
            txtCourse.Text = "";
            txtTeacher.Text = "";
            txtDescription.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this form", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedRow = null;
            if (dgvCourseList.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvCourseList.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvCourseList.Rows[selectedRowIndex];
                selectedRow = Convert.ToString(row.Cells[0].Value);
            }
            if (MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                command = new SqlCommand("Delete from tblCourse where number ='" + selectedRow + "'", db.getConnection);
                db.openConnection();
                command.ExecuteNonQuery();
                form_grid();
            }
        }

        private void EditCourse_Load(object sender, EventArgs e)
        {
            form_grid();
        }
        public DataTable getStudentData(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }
        public void form_grid()
        {

            //add data to datagridview
            command = new SqlCommand("Select * from tblCourse", db.getConnection);
            dgvCourseList.AllowUserToAddRows = false;

            dgvCourseList.DataSource = getStudentData(command);
            lblTotalStudent.Text = "Total Course : " + dgvCourseList.Rows.Count;

        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string courseNum = txtnumber.Text;
            string course = txtCourse.Text;
            string teacher = txtTeacher.Text;
            string description = txtDescription.Text;


            if ((checkEmptyData()))
            {

                command = new SqlCommand
             ("Update tblCourse set course='" + course + "',teacher='" + teacher + "',description='" + description + "' where number='" + courseNum + "'", db.getConnection);

                

                db.openConnection();
                command.ExecuteNonQuery();

                MessageBox.Show(" Course updated", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_grid();
                clear();
            }
            else
            {
                MessageBox.Show("Emply Fields", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checkEmptyData()
        {
            if (txtnumber.Text == "" ||
                txtCourse.Text == "" ||
                txtTeacher.Text == "" ||
                txtDescription.Text == ""

                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        private void dgvCourseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCourseList.Rows[e.RowIndex];
                txtnumber.Text = row.Cells[0].Value.ToString();
                txtCourse.Text = row.Cells[1].Value.ToString();
                txtTeacher.Text = row.Cells[2].Value.ToString();
                txtDescription.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Enter course number to search", "Search Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {


                command = new SqlCommand("Select * from tblCourse where number LIKE '%" + txtSearch.Text + "%'", db.getConnection);
                
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgvCourseList.DataSource = table;
            }
            txtSearch.Text = "";
        }
    }
}