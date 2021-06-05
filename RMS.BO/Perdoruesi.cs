using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
    public class Perdoruesi
    {
        public int PerdoruesiID { get; set; }
        public string Username { get; set; }
        public string Passwordi { get; set; }
        public string Emri { get; set; }
        public string Roli { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LUD { get; set; }
        public int LUN { get; set; }
        public int LUB { get; set; }

        public Perdoruesi(string Username, string Passwordi, string Emri, string Roli)
        {
            this.Username = Username;
            this.Passwordi = Passwordi;
            this.Emri = Emri;
            this.Roli = Roli;
        }
    }
}
