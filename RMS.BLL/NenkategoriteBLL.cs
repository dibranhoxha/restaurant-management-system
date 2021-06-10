using System.Collections.Generic;
using RMS.BO;
using RMS.DAL;

namespace RMS.BLL
{
    public class NenkategoriteBLL
    {
        private readonly NenkategoriteDAL nenkategoriteDAL;

        public NenkategoriteBLL()
        {
            nenkategoriteDAL = new NenkategoriteDAL();
        }
        public List<Nenkategoria> KtheNenkategoriNgaKategoria(int KategoriId)
        {
            return nenkategoriteDAL.KtheNenkategoriNgaKategoria(KategoriId);
        }
    }
}
