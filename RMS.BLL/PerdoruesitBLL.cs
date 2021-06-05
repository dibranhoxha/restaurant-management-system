using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BO;
using RMS.DAL;
using System.Data;
using System.Diagnostics;


namespace RMS.BLL
{
    public class PerdoruesitBLL
    {
        private readonly PerdoruesitDAL perdoruesitDAL;

        public PerdoruesitBLL()
        {
            perdoruesitDAL = new PerdoruesitDAL();
        }

        public string RegjistroPerdorues(Perdoruesi model)
        {
            return perdoruesitDAL.RegjistroPerdorues(model);
        }
        public string KyçPerdorues(string username, string fjalekalimi)
        {
            string[] result = perdoruesitDAL.KyçPerdorues(username, fjalekalimi);
            
            if (result[0] == "Logged")
            {
                PerdoruesiAktiv.Id = Convert.ToInt32(result[1]);
                PerdoruesiAktiv.emri = result[2];
                PerdoruesiAktiv.roli = result[3];
                PerdoruesiAktiv.LoggedIn = true;
                return String.Format("Jeni kycur me perdoruesin:{0}", PerdoruesiAktiv.emri);
            }
            
            return "Gabim! Rishikoni fushat: Username dhe Fjalekalimi";

        }
    }
}
