using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
	public class Tavolina
	{
		public int TavolinaID { get; set; }
		public int Disponueshmeria { get; set; }
		public int NrKarrikave { get; set; }
		public int InsertBy { get; set; }
		public DateTime InsertDate { get; set; }
		public DateTime LUD { get; set; }
		public int LUN { get; set; }
		public int LUB { get; set; }

		public Tavolina() { }

		public Tavolina(int disponueshmeria, int nrKarrikave)
		{
			Disponueshmeria = disponueshmeria;
			NrKarrikave = nrKarrikave;
		}
		public Tavolina(int tavolinaID, int disponueshmeria, int nrKarrikave)
		{
			TavolinaID = tavolinaID;
			Disponueshmeria = disponueshmeria;
			NrKarrikave = nrKarrikave;
		}
	}
}
