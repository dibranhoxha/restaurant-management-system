using RMS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RMS.BLL
{
    public class StatistikatBLL
    {
        private readonly StatistikatDAL statistikatDAL;

        public StatistikatBLL()
        {
            statistikatDAL = new StatistikatDAL();
        }

        public DataTable GetSherbyesiMMSH()
        {
            return statistikatDAL.GetSherbyesiMMSH();
        }

        public DataTable GetProduktetMTSH()
        {
            return statistikatDAL.GetProduktetMTSH();
        }

    }
}
