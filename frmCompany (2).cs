using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ACCOUNTINGNADIM
{
    public partial class frmCompany : Form
    {
       
        string imgLoc = "";
        public frmCompany()
        {
            InitializeComponent();
        }
        private void companyProfile()
        {
            try
            {
                string sql = "select ID,CName,CAddress,COwner,CMobile,CPhone,CEmail,CWebsite from Company";
              //  if (con.State != ConnectionState.Open)
                 SqlConnection connection = ConnectDB.GetSqlConnection();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        SI.Text = reader[0].ToString();
                        txtName.Text = reader[1].ToString();
                        txtCompanyAddress.Text = reader[2].ToString();
                        txtOwner.Text = reader[3].ToString();
                        txtMobile.Text = reader[4].ToString();
                        txtPhone.Text = reader[5].ToString();
                        txtEmail.Text = reader[6].ToString();
                        txtWebsite.Text = reader[7].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No accounted created earlier. Please make your profile");
                    }
                    
            }
            catch
            {
                MessageBox.Show("You have no conpany profile. Please insert your company profile");
                // txtCompanyName.Focus();
            }
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Some Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection scn = ConnectDB.GetSqlConnection();
                //Insert Query for Vouchar
                SqlCommand scm = new SqlCommand();
                scm.Connection = scn;
                scm.CommandText = "UPDATE Company set CName=N'" + txtName.Text.Replace("'", "`") + "',CAddress=N'" + txtCompanyAddress.Text.Replace("'", "`") + "',COwner=N'" + txtOwner.Text.Replace("'", "`") + "',CMobile=N'" + txtMobile.Text.Replace("'", "`") + "',CPhone=N'" + txtPhone.Text.Replace("'", "`") + "',CEmail=N'" + txtEmail.Text.Replace("'", "`") + "',CWebsite=N'" + txtWebsite.Text.Replace("'", "`") + "' where ID='" + SI.Text + "'";
                if (scm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Company Updated Successfully !");
                    //RESET();
                }
            }
          
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtWebsite_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmGroups_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            WorkingWithADOClass.MakeTabEnter(this);
          companyProfile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = ConnectDB.GetSqlConnection();
            //string query = "select * from Company";
            //SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //dataGridView1.DataSource = dt;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var _with1 = openFileDialog1;

            //    _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
            //    _with1.FilterIndex = 4;
            //    //Reset the file name
            //    openFileDialog1.FileName = "";

            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtWebsite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                System.Windows.Forms.SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {

            }
        }

        private void frmCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                btnSave.PerformClick();

            }
         
        }
    }
    }

