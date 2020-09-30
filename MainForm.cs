using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCOUNTINGNADIM
{
    public partial class MainForm : Form
    {
        //string imgLoc = "";
        //private int childFormNumber = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            //childForm.Show();
        }
        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmGroup g = new frmGroup();
            g.ShowDialog();
        }

        private void ledgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLedgers l = new frmLedgers();
            l.ShowDialog();
        }

     
        private void accountingVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransaction t = new frmTransaction();
            t.ShowDialog();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalanceSheet b = new frmBalanceSheet();
            b.ShowDialog();
        }

        private void dayBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDayBook d = new frmDayBook();
            d.ShowDialog();
        }

        private void ledgerBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLedgerBook l = new frmLedgerBook();
            l.ShowDialog();
        }

        private void trialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrialBalance t = new frmTrialBalance();
            t.ShowDialog();
        }

        private void userSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.ShowDialog();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany c = new frmCompany();
            c.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string sql = "select CName,CAddress,COwner,CMobile,CEmail from Company";
            //  if (con.State != ConnectionState.Open)
            SqlConnection connection = ConnectDB.GetSqlConnection();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                //SI.Text = reader[0].ToString();
           label5.Text = reader[0].ToString();
                label7.Text = reader[1].ToString();
               label8.Text = reader[2].ToString();
                label9.Text = reader[3].ToString();
               // txtPhone.Text = reader[5].ToString();
                label10.Text = reader[4].ToString();
               // txtWebsite.Text = reader[7].ToString();
            }
            else
            {
                MessageBox.Show("No accounted created earlier. Please make your profile");
            }
                    
        }

        private void stoksItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem i = new frmItem();
            i.ShowDialog();
             
        }

        private void unitOfMeasureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnit u = new frmUnit();
            u.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransaction t = new frmTransaction();
           
            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGroup g = new frmGroup();
            //g.MdiParent = this;
            g.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLedgers l = new frmLedgers();
            l.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCompany c = new frmCompany();
            c.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmItem i = new frmItem();
            i.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUnit u = new frmUnit();
            u.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
          //Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

     

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmTransaction t = new frmTransaction();
            t.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmGroup g = new frmGroup();
            g.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmLedgers l = new frmLedgers();
            l.ShowDialog();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            frmItem i = new frmItem();
            i.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmUnit u = new frmUnit();
            u.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            User u = new User();
            u.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmCompany c = new frmCompany();
            c.ShowDialog();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
