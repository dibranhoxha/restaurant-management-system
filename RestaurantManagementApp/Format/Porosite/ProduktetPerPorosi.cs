using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BLL;

namespace RestaurantManagementApp.Format.Porosite
{
	public partial class ProduktetPerPorosi : Form
	{
		public ProduktetPerPorosi()
		{
			InitializeComponent();
		}

		private void ProduktetPerPorosi_Load(object sender, EventArgs e)
		{
			ProduktetBLL produktetBLL= new ProduktetBLL();
			clbProduktet.DataSource = produktetBLL.ShowProduktet();
			clbProduktet.DisplayMember = "Emri";
			clbProduktet.ValueMember = "ProduktiID";
		}
	}
}
