using RMS.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DAL
{
    public class ProduktetDAL
    {
        public void InsertProduct(Produkti model)
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.command = new SqlCommand("usp_InsertProduct", DatabaseConn.conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                DatabaseConn.command.Parameters.AddWithValue("@Emri", model.Emri);
                //DatabaseConn.command.Parameters.AddWithValue("@Madhesia", model.Madhesia);
                DatabaseConn.command.Parameters.AddWithValue("@Cmimi", model.Cmimi);
                //DatabaseConn.command.Parameters.AddWithValue("@InsertBy", 1);
                //DatabaseConn.command.Parameters.AddWithValue("@InsertDate", DateTime.Now);
                //command.Parameters.AddWithValue("@LUD");
                //command.Parameters.AddWithValue("@LUN");
                //command.Parameters.AddWithValue("@LUB");

                DatabaseConn.command.ExecuteNonQuery();
                DatabaseConn.conn.Close();
                ShowProduktet();
            }
        }

        public DataTable ShowProduktet()
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_GetProduktet", DatabaseConn.conn);
                DataTable dataTable = new DataTable();
                DatabaseConn.dataAdapter.Fill(dataTable);


                DatabaseConn.conn.Close();
                return dataTable;
            }
        }
        public List<Produkti> GetProduktet()
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_GetProduktet", DatabaseConn.conn);
                DataTable dataTable = new DataTable();
                List<Produkti> produktet = new List<Produkti>();
                DatabaseConn.dataAdapter.Fill(dataTable);
                IEnumerable<DataRow> produktet_dbrows = dataTable.AsEnumerable();
                foreach (DataRow row in produktet_dbrows)
                {
                    Produkti produkti = new Produkti(Convert.ToInt32(row["ProduktiID"]),row["Emri"].ToString(), Convert.ToDecimal(row["Cmimi"]));
                    produktet.Add(produkti);
                }

                DatabaseConn.conn.Close();
                return produktet;
            }
        }
    }
}
