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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picboxUserLogin.Image = Image.FromFile("../../Images/UserLogin.png");

           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StudentFormDb db = new StudentFormDb();
          
            SqlCommand command = new SqlCommand("Select * from tblLogin where username=@username and password = @password",db.getConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;
        
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
