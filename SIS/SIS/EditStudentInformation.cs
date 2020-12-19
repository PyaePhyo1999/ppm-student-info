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
using System.IO;

namespace SIS
{
    public partial class EditStudentInformation : Form
    {
        string imageLocation;
        SqlCommand command;
        StudentFormDb db = new StudentFormDb();
        public EditStudentInformation()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char id = e.KeyChar;
            if (!Char.IsControl(id) && !char.IsDigit(id))
            {
                e.Handled = true;
                MessageBox.Show("ID should be number", "ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFirstname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char name = e.KeyChar;
            if (!Char.IsControl(name) && !char.IsLetter(name))
            {
                e.Handled = true;
                MessageBox.Show("Name cannot be number", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char name = e.KeyChar;
            if (!Char.IsControl(name) && !char.IsLetter(name))
            {
                e.Handled = true;
                MessageBox.Show("Name cannot be number", "Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ph = e.KeyChar;
            if (!Char.IsControl(ph) && !char.IsDigit(ph))
            {
                e.Handled = true;
                MessageBox.Show("invalid data", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtId.Text = "";
            txtFirstname.Text = "";
            dtpBirthdate.Text = "";
            txtLastname.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            pictureBoxStd.Image = null;
            
        }
        //data return into student table
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
            command = new SqlCommand("Select * from tblStudent", db.getConnection);
            dgvStd.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgvStd.RowTemplate.Height = 80;
            dgvStd.DataSource = getStudentData(command);
            picCol = (DataGridViewImageColumn)dgvStd.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvStd.AllowUserToAddRows = false;
            lblTotalStudent.Text = "Total Students : " + dgvStd.Rows.Count;
        }

        private void EditStudentInformation_Load(object sender, EventArgs e)
        {
          
            form_grid();
           
        }

        //delete data
        private void button1_Click(object sender, EventArgs e)
        {

            string selectedRow = null;
            if (dgvStd.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvStd.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvStd.Rows[selectedRowIndex];
                selectedRow = Convert.ToString(row.Cells[0].Value);
            }
            if (MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                command = new SqlCommand("Delete from tblStudent where id ='" + selectedRow + "'", db.getConnection);
                db.openConnection();
                command.ExecuteNonQuery();
                form_grid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtId.Text, out id);

            DateTime bdate = dtpBirthdate.Value;
            string gender = "Male";
            if (radFemale.Checked)
            {
                gender = "Female";
            }
            string phone = txtPhone.Text;
            string address = txtAddress.Text;


            //check the age of a student
            int bornYear = dtpBirthdate.Value.Year;
            int thisYear = DateTime.Now.Year;


            //insert data into database 
            if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
            {
                MessageBox.Show("Select cell to update data", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 command = new SqlCommand
            ("Update tblStudent set firstname='" + txtFirstname.Text + "',lastname='" + txtLastname.Text + "',birthdate='" + bdate + "',gender='" + gender + "',phone='" + txtPhone.Text + "',address='" + txtAddress.Text + "' where id='" + id + "'", db.getConnection);

                db.openConnection();
                command.ExecuteNonQuery();

                MessageBox.Show("Updated Data", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_grid();
                clear();

            }
        }

        private void dgvStd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvStd.Rows[e.RowIndex];
                txtId.Text = Convert.ToInt32(row.Cells[0].Value).ToString();
                txtFirstname.Text = row.Cells[1].Value.ToString();
                txtLastname.Text = row.Cells[2].Value.ToString();
                dtpBirthdate.Value = (DateTime)row.Cells[3].Value;
                if (row.Cells[4].Value.ToString() == "Female")
                {
                    radFemale.Checked = true;
                }
                if (row.Cells[4].Value.ToString() == "Male")
                {
                    radmale.Checked = true;
                }

                txtPhone.Text = row.Cells[5].Value.ToString();
                txtAddress.Text = row.Cells[6].Value.ToString();
            }
           
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            btnUploadImage.Visible = true;
            int id = 0;
            int.TryParse(txtId.Text, out id);
            if (pictureBoxStd.Image == null)
            {
                MessageBox.Show("Select image", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtId.Text=="" || !getUpdateId(id))
            {
                MessageBox.Show("Enter valid Id to update photo", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else {
                Byte[] picture = null;
                FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                picture = br.ReadBytes((int)stream.Length);

                command = new SqlCommand
               ("Update tblStudent set picture=@image where id='" +id+"'", db.getConnection);
                command.Parameters.Add(new SqlParameter("@image",picture));
                db.openConnection();
                command.ExecuteNonQuery();

                MessageBox.Show("Updated Data", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_grid();
                clear();
            }
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select image(*.jpg;*.png;*.gif)|*.JPG;*.PNG;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStd.Image = Image.FromFile(openFileDialog.FileName);
                imageLocation = openFileDialog.FileName.ToString();
                pictureBoxStd.ImageLocation = imageLocation;
            }
        } 
        //get Id
        public bool getUpdateId(int id)
        {
           
            command = new SqlCommand("Select * from tblStudent where id='" + txtId.Text + "'", db.getConnection);
            if (getId(id))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool getId(int id)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);
            id = dataSet.Tables[0].Rows.Count;
            if (id > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool getSearchId(int id)
        {

            command = new SqlCommand("Select * from tblStudent where id='" + txtSearch.Text + "'", db.getConnection);
            if (getId(id))
            {
                return true;
            }
            else
            {
               return false;
            }
            

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtSearch.Text, out id);

            if (txtSearch.Text == "")
            {
                MessageBox.Show("Enter id to search", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!getSearchId(id))
            {
                MessageBox.Show("No student found with id", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                command = new SqlCommand("Select * from tblStudent where id ='" + txtSearch.Text + "'", db.getConnection);
             
               
               
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgvStd.DataSource = table;
              
            }
            txtSearch.Text = "";
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this form", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
