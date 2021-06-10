using RMS.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace RMS.DAL
{
    public class KategoriteDAL
    {
        public List<Kategoria> KtheKategorite()
        {
            using (DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.conn.Open();

                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_KtheKategorite", DatabaseConn.conn);
                DatabaseConn.dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                List<Kategoria> kategorite = new List<Kategoria>();
                DatabaseConn.dataAdapter.Fill(dataTable);
                IEnumerable<DataRow> produktet_dbrows = dataTable.AsEnumerable();
                foreach (DataRow row in produktet_dbrows)
                {
                    NenkategoriteDAL nenkategoriteDAL = new NenkategoriteDAL();
                    List<Nenkategoria> nenkategorite = nenkategoriteDAL.KtheNenkategoriNgaKategoria(Convert.ToInt32(row["Id"]));
                    Kategoria kategoria = new Kategoria(Convert.ToInt32(row["Id"]), row["Emri"].ToString(), nenkategorite);
                    kategorite.Add(kategoria);
                }

                DatabaseConn.conn.Close();
                return kategorite;
            }
        }
    }
}
