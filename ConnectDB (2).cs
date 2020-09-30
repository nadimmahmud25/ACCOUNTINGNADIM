using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACCOUNTINGNADIM
{
    class ConnectDB
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["NADIMACCOUNTING"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

    }
}
