using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BO;

namespace RMS.DAL
{
    public class TavolinatDAL
    {
        public void InsertTavoline(Tavolina model)
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.command = new SqlCommand("usp_InsertTavoline", DatabaseConn.conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                DatabaseConn.command.Parameters.AddWithValue("@Disponueshmeria", model.Disponueshmeria);
                DatabaseConn.command.Parameters.AddWithValue("@NrKarrikave", model.NrKarrikave);
                
                //command.Parameters.AddWithValue("@LUD");
                //command.Parameters.AddWithValue("@LUN");
                //command.Parameters.AddWithValue("@LUB");

                DatabaseConn.command.ExecuteNonQuery();
                DatabaseConn.conn.Close();
            }
        }

        public DataTable ShowTavolinat()
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_GetTavolinat", DatabaseConn.conn);
                DataTable dataTable = new DataTable();
                DatabaseConn.dataAdapter.Fill(dataTable);


                DatabaseConn.conn.Close();
                return dataTable;
            }
        }
    }
}
