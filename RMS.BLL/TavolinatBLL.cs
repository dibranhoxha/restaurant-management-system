using RMS.BO;
using RMS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BLL
{
    public class TavolinatBLL
    {
        private readonly TavolinatDAL tavolinatDAL;
        
        public TavolinatBLL()
        {
            tavolinatDAL = new TavolinatDAL();
        }


        public void InsertTavoline(Tavolina model)
        {
            tavolinatDAL.InsertTavoline(model);
        }

        public DataTable ShowTavolinat()
        {
            return tavolinatDAL.ShowTavolinat();
        }

    }
}
