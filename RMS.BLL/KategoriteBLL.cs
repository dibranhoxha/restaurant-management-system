using System.Collections.Generic;
using RMS.DAL;
using RMS.BO;

namespace RMS.BLL
{
    public class KategoriteBLL
    {
        private readonly KategoriteDAL kategoriteDAL;

        public KategoriteBLL()
        {
            kategoriteDAL = new KategoriteDAL();
        }

        public List<Kategoria> KtheKategorite()
        {
            return kategoriteDAL.KtheKategorite();
        }
        public List<Kategoria> KtheNenkategorite()
        {
            return kategoriteDAL.KtheKategorite();
        }
    }
}
