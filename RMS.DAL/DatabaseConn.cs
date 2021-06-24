using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace RMS.DAL
{
    public static class DatabaseConn
    {
		// Fatlum
		//public static string connString = ConfigurationManager.ConnectionStrings["connStrFatlum"].ConnectionString;
		//// Rrezon
		//public static string connString = ConfigurationManager.ConnectionStrings["connStrRrezon"].ConnectionString;
		//// Dibran
		public static string connString = ConfigurationManager.ConnectionStrings["connStrDibran"].ConnectionString;
		//// Shpat
		//public static string connString = ConfigurationManager.ConnectionStrings["yourconnectionstringconfigname"].ConnectionString;

		public static SqlConnection conn;
        public static SqlCommand command;
        public static SqlDataAdapter dataAdapter;
    }
}
