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
    public partial class frmBalanceSheet : Form
    {
        public frmBalanceSheet()
        {
            InitializeComponent();
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
    
        private void frmBalanceSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnPriview_Click(object sender, EventArgs e)
        {
            if (radioAll.Checked == true)
            {
                SqlConnection connection = ConnectDB.GetSqlConnection();
                string query = "select a.Groups,SUM(a.Credit)-SUM(a.Debit) as Balance,L.Ledgers,L.Address,L.Mobile from Accounts a inner join Ledgers L on a.Ledgers_ID=L.LNo where a.Date <= Convert(DateTime,'" + To.Text + "',103) group by a.Groups,L.Groups,L.Ledgers,L.Address,L.Mobile  HAVING SUM(a.Credit)-SUM(a.Debit) <>0 order by L.Ledgers";
                //string query = "select a.Groups,SUM(a.Credit)-SUM(a.Debit) as Balance,L.Groups,L.Ledgers,L.Address,L.Mobile from Accounts a inner join Ledgers L on a.Ledgers=L.Ledgers where  a.Date <= Convert(DateTime,'" + To.Text + "',103) group by   a.Groups,L.Groups,L.Ledgers,L.Address,L.Mobile  HAVING SUM(a.Credit)-SUM(a.Debit) <>0 order by L.Ledgers";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, connection);
                string query1 = "select * from Company";

                SqlDataAdapter ad = new SqlDataAdapter(query1, connection);
                DSBalanceSheet DS = new DSBalanceSheet();
                ad1.Fill(DS, "Accounts");
                ad.Fill(DS, "Company");
               
                rptBalanceSheet cr = new rptBalanceSheet ();
                //cr.SetDataSource(DS);
                cr.SetDataSource(DS);
                Print f2 = new Print();
                f2.Show();
                ParameterFieldDefinitions crParameterFieldDefinitions;

                ParameterFieldDefinition crParameterFieldDefinition1;
                //ParameterFieldDefinition crParameterFieldDefinition2;
                //ParameterFieldDefinition crParameterFieldDefinition3;
                //ParameterFieldDefinition crParameterFieldDefinition4;

                ParameterValues crParameterValues1 = new ParameterValues();
                //ParameterValues crParameterValues2 = new ParameterValues();
                //ParameterValues crParameterValues3 = new ParameterValues();
                //ParameterValues crParameterValues4 = new ParameterValues();

                ParameterDiscreteValue crParameterDiscreteValue1 = new ParameterDiscreteValue();
                //ParameterDiscreteValue crParameterDiscreteValue2 = new ParameterDiscreteValue();
                //ParameterDiscreteValue crParameterDiscreteValue3 = new ParameterDiscreteValue();
                //ParameterDiscreteValue crParameterDiscreteValue4 = new ParameterDiscreteValue();

                crParameterDiscreteValue1.Value = To.Text;
                //crParameterDiscreteValue2.Value = To.Text;
                //crParameterDiscreteValue3.Value = txtDueAmount.Text;
                //crParameterDiscreteValue4.Value = txtPaid.Text;

                crParameterFieldDefinitions = cr.DataDefinition.ParameterFields;

                crParameterFieldDefinition1 = crParameterFieldDefinitions["UpTo"];
                //crParameterFieldDefinition2 = crParameterFieldDefinitions["UpTo"];
                //crParameterFieldDefinition3 = crParameterFieldDefinitions["Due Amount"];
                //crParameterFieldDefinition4 = crParameterFieldDefinitions["Paid"];

                //crParameterValues1 = crParameterFieldDefinition1.CurrentValues;
                //crParameterValues2 = crParameterFieldDefinition2.CurrentValues;
                //crParameterValues3 = crParameterFieldDefinition3.CurrentValues;
                //crParameterValues4 = crParameterFieldDefinition4.CurrentValues;

                crParameterValues1.Add(crParameterDiscreteValue1);
                //crParameterValues2.Add(crParameterDiscreteValue2);
                //crParameterValues3.Add(crParameterDiscreteValue3);
                //crParameterValues4.Add(crParameterDiscreteValue4);

                crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1);
                //   crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2);
                f2.crystalReportViewer1.ReportSource = cr;
                f2.crystalReportViewer1.Refresh();
            }
            if (radioRanged.Checked == true)
            {
                SqlConnection connection = ConnectDB.GetSqlConnection();
                // string query = "select Groups,Ledgers,Address,Mobile,SUM(Credit)-SUM(Debit) as Balance  from Accounts where Date <= Convert(DateTime,'" + To.Text + "',103) group by Groups,Ledgers,Address,Mobile";
                string query = "select a.Groups,SUM(a.Credit)-SUM(a.Debit) as Balance,L.Ledgers,L.Address,L.Mobile from Accounts a inner join Ledgers L on a.Ledgers_ID=L.LNo  where a.Groups='" + cmbGroups.Text + "' and  a.Date <= Convert(DateTime,'" + To.Text + "',103) group by   a.Groups,L.Groups,L.Ledgers,L.Address,L.Mobile  HAVING SUM(a.Credit)-SUM(a.Debit) <>0 order by L.Ledgers";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, connection);
                string query1 = "select * from Company";

                SqlDataAdapter ad = new SqlDataAdapter(query1, connection);
                DSBalanceSheet DS = new DSBalanceSheet();
                ad1.Fill(DS, "Accounts");
                ad.Fill(DS, "Company");

                rptBalanceSheet cr = new rptBalanceSheet();
                //cr.SetDataSource(DS);
                cr.SetDataSource(DS);
                Print f2 = new Print();
                f2.Show();
                ParameterFieldDefinitions crParameterFieldDefinitions;

                ParameterFieldDefinition crParameterFieldDefinition1;
                //ParameterFieldDefinition crParameterFieldDefinition2;
                //ParameterFieldDefinition crParameterFieldDefinition3;
                //ParameterFieldDefinition crParameterFieldDefinition4;

                ParameterValues crParameterValues1 = new ParameterValues();
                //ParameterValues crParameterValues2 = new ParameterValues();
                //ParameterValues crParameterValues3 = new ParameterValues();
                //ParameterValues crParameterValues4 = new ParameterValues();

                ParameterDiscreteValue crParameterDiscreteValue1 = new ParameterDiscreteValue();
                //ParameterDiscreteValue crParameterDiscreteValue2 = new ParameterDiscreteValue();
                //ParameterDiscreteValue crParameterDiscreteValue3 = new ParameterDiscreteValue();
                //ParameterDiscreteValue crParameterDiscreteValue4 = new ParameterDiscreteValue();

                crParameterDiscreteValue1.Value = To.Text;
                //crParameterDiscreteValue2.Value = To.Text;
                //crParameterDiscreteValue3.Value = txtDueAmount.Text;
                //crParameterDiscreteValue4.Value = txtPaid.Text;

                crParameterFieldDefinitions = cr.DataDefinition.ParameterFields;

                crParameterFieldDefinition1 = crParameterFieldDefinitions["UpTo"];
                //crParameterFieldDefinition2 = crParameterFieldDefinitions["UpTo"];
                //crParameterFieldDefinition3 = crParameterFieldDefinitions["Due Amount"];
                //crParameterFieldDefinition4 = crParameterFieldDefinitions["Paid"];

                //crParameterValues1 = crParameterFieldDefinition1.CurrentValues;
                //crParameterValues2 = crParameterFieldDefinition2.CurrentValues;
                //crParameterValues3 = crParameterFieldDefinition3.CurrentValues;
                //crParameterValues4 = crParameterFieldDefinition4.CurrentValues;

                crParameterValues1.Add(crParameterDiscreteValue1);
                //crParameterValues2.Add(crParameterDiscreteValue2);
                //crParameterValues3.Add(crParameterDiscreteValue3);
                //crParameterValues4.Add(crParameterDiscreteValue4);

                crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1);
                //   crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2);
                f2.crystalReportViewer1.ReportSource = cr;
                f2.crystalReportViewer1.Refresh();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBalanceSheet_Load(object sender, EventArgs e)
        {
            Group();
           // G();
        }

        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
