using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ACCOUNTINGNADIM
{
    class WorkingWithADOClass
    {
        #region Tab Enter
        public static void MakeTabEnter(System.Windows.Forms.Form frm)
        {
            //this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            frm.KeyPreview = true;
            frm.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
            frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;


        }
        public static void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                System.Windows.Forms.SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {

            }
        }
        #endregion
        public SqlDataReader search_Total_Balance(string name)
        {
            
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query1 = "select LNo,Address,Mobile from Ledgers where Ledgers ='" +name  + "'";
            SqlCommand comm = new SqlCommand(query1, conn);
            SqlDataReader reader = comm.ExecuteReader();
            return reader;
        }
        public SqlDataReader SearchData_Area_Info_Name(string sl)
        {
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select ID from Groups where ID='" + sl + "'";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();
            return reader;
        }
        public SqlDataReader SearchData_Buyers_suppliers_Note_Sl(string name)
        {
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select Address,Mobile from Ledgers where Name ='" + name + "'";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();
            return reader;
        }
        public SqlDataReader Select_Credit_Debit_transaction(string name)
        {
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query1 = "select SUM(a.Credit) as Total_Credit,SUM(a.Debit) as Total_Debit,SUM(a.Credit) -SUM(a.Debit)  as Balance  from Ledgers L inner join Accounts a  ON a.Ledgers_ID = L.LNo where a.Ledgers_ID ='" + name + "' ";
            SqlCommand comm = new SqlCommand(query1, conn);
            SqlDataReader reader = comm.ExecuteReader();
            return reader;
            //SqlConnection conn = ConnectDB.GetSqlConnection();
            //string query = "select SUM(a.Credit) as Total_Credit,SUM(a.Debit) as Total_Debit,SUM(a.Credit) -SUM(a.Debit)  as Balance  from Ledgers L inner join Accounts a  ON a.Ledgers_ID = L.LNo where a.Ledgers_ID ='" + name + "' ";
            ////SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ////DataTable dt = new DataTable();
            ////ad.Fill(dt);
            ////return dt;
        }
        public SqlDataReader Search_User_Password_LogIn(string uid)
        {
            SqlConnection conn = ConnectDB.GetSqlConnection();
            string query = "select UPassword from Authenticat where UName=N'" + uid + "'";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();
            return reader;
        }

    }


}
