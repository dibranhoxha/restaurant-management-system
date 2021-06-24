using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BO;
using RMS.DAL;

namespace RMS.BLL
{
	public class RezervimetBLL
	{
		private readonly RezervimetDAL rezervimetDAL;

		public RezervimetBLL()
		{
			rezervimetDAL = new RezervimetDAL();
		}


		public void ShtoRezervim(Rezervimi model)
		{
			rezervimetDAL.ShtoRezervim(model);
		}

		public void FshiRezervim(int rezervimiID)
		{
			rezervimetDAL.FshiRezervim(rezervimiID);
		}

		public DataTable ShowRezervimet()
		{
			return rezervimetDAL.ShowRezervimet();
		}

		public List<Rezervimi> GetRezervimet()
		{
			return rezervimetDAL.GetRezervimet();
		}
	}
}
