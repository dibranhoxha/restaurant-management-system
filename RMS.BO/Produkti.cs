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
        public int KategoriID { get; set; }
        public string Emri { get; set; }
        public decimal Cmimi { get; set; }
        
        public string Foto { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LUD { get; set; }
        public int LUN { get; set; }
        public int LUB { get; set; }

        public Produkti(int produktID, int kategoriID, string emri, decimal cmimi, string foto)
        {
            this.ProduktID = produktID;
            this.KategoriID = kategoriID;
            this.Emri = emri;
            this.Cmimi = cmimi;
            this.Foto = foto;
        }
    }
}
