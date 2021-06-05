using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
    public class ListaEProdukteve
    {
        public int ListaEProdukteveID { get; set; }
        public int PorosiaID { get; set; }
        public int ProduktiID { get; set; }
        public int SherbyesiID { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LUD { get; set; }
        public int LUN { get; set; }
        public int LUB { get; set; }
    }
}
