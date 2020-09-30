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
    public partial class frmDayBook : Form
    {
        public frmDayBook()
        {
            InitializeComponent();
        }

        private void btnPriview_Click(object sender, EventArgs e)
        {

            if (radioRanged.Checked == true)
            {
                SqlConnection connection = ConnectDB.GetSqlConnection();
                string query = " select  * from Accounts where (Convert(Datetime,Date,103) between Convert(Datetime,'" + From.Text + "',103) and Convert(Datetime,'" + To.Text + "',103)) order by TNo ";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, connection);
                string query1 = "select * from Company";

                SqlDataAdapter ad = new SqlDataAdapter(query1, connection);
               DSDayBook DS = new  DSDayBook();
                //ad.Fill(DS, "Company");
                ad1.Fill(DS, "Account");
                ad.Fill(DS, "Company");
                rptDB cr = new rptDB();
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
            if (radioAll.Checked == true)
            {
                SqlConnection connection = ConnectDB.GetSqlConnection();
                string query = " select * from Accounts order by TNo ";
                SqlDataAdapter ad1 = new SqlDataAdapter(query, connection);
                string query1 = "select * from Company";
                SqlDataAdapter ad = new SqlDataAdapter(query1, connection);
           DSDayBook DS = new  DSDayBook();
                ad.Fill(DS, "Company");
                ad1.Fill(DS, "Account");
              rptD  cr = new rptD();
                cr.SetDataSource(DS);
                cr.SetDataSource(DS);
                Print f2 = new Print();
                f2.Show();
                f2.crystalReportViewer1.ReportSource = cr;
                f2.crystalReportViewer1.Refresh();
            }
        }

        private void frmDayBook_Load(object sender, EventArgs e)
        {
            //radioRanged.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
