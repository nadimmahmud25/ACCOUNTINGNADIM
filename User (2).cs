using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ACCOUNTINGNADIM
{
    public partial class User : Form
    {
        SqlDataReader rdr = null;

        public User()
        {
            InitializeComponent();
        }

        private void RESET()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtName.Text = "";

            btnDelete.Enabled = false;
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text && txtName.Text != "" && txtPassword.Text != "")
            {
                SqlConnection scn = ConnectDB.GetSqlConnection();
                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "INSERT INTO Authenticat values ( '" + txtName.Text + "','" + txtPassword.Text + "')";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("User Created Successfully !");
                    RESET();
                }
            }
            else
            {
                MessageBox.Show("Password did not match.");
            }
        }


        private void txtUName_Validating(object sender, CancelEventArgs e)
        {
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select UName from Authenticat where UName=@find";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 250, "UName"));
            command.Parameters["@find"].Value = txtName.Text;
            rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("User Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = "";
                txtName.Focus();


                if ((rdr != null))
                {
                    rdr.Close();
                }
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want To Update ?", "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtName.Text != "")
                {
                    SqlConnection conn = ConnectDB.GetSqlConnection();
                    string query = "Update Authenticat set UName='" + txtName.Text + "' ,UPassword='" + txtPassword.Text + "' where ID= '" + txtSI.Text + "'";
                    SqlCommand command = new SqlCommand(query, conn);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("User Updated Successfully !!");
                        RESET();


                    }
                }
                else
                {
                    MessageBox.Show("Check Required Field !!");
                }

            }
        }

     
        
        

        private void btnSearch_Click(object sender, EventArgs e)
        {


            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select * from Authenticat ";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSI.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           //txtConfirmPassword.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Want To Delete ?", "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtName.Text != "")
                {
                    SqlConnection conn = ConnectDB.GetSqlConnection();
                    string query = "DELETE Authenticat where ID='" + txtSI.Text + "' ";
                    SqlCommand command = new SqlCommand(query, conn);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("User Deleted Successfully !!");
                        RESET();
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnSave.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Check Required Field !!");
                }
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            RESET();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select UName from Authenticat where UName=@find";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 250, "UName"));
            command.Parameters["@find"].Value = txtName.Text;
            rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("User Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = "";
                txtName.Focus();


                if ((rdr != null))
                {
                    rdr.Close();
                }
                return;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSI_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
