using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
    public class Nenkategoria
    {
        public int Id { get; set; }
        public string Emri { get; set; }
        public int KategoriId { get; set; }

        public Nenkategoria(int Id, string Emri, int KategoriId)
        {
            this.Id = Id;
            this.Emri = Emri;
            this.KategoriId = KategoriId;
        }
    }
}
