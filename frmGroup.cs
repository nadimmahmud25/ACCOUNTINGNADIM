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
    public partial class frmGroup : Form
    {
        SqlDataReader rdr = null;
        public frmGroup()
        {
            InitializeComponent();
        }
        private void RESET()
        {
            txtName.Focus();
            SI.Enabled = true;
            txtName.Text = "";
            txtU.Text = "Running";
            txtName.Enabled = true;
            txtU.Enabled = true;
            // txtS.Text = "";

            btnSave.Enabled = true;
        }
        private void Groups()
        {
            SqlDataReader myreader = null;
            SqlConnection sqlConn = null;

            cmbGroups.Items.Clear();
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select distinct Groups from Groups";
            SqlCommand comm = new SqlCommand(query, conn);

            myreader = comm.ExecuteReader();
            if (myreader != null)
            {
                while (myreader.Read())
                {

                    cmbGroups.Items.Add(myreader["Groups"]);

                }
            }

            {
                if (myreader != null)
                    myreader.Close();
                if (sqlConn != null)
                {
                    if (sqlConn.State == ConnectionState.Open)
                        sqlConn.Close();
                }
            }
        }
        private void frmGroup_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            WorkingWithADOClass.MakeTabEnter(this);
            Groups();
            RESET();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlConnection scn = ConnectDB.GetSqlConnection();
                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "INSERT INTO Groups values ( N'" + txtName.Text.Replace("'", "`") + "',N'" + txtU.Text.Replace("'", "`") + "')";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Groups Created Successfully !");
                    RESET();
                }
            }
            else
            {
                MessageBox.Show("Check Required Field !!");
            }
               
            
             
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string S = "s";
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection scn = ConnectDB.GetSqlConnection();
                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "UPDATE Groups set Groups=N'" + txtName.Text.Replace("'", "`") + "',Under='"+S+"'  where ID='" + SI.Text + "'";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Groups Updated Successfully !");
                    RESET();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection scn = ConnectDB.GetSqlConnection();

                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "DELETE Groups   where ID='" + SI.Text + "'";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Groups Delete Successfully !");
                    SqlCommand scm_delete = new SqlCommand();
                    scm_delete.Connection = scn;
                    scm_delete.CommandText = "DELETE Accounts where Groups_ID='" + SI.Text + "'";
                    scm_delete.ExecuteNonQuery();
                    RESET();
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            RESET();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = ConnectDB.GetSqlConnection();
            string query = "select * from Groups";
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SI.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtU.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtS.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void cmbGroups_KeyUp(object sender, KeyEventArgs e)
        {
            if (radioname.Checked == true)
            {
                SqlConnection connection = ConnectDB.GetSqlConnection();
                string query = "select Groups from Groups where Groups like '" + cmbGroups.Text + "%'";
                SqlDataAdapter ad = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SI.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtU.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtS.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            //SqlConnection conn = ConnectDB.GetSqlConnection();
            //string query = "select Groups from Groups where Groups=@find";
            //SqlCommand command = new SqlCommand(query, conn);
            //command.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 500, "Groups"));
            //command.Parameters["@find"].Value = txtName.Text;
            //rdr = command.ExecuteReader();

            //if (rdr.Read())
            //{
            //    MessageBox.Show("Groups Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //txtName.Text = "";
            //    txtName.Focus();


            //    if ((rdr != null))
            //    {
            //        rdr.Close();
            //    }
            //    return;
            //}
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                btnSave.PerformClick();

            }
         
        }
    }
}
