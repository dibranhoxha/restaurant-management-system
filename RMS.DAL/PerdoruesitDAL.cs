using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BO;
using System.Data;
using System.Data.SqlClient;

namespace RMS.DAL
{
    public class PerdoruesitDAL
    {
        public string RegjistroPerdorues(Perdoruesi model)
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.command = new SqlCommand("usp_Regjistro", DatabaseConn.conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                DatabaseConn.command.Parameters.AddWithValue("@Username", model.Username);
                DatabaseConn.command.Parameters.AddWithValue("@Emri", model.Passwordi);
                DatabaseConn.command.Parameters.AddWithValue("@Fjalekalimi", model.Emri);
                DatabaseConn.command.Parameters.AddWithValue("@Roli", model.Roli);
                DatabaseConn.command.Parameters.Add("@Mesazhi", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;
                //command.Parameters.AddWithValue("@InsertBy");
                //command.Parameters.AddWithValue("@InsertDate", DateTime.Now);
                //command.Parameters.AddWithValue("@LUD");
                //command.Parameters.AddWithValue("@LUN");
                //command.Parameters.AddWithValue("@LUB");

                DatabaseConn.command.ExecuteNonQuery();
                DatabaseConn.conn.Close();

                return DatabaseConn.command.Parameters["@Mesazhi"].Value.ToString();
            }
        }
        public string[] KyçPerdorues(string username, string fjalekalimi)
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();
                DatabaseConn.command = new SqlCommand("usp_Kyçu", DatabaseConn.conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                DatabaseConn.command.Parameters.AddWithValue("@Username", username);
                DatabaseConn.command.Parameters.AddWithValue("@Fjalekalimi", fjalekalimi);
                DatabaseConn.command.Parameters.Add("@Mesazhi", SqlDbType.NVarChar, 1000).Direction = ParameterDirection.Output;
                DatabaseConn.command.Parameters.Add("@Id", SqlDbType.Int, 50).Direction = ParameterDirection.Output;
                DatabaseConn.command.Parameters.Add("@Emri", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
                DatabaseConn.command.Parameters.Add("@Roli", SqlDbType.NVarChar, 50).Direction = ParameterDirection.Output;
 

                DatabaseConn.command.ExecuteNonQuery();
                DatabaseConn.conn.Close();


                string[] result = { DatabaseConn.command.Parameters["@Mesazhi"].Value.ToString(),
                                    DatabaseConn.command.Parameters["@Id"].Value.ToString(),
                                    DatabaseConn.command.Parameters["@Emri"].Value.ToString(),
                                    DatabaseConn.command.Parameters["@Roli"].Value.ToString()};


                return result;
            }
        }
    }
}
