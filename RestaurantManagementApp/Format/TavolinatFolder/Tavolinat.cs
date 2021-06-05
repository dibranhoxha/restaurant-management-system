using RMS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementApp.Format.Tavolinat
{
    public partial class Tavolinat : Form
    {
        public Tavolinat()
        {
            InitializeComponent();
        }

        TavolinatBLL tavolinatBLL = new TavolinatBLL();

        private void btnAddTavolina_Click(object sender, EventArgs e)
        {
            AddTavolina addTavolinaForm = new AddTavolina();
            addTavolinaForm.Show();
        }

        private void Tavolinat_Load(object sender, EventArgs e)
        {
            DataTable list = tavolinatBLL.ShowTavolinat();
            dgvTavolinat.DataSource = list;
        }
    }
}
