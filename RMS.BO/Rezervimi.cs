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
    }
}
