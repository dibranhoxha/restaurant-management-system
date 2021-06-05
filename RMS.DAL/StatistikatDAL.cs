using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL
{
    public class StatistikatDAL
    {
        public DataTable GetSherbyesiMMSH()
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_SherbyesiMMSH", DatabaseConn.conn);
                DataTable dataTable = new DataTable();
                DatabaseConn.dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable GetProduktetMTSH()
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_ProduktetMTSH", DatabaseConn.conn);
                DataTable dataTable = new DataTable();
                DatabaseConn.dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }
    }
}
