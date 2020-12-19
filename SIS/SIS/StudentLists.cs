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
    public partial class StudentLists : Form
    {
        SqlCommand command;
        StudentFormDb db = new StudentFormDb();
        public StudentLists()
        {
            InitializeComponent();
        }
       
        private void StudentLists_Load(object sender, EventArgs e)
        {
            
            //add data to datagridview
            command = new SqlCommand("Select * from tblStudent",db.getConnection);
            dgvStudentLists.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvStudentLists.RowTemplate.Height = 80;
            dgvStudentLists.DataSource =getStudentData(command);
            picCol = (DataGridViewImageColumn)dgvStudentLists.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvStudentLists.AllowUserToAddRows = false;
           
        }

        private void dgvStudentLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable getStudentData(SqlCommand command)
        {
            command.Connection = db.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;


        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Enter name to search", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else{


                command = new SqlCommand("Select * from tblStudent where firstname LIKE '%" + txtname.Text + "%'", db.getConnection);
               
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgvStudentLists.DataSource = table;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this form", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }

         }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
