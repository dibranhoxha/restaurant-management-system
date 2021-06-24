using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
	public class Rezervimi
	{
		public int RezervimiID { get; set; }
		public int TavolinaID { get; set; }
		public string EmriKlientit { get; set; }
		public DateTime DataERezervimit { get; set; }
		public int InsertBy { get; set; }
		public DateTime InsertDate { get; set; }
		public DateTime LUD { get; set; }
		public int LUN { get; set; }
		public int LUB { get; set; }

		public Rezervimi() { }

		public Rezervimi(int tavolinaID, string emriKlientit, DateTime dataERezervimit)
		{
			TavolinaID = tavolinaID;
			EmriKlientit = emriKlientit;
			DataERezervimit = dataERezervimit;
		}
		public Rezervimi(int rezervimiID, int tavolinaID, string emriKlientit, DateTime dataERezervimit)
		{
			RezervimiID = rezervimiID;
			TavolinaID = tavolinaID;
			EmriKlientit = emriKlientit;
			DataERezervimit = dataERezervimit;
		}
	}
}
