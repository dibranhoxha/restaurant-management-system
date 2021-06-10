using RMS.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace RMS.DAL
{
    public class NenkategoriteDAL
    {
        public List<Nenkategoria> KtheNenkategoriNgaKategoria(int kategori)
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();

                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_KtheNenkategoriNgaKategoria", DatabaseConn.conn);
                DatabaseConn.dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DatabaseConn.dataAdapter.SelectCommand.Parameters.AddWithValue("@KategoriId", kategori);
                DataTable dataTable = new DataTable();
                List<Nenkategoria> nenkategorite = new List<Nenkategoria>();
                DatabaseConn.dataAdapter.Fill(dataTable);
                IEnumerable<DataRow> produktet_dbrows = dataTable.AsEnumerable();
                foreach (DataRow row in produktet_dbrows)
                {
                    Nenkategoria nenkategoria = new Nenkategoria(Convert.ToInt32(row["Id"]), row["Emri"].ToString(), Convert.ToInt32(row["KategoriId"]));
                    nenkategorite.Add(nenkategoria);
                }

                DatabaseConn.conn.Close();
                return nenkategorite;
            }
        }
    }
}
