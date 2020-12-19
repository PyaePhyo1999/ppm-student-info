using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SIS
{
    public partial class AddNewStudent : Form
    {
        
        string imgLocation="";
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select image(*.jpg;*.png;*.gif)|*.JPG;*.PNG;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureboxStd.Image = Image.FromFile(openFileDialog.FileName);
                imgLocation = openFileDialog.FileName.ToString();
                pictureboxStd.ImageLocation = imgLocation;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
           
            StudentFormDb db = new StudentFormDb();
            int id = 0;
            int.TryParse(txtstdId.Text,out id);
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            DateTime bdate = dtpNewStd.Value;
            string gender = "Male";
            if (radFemale.Checked)
            {
                gender = "Female";
            }
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            if (pictureboxStd.Image == null)
            {
                MessageBox.Show("Emply Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                Byte[] picture = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                picture = br.ReadBytes((int)stream.Length);

                //check the age of a student
                int bornYear = dtpNewStd.Value.Year;
                int thisYear = DateTime.Now.Year;


                //insert data into database 
                if (thisYear - bornYear < 10 || thisYear - bornYear > 100)
                {
                    MessageBox.Show("Age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (duplicateData(id))
                    {
                        MessageBox.Show("Duplicated Id", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if ((checkEmptyData()))
                    {

                        SqlCommand command = new SqlCommand("Insert into tblStudent(id,firstname,lastname,birthdate,gender,phone,address,picture)values('" + id + "','" + fname + "','" +lname+"','"+bdate+"','"+gender+"','"+phone+"','"+address+"',@image)", db.getConnection);
                        command.Parameters.Add(new SqlParameter("@image",picture));
                        db.openConnection();
                        command.ExecuteNonQuery();
                  
                        MessageBox.Show("New student added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Emply Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        //check emply data
        public bool checkEmptyData()
        {
            if (txtstdId.Text == "" ||
                txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtPhone.Text == "" ||
                txtAddress.Text == "" ||
                pictureboxStd.Image == null
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
            txtstdId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpNewStd.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            pictureboxStd.Image = null;
        }
        //Duplicate id
        public bool duplicateData(int id)
        {
            StudentFormDb db = new StudentFormDb();
            SqlCommand command = new SqlCommand("Select * from tblStudent where id='" + txtstdId.Text + "'", db.getConnection);
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

        private void txtstdId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char id = e.KeyChar;
            if (!Char.IsControl(id) && !char.IsDigit(id))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this form", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtstdId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
