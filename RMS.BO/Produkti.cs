using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
    public class Produkti
    {
        public int ProduktID { get; set; }
        public string Emri { get; set; }
        public string Madhesia { get; set; }
        public decimal Cmimi { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LUD { get; set; }
        public int LUN { get; set; }
        public int LUB { get; set; }


        public Produkti(string emri, decimal cmimi)
        {
            this.Emri = emri;
            this.Cmimi = cmimi;
        }
        public Produkti(int produktID, string emri, decimal cmimi)
        {
            this.ProduktID = produktID;
            this.Emri = emri;
            this.Cmimi = cmimi;
        }
    }
}
