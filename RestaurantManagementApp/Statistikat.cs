using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BLL;
using System.Windows.Forms;

namespace RestaurantManagementApp
{
    public partial class Statistikat : Form
    {
        public Statistikat()
        {
            InitializeComponent();
        }
        StatistikatBLL statistikatBLL = new StatistikatBLL();

        private void btnSherbyesiMMSH_Click(object sender, EventArgs e)
        {   
            DataTable list = statistikatBLL.GetSherbyesiMMSH();
            dgvStatistikat.DataSource = list;
        }

        private void btnProduktetMTSH_Click(object sender, EventArgs e)
        {
            DataTable list = statistikatBLL.GetProduktetMTSH();
            dgvStatistikat.DataSource = list;
        }
    }
}
