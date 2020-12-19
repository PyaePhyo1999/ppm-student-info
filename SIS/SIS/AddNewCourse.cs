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
    public partial class AddNewCourse : Form
    {
        StudentFormDb db = new StudentFormDb();
        SqlCommand command;

        public AddNewCourse()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this form", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string courseNum = txtCourseNumber.Text;
            string course = txtCourse.Text;
            string teacher = txtteacher.Text;
            string description = txtdescription.Text;

                
                     if ((checkEmptyData()))
                    {

                         command = new SqlCommand
                    ("Insert into tblCourse(number,course,teacher,description)values('" + courseNum + "','" + course + "','" +teacher + "','" + description + "')", db.getConnection);
                       
                        db.openConnection();
                        command.ExecuteNonQuery();

                        MessageBox.Show("New Course added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Emply Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        public bool checkEmptyData()
        {
            if (txtCourseNumber.Text == "" ||
                txtCourse.Text == "" ||
                txtteacher.Text == "" ||
                txtdescription.Text == "" 
            
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //clear data
        public void clear()
        {
            txtCourseNumber.Text = "";
            txtCourse.Text = "";
            txtteacher.Text = "";
            txtdescription.Text = "";
           
        }

        private void AddNewCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
