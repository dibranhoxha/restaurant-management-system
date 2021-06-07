using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.DAL;
using RMS.BO;


namespace RMS.BLL
{
    public class PorosiaBLL
    {
        private readonly PorosiaDAL porosiaDAL;

        public PorosiaBLL()
        {
            porosiaDAL = new PorosiaDAL();
        }

        public int ShtoPorosi(Porosia model)
        {
            return porosiaDAL.ShtoPorosi(model);
        }
    }
}
