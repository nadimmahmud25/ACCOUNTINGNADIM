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
    public partial class frmItem : Form
    {
        SqlDataReader rdr = null;
        public frmItem()
        {
            InitializeComponent();
        }
        private void RESET()
        {
            SI.Text = "";
            txtName.Text = "";
            SI.Enabled = false;
            Transaction_ID();
            Group();
        }
        private void Group()
        {
            SqlDataReader myreader = null;
            SqlConnection sqlConn = null;

            cmbGroups.Text = "";
            cmbGroups.Items.Clear();
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select distinct Item from Item";
            SqlCommand comm = new SqlCommand(query, conn);

            myreader = comm.ExecuteReader();
            if (myreader != null)
            {
                while (myreader.Read())
                {

                    cmbGroups.Items.Add(myreader["Item"]);

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
        private void Transaction_ID()
        {

            SqlConnection connection = ConnectDB.GetSqlConnection();
            string sqlQuery = "SELECT MAX(ID) from Item";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            {
                try
                {
                    SI.Text = "Item-" + (reader.GetInt64(0) + 1).ToString();
                }
                catch
                {
                    SI.Text = "Item-1";
                }
            }
        }
        private void frmItem_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
          //  Transaction_ID();
            RESET();
           // Group();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                SqlConnection scn = ConnectDB.GetSqlConnection();
                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "INSERT INTO Item values (N'" + SI.Text + "', N'" + txtName.Text + "' )";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Item Created Successfully !");
                    RESET();
                }
            }
            else
            {
                MessageBox.Show(" required");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection connection = ConnectDB.GetSqlConnection();
            string query = "select * from Item ";
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cmbGroups_KeyUp(object sender, KeyEventArgs e)
        {
            if (radioname.Checked == true)
            {
                SqlConnection connection = ConnectDB.GetSqlConnection();
                string query = "select INo,Item from Items where Item like '" + cmbGroups.Text + "'";
                SqlDataAdapter ad = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection scn = ConnectDB.GetSqlConnection();
                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "UPDATE Item set Item=N'" + txtName.Text.Replace("'", "`") + "'  where INo='" + SI.Text + "'";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Item Updated Successfully !");
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
                scm.CommandText = "DELETE Item   where INo='" + SI.Text + "'";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Item Delete Successfully !");
                    RESET();
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SI.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtU.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtS.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select Item from Item where Item=@find";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 500, "Item"));
            command.Parameters["@find"].Value = txtName.Text;
            rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("Item Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Text = "";
                txtName.Focus();


                if ((rdr != null))
                {
                    rdr.Close();
                }
                return;
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SI.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtU.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtS.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void frmItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                btnSave.PerformClick();

            }
         
        }
    }
}
