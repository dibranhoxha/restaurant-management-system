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
                //DatabaseConn.command.Parameters.AddWithValue("@LUD", model.LUD);
                //DatabaseConn.command.Parameters.AddWithValue("@LUN", model.LUN);
                //DatabaseConn.command.Parameters.AddWithValue("@LUB", model.LUB);

                DatabaseConn.command.ExecuteNonQuery();
                DatabaseConn.conn.Close();
            }
        }

        public void FshiTavoline(int tavolinaID)
		{
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.command = new SqlCommand("usp_FshiTavoline", DatabaseConn.conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                DatabaseConn.command.Parameters.AddWithValue("@TavolinaID", tavolinaID );
                //DatabaseConn.command.Parameters.AddWithValue("@LUD", model.LUD);
                //DatabaseConn.command.Parameters.AddWithValue("@LUN", model.LUN);
                //DatabaseConn.command.Parameters.AddWithValue("@LUB", model.LUB);

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

        public List<Tavolina> GetTavolinat()
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_GetTavolinat", DatabaseConn.conn);
                DataTable dataTable = new DataTable();
                List<Tavolina> tavolinat = new List<Tavolina>();
                DatabaseConn.dataAdapter.Fill(dataTable);
                IEnumerable<DataRow> tavolinat_dbrows = dataTable.AsEnumerable();
                foreach (DataRow row in tavolinat_dbrows)
                {
                    Tavolina tavolina = new Tavolina(Convert.ToInt32(row["TavolinaID"].ToString()), Convert.ToInt32(row["Disponueshmeria"].ToString()), Convert.ToInt32(row["NrKarrikave"]));
                    tavolinat.Add(tavolina);
                }

                DatabaseConn.conn.Close();
                return tavolinat;
            }
        }
    }
}
