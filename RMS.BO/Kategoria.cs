using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
    public class Kategoria
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public List<Nenkategoria> Nenkategorite { get; set; }

        public Kategoria(int Id, string Emri, List<Nenkategoria> Nenkategoria)
        {
            this.Id = Id;
            this.Emri = Emri;
            this.Nenkategorite = Nenkategoria;
        }
    }
}
