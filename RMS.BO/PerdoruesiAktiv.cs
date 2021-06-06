using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
    public static class PerdoruesiAktiv
    {
        public static bool LoggedIn { get; set; }
        public static int Id { get; set; }
        public static string username { get; set; }
        public static string emri { get; set; }
        public static string[] rolet { get; set; }
        public static string roli { get; set; }

        public static bool Autorizohet(string roli)
        {
            if (PerdoruesiAktiv.roli == roli)
            {
                return true;
            }

            return false;
        }

        public static bool Autorizohet(string[] rolet)
        {
            bool autorizimi = !rolet.Except(PerdoruesiAktiv.rolet).Any();
            if (autorizimi)
            {
                return true;
            }

            return false;
        }
    }
}
