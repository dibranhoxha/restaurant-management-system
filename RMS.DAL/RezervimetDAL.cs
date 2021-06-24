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
	public class RezervimetDAL
	{
		public void ShtoRezervim(Rezervimi model)
		{
			using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
			{
				DatabaseConn.conn.Open();
				DatabaseConn.command = new SqlCommand("usp_ShtoRezervim", DatabaseConn.conn)
				{
					CommandType = CommandType.StoredProcedure
				};

				DatabaseConn.command.Parameters.AddWithValue("@TavolinaID", model.TavolinaID);
				DatabaseConn.command.Parameters.AddWithValue("@EmriIKlientit", model.EmriKlientit);
				DatabaseConn.command.Parameters.AddWithValue("@DataERezervimit", model.DataERezervimit);
				//DatabaseConn.command.Parameters.AddWithValue("@InsertBy", model.InsertBy);
				//DatabaseConn.command.Parameters.AddWithValue("@InsertDate", model.InsertDate);
				//DatabaseConn.command.Parameters.AddWithValue("@LUD", model.LUD);
				//DatabaseConn.command.Parameters.AddWithValue("@LUN", model.LUN);
				//DatabaseConn.command.Parameters.AddWithValue("@LUB", model.LUB);

				DatabaseConn.command.ExecuteNonQuery();
				DatabaseConn.conn.Close();
			}
		}

		public void FshiRezervim(int rezervimiID)
		{
			using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
			{
				DatabaseConn.conn.Open();
				DatabaseConn.command = new SqlCommand("usp_FshiRezervim", DatabaseConn.conn)
				{
					CommandType = CommandType.StoredProcedure
				};

				DatabaseConn.command.Parameters.AddWithValue("@RezervimiID", rezervimiID);
				//command.Parameters.AddWithValue("@LUD");
				//command.Parameters.AddWithValue("@LUN");
				//command.Parameters.AddWithValue("@LUB");

				DatabaseConn.command.ExecuteNonQuery();
				DatabaseConn.conn.Close();
			}
		}

		public DataTable ShowRezervimet()
		{
			using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
			{
				DatabaseConn.conn.Open();
				DatabaseConn.dataAdapter = new SqlDataAdapter("usp_KtheRezervimet", DatabaseConn.conn);
				DataTable dataTable = new DataTable();
				DatabaseConn.dataAdapter.Fill(dataTable);


				DatabaseConn.conn.Close();
				return dataTable;
			}
		}

		public List<Rezervimi> GetRezervimet()
		{
			using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
			{
				DatabaseConn.conn.Open();
				DatabaseConn.dataAdapter = new SqlDataAdapter("usp_KtheRezervimet", DatabaseConn.conn);
				DataTable dataTable = new DataTable();
				List<Rezervimi> rezervimet = new List<Rezervimi>();
				DatabaseConn.dataAdapter.Fill(dataTable);
				IEnumerable<DataRow> tavolinat_dbRows = dataTable.AsEnumerable();
				foreach (DataRow row in tavolinat_dbRows)
				{
					Rezervimi rezervimi = new Rezervimi(Convert.ToInt32(row["RezervimiID"].ToString()), Convert.ToInt32(row["TavolinaID"].ToString()), row["EmriIKlientit"].ToString(), Convert.ToDateTime(row["DataERezervimit"]));
					rezervimet.Add(rezervimi);
				}

				DatabaseConn.conn.Close();
				return rezervimet;
			}
		}
	}
}
