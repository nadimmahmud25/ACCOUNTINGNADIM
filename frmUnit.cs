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
    public partial class frmUnit : Form
    {
        SqlDataReader rdr = null;

        public frmUnit()
        {
            InitializeComponent();
        }
        private void RESET()
        {
            txtSI.Text = "";
            txtUnit.Text = "";
            txtSI.Enabled = false;
           // txtSymbol.Text = "";

        }
        private void Unit()
        {
            SqlDataReader myreader = null;
            SqlConnection sqlConn = null;

            cmbUnit.Items.Clear();
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select distinct Unit from Unit";
            SqlCommand comm = new SqlCommand(query, conn);

            myreader = comm.ExecuteReader();
            if (myreader != null)
            {
                while (myreader.Read())
                {

                    cmbUnit.Items.Add(myreader["Unit"]);

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
        private void frmUnit_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Unit();
            RESET();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Symbol = "Symbol";
            if(txtUnit.Text !="")
            {
                SqlConnection scn = ConnectDB.GetSqlConnection();
                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "INSERT INTO Unit values (N'" + txtUnit.Text + "', '" + Symbol + "' )";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Unit Created Successfully !");
                    RESET();
                }
             }
            else
            {
                MessageBox.Show(" required");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Symbol ="Symbol";
          if(txtUnit.Text !="")
            {

                SqlConnection scn = ConnectDB.GetSqlConnection();
                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "UPDATE Unit set Unit=N'" + txtUnit.Text.Replace("'", "`") + "',Symbol= '"+Symbol+"' where ID='" + txtSI.Text + "'";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Item Updated Successfully !");
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
            string query = "select * from Unit  where  Unit like '"+cmbUnit.Text+"'";
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSI.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUnit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           // txtSymbol.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtS.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if(txtUnit.Text !="")
           
           {    
               SqlConnection scn = ConnectDB.GetSqlConnection();

                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "DELETE Unit   where ID='" + txtSI.Text + "'";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Unit Delete Successfully !");
                    RESET();
                }
            }
            else
            {
                MessageBox.Show(" required");
            }

        }

        private void txtUnit_Validating(object sender, CancelEventArgs e)
        {
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select Unit from Unit where Unit=@find";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 500, "Unit"));
            command.Parameters["@find"].Value = txtUnit.Text;
            rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("Unit Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnit.Text = "";
                txtUnit.Focus();


                if ((rdr != null))
                {
                    rdr.Close();
                }
                return;
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
              txtSI.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUnit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
          //  txtSymbol.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtS.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        }
    }

