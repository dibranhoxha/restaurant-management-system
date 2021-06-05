using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementApp.Format.Produktet;
using RestaurantManagementApp.Format.Tavolinat;
using RestaurantManagementApp.Format.Porosite;
using PerdoruesiAktiv = RMS.BO.PerdoruesiAktiv;
using Porosi = RMS.BO.Porosia;

namespace RestaurantManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblEmri.Text = PerdoruesiAktiv.emri;
            lblRoli.Text = PerdoruesiAktiv.roli;
        }

        private void btnStatistikat_Click(object sender, EventArgs e)
        {
            Statistikat statistikatForm = new Statistikat();
            statistikatForm.Show();
        }

        private void btnProduktet_Click(object sender, EventArgs e)
        {
            Produktet produktetForm = new Produktet();
            produktetForm.Show();
        }

        private void btnTavolinat_Click(object sender, EventArgs e)
        {
            Tavolinat tavolinatForm = new Tavolinat();
            tavolinatForm.Show();
        }

        private void btnPorosia_Click_1(object sender, EventArgs e)
        {
            Porosia porosiaForm = new Porosia();
            porosiaForm.Show();
        }

        private void bttnRegjistro_Click(object sender, EventArgs e)
        {
            if (PerdoruesiAktiv.Autorizohet("Administrator"))
            {
                Format.Perdoruesit.RegjistrimiForm Regjistrimi = new Format.Perdoruesit.RegjistrimiForm();
                Regjistrimi.Show();
            }
        }
    }
}
