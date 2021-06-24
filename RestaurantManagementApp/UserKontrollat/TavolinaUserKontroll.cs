using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementApp.Format.Porosite;

namespace RestaurantManagementApp.UserKontrollat
{
	public partial class TavolinaUserKontroll : UserControl
	{
		public int NrTavolines { get; set; }
		public int Disponueshmeria { get; set; }
		public int NrKarrikave { get; set; }

		public TavolinaUserKontroll(int nrTavolines, int nrKarrikave, int disponueshmeria)
		{
			InitializeComponent();
			NrTavolines = nrTavolines;
			NrKarrikave = nrKarrikave;
			Disponueshmeria = disponueshmeria;
		}


		private void TavolinaUserKontroll_Load(object sender, EventArgs e)
		{
			lblNrTavolines.Text = NrTavolines.ToString();
			//lblNrUleseve.Text = NrKarrikave.ToString() + " ulese";
			switch (Disponueshmeria)
			{
				case 0: paneliDisponueshmeria.BackColor = Color.Red; break;
				case 1: paneliDisponueshmeria.BackColor = Color.Green; break;
			}
		}

		private void btnImageTavolina_Click(object sender, EventArgs e)
		{
			PorosiaForm porosiaForm = new PorosiaForm(NrTavolines);
			porosiaForm.Show();
		}
	}
}
