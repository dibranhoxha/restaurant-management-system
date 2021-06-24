using RMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BO;
using System.Data;

namespace RMS.BLL
{
    public class ProduktetBLL
    {
        private readonly ProduktetDAL produktetDAL;

        public ProduktetBLL()
        {
            produktetDAL = new ProduktetDAL();
        }

        public void InsertProdukt(Produkti model)
        {
            produktetDAL.InsertProduct(model);
        }

        public void FshiProdukt(String emri)
        {
            produktetDAL.FshiProdukt(emri);
        }

        public DataTable ShowProduktet()
        {
            return produktetDAL.ShowProduktet();
        }
        public List<Produkti> KtheProduktet(int kategori)
        {
            return produktetDAL.KtheProduktet(kategori);
        }

        public List<Produkti> KtheProduktet(string[] nenkategori)
        {
            return produktetDAL.KtheProduktet(nenkategori);
        }

        public List<Produkti> KtheTeGjithaProduktet()
        {
            return produktetDAL.KtheTeGjithaProduktet();
        }
    }
}
