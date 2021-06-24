using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementApp.UserKontrollat
{
	public partial class RezervimiUserKontroll : UserControl
	{
		public int RezervimiID { get; set; }
		public int Tavolina { get; set; }
		public string EmriKlientit { get; set; }
		public DateTime DataERezervimit { get; set; }
		public RezervimiUserKontroll()
		{
			InitializeComponent();
		}

		public RezervimiUserKontroll(int rezervimiID,int tavolina, string emriKlientit, DateTime dataERezervimit)
		{
			InitializeComponent();
			Tavolina = tavolina;
			EmriKlientit = emriKlientit;
			DataERezervimit = dataERezervimit;
			RezervimiID = rezervimiID;
		}

		private void RezervimiUserKontroll_Load(object sender, EventArgs e)
		{
			lblRezervimi.Text = "R: " + RezervimiID;
			lblTavolina.Text = "Tavolina: " + Tavolina;
			lblEmriKlientit.Text = EmriKlientit;
			lblDataERezervimit.Text = DataERezervimit.ToString();
		}
	}
}
