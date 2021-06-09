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
    public class PorosiaDAL
    {
        public int ShtoPorosi(Porosia model)
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.command = new SqlCommand("usp_ShtoPorosi", DatabaseConn.conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                //DatabaseConn.command.Parameters.AddWithValue("@TavolinaID", model.TavolinaID);
                //DatabaseConn.command.Parameters.AddWithValue("@SherbyesiID", model.SherbyesiID);
                DatabaseConn.command.Parameters.AddWithValue("@DataEPorosise", model.DataEPorosise);
                DatabaseConn.command.Parameters.Add("@PorosiaID", SqlDbType.Int).Direction = ParameterDirection.Output;
                //command.Parameters.AddWithValue("@InsertBy");
                //command.Parameters.AddWithValue("@InsertDate", DateTime.Now);
                //command.Parameters.AddWithValue("@LUD");
                //command.Parameters.AddWithValue("@LUN");
                //command.Parameters.AddWithValue("@LUB");

                DatabaseConn.command.ExecuteNonQuery();
                DatabaseConn.conn.Close();

                return int.Parse(DatabaseConn.command.Parameters["@PorosiaID"].Value.ToString());
            }
        }
        public void ShtoProduktePerPorosi(Porosia model, int ProduktiId, int Sasia)
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.command = new SqlCommand("usp_ShtoProduktePerPorosi", DatabaseConn.conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                DatabaseConn.command.Parameters.AddWithValue("@PorosiaID", model.PorosiaID);
                DatabaseConn.command.Parameters.AddWithValue("@ProduktiId", ProduktiId);
                DatabaseConn.command.Parameters.AddWithValue("@Sasia", Sasia);
                //command.Parameters.AddWithValue("@InsertBy");
                //command.Parameters.AddWithValue("@InsertDate", DateTime.Now);
                //command.Parameters.AddWithValue("@LUD");
                //command.Parameters.AddWithValue("@LUN");
                //command.Parameters.AddWithValue("@LUB");

                DatabaseConn.command.ExecuteNonQuery();
                DatabaseConn.conn.Close();

            }
        }
    }
}
