using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace ACCOUNTINGNADIM
{
    public partial class frmItemSL : Form
    {
        public frmItemSL()
        {
            InitializeComponent();
        }

        private void Items()
        {
            SqlDataReader myreader = null;
            SqlConnection sqlConn = null;

            cmbItem.Items.Clear();
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select distinct Item from Item";
            SqlCommand comm = new SqlCommand(query, conn);

            myreader = comm.ExecuteReader();
            if (myreader != null)
            {
                while (myreader.Read())
                {

                    cmbItem.Items.Add(myreader["Item"]);

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

        private void Group()
        {
            SqlDataReader myreader = null;
            SqlConnection sqlConn = null;

            cmbGroups.Text = "";
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
        private void frmItemSL_Load(object sender, EventArgs e)
        {
            Group();
            Items();
        }

        private void cmbGroups_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlDataReader myreader = null;
            SqlConnection sqlConn = null;


            cmbName.Text = "";
            cmbName.Items.Clear();
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select distinct Ledgers from Ledgers where Groups like N'" + cmbGroups.Text + "'";
            SqlCommand comm = new SqlCommand(query, conn);

            myreader = comm.ExecuteReader();
            if (myreader != null)
            {
                while (myreader.Read())
                {

                    cmbName.Items.Add(myreader["Ledgers"]);

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

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader myreader = null;
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select Address from Ledgers where Ledgers ='" + cmbName.Text + "'";
            SqlCommand comm = new SqlCommand(query, conn);
            myreader = comm.ExecuteReader();
            while (myreader.Read())
            {
                txtA.Text = myreader.GetString(0).ToString();
                //txtM.Text = myreader.GetString(1).ToString();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPriview_Click(object sender, EventArgs e)
        {
            if (radioAll.Checked == true)
            {
                SqlConnection connection = ConnectDB.GetSqlConnection();
                string query = " select a.Groups,L.Ledgers,L.Address,L.Mobile,a.Credit,a.Debit,a.Narration,a.Item,a.DQty,a.WQty,a.Unit,a.Date  from Accounts a inner join Ledgers L on a.Ledgers_ID=L.LNo where a.Groups = N'" + cmbGroups.Text + "' and a.Ledgers_ID= N'" + txtLI.Text + "' and a.Item = N'" + cmbItem.Text + "' order by a.Date";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, connection);
                string query1 = "select * from Company";

                SqlDataAdapter ad = new SqlDataAdapter(query1, connection);
                DSItemSL DS = new DSItemSL();
                ad.Fill(DS, "Company");
                ad1.Fill(DS, "Accounts");
                rptItemSL cr = new rptItemSL();
                //cr.SetDataSource(DS);
                cr.SetDataSource(DS);
                Print f2 = new Print();
                f2.Show();
                f2.crystalReportViewer1.ReportSource = cr;
                f2.crystalReportViewer1.Refresh();
            }
            if (radioRanged.Checked == true)
            {

                SqlConnection connection = ConnectDB.GetSqlConnection();
                string query = " select a.Groups,L.Ledgers,L.Address,L.Mobile,a.Credit,a.Debit,a.Narration,a.Item,a.DQty,a.WQty,a.Unit,a.Date  from Accounts a inner join Ledgers L on a.Ledgers_ID=L.LNo where a.Groups = N'" + cmbGroups.Text + "' and a.Ledgers_ID= N'" + txtLI.Text + "' and a.Item = N'" + cmbItem.Text + "' and (Convert(Datetime,a.Date,103) between Convert(Datetime,'" + From.Text + "',103) and Convert(Datetime,'" + To.Text + "',103)) order by a.Date ";    
                SqlDataAdapter ad1 = new SqlDataAdapter(query, connection);
                string query1 = "select * from Company";

                SqlDataAdapter ad = new SqlDataAdapter(query1, connection);
                DSItemSL DS = new DSItemSL();
                ad.Fill(DS, "Company");
                ad1.Fill(DS, "Accounts");
                rptItemSLs cr = new rptItemSLs();
                //cr.SetDataSource(DS);
                cr.SetDataSource(DS);
                Print f2 = new Print();
                f2.Show();
                ParameterFieldDefinitions crParameterFieldDefinitions;

                ParameterFieldDefinition crParameterFieldDefinition1;
                ParameterFieldDefinition crParameterFieldDefinition2;
                //ParameterFieldDefinition crParameterFieldDefinition3;
                //ParameterFieldDefinition crParameterFieldDefinition4;

                ParameterValues crParameterValues1 = new ParameterValues();
                ParameterValues crParameterValues2 = new ParameterValues();
                //ParameterValues crParameterValues3 = new ParameterValues();
                //ParameterValues crParameterValues4 = new ParameterValues();

                ParameterDiscreteValue crParameterDiscreteValue1 = new ParameterDiscreteValue();
                ParameterDiscreteValue crParameterDiscreteValue2 = new ParameterDiscreteValue();
                //ParameterDiscreteValue crParameterDiscreteValue3 = new ParameterDiscreteValue();
                //ParameterDiscreteValue crParameterDiscreteValue4 = new ParameterDiscreteValue();

                crParameterDiscreteValue1.Value = From.Text;
                crParameterDiscreteValue2.Value = To.Text;
                //crParameterDiscreteValue3.Value = txtDueAmount.Text;
                //crParameterDiscreteValue4.Value = txtPaid.Text;

                crParameterFieldDefinitions = cr.DataDefinition.ParameterFields;

                crParameterFieldDefinition1 = crParameterFieldDefinitions["From"];
                crParameterFieldDefinition2 = crParameterFieldDefinitions["To"];
                //crParameterFieldDefinition3 = crParameterFieldDefinitions["Due Amount"];
                //crParameterFieldDefinition4 = crParameterFieldDefinitions["Paid"];

                crParameterValues1 = crParameterFieldDefinition1.CurrentValues;
                crParameterValues2 = crParameterFieldDefinition2.CurrentValues;
                //crParameterValues3 = crParameterFieldDefinition3.CurrentValues;
                //crParameterValues4 = crParameterFieldDefinition4.CurrentValues;

                crParameterValues1.Add(crParameterDiscreteValue1);
                crParameterValues2.Add(crParameterDiscreteValue2);
                //crParameterValues3.Add(crParameterDiscreteValue3);
                //crParameterValues4.Add(crParameterDiscreteValue4);

                crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1);
                crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2);

                f2.crystalReportViewer1.ReportSource = cr;
                f2.crystalReportViewer1.Refresh();
               
            }
        }

        private void cmbName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //SqlDataReader myreader = null;
            //SqlConnection conn = ConnectDB.GetSqlConnection();
            //string query = "select Address from Ledgers where Ledgers ='" + cmbName.Text + "'";
            //SqlCommand comm = new SqlCommand(query, conn);
            //myreader = comm.ExecuteReader();
            //while (myreader.Read())
            //{
            //    txtA.Text = myreader.GetString(0).ToString();
            //    //txtM.Text = myreader.GetString(1).ToString();

            //}
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader myreader = null;
            SqlConnection sqlConn = null;


            cmbName.Text = "";
            cmbName.Items.Clear();
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select distinct Ledgers from Ledgers where Groups like N'" + cmbGroups.Text + "'";
            SqlCommand comm = new SqlCommand(query, conn);

            myreader = comm.ExecuteReader();
            if (myreader != null)
            {
                while (myreader.Read())
                {

                    cmbName.Items.Add(myreader["Ledgers"]);

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

        private void cmbName_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlDataReader myreader = null;
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select LNo,Address from Ledgers where Ledgers ='" + cmbName.Text + "'";
            SqlCommand comm = new SqlCommand(query, conn);
            myreader = comm.ExecuteReader();
            while (myreader.Read())
            {
                txtLI.Text = myreader.GetString(0).ToString();
                txtA.Text = myreader.GetString(1).ToString();
                // txtM.Text = myreader.GetString(1).ToString();
                //Item_Amount.Text = myreader.GetDouble(1).ToString();

            }
        }
    }
}
