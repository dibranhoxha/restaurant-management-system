using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BO;
using RMS.BLL;

namespace RestaurantManagementApp.Format.Tavolinat
{
    public partial class AddTavolina : Form
    {
        public AddTavolina()
        {
            InitializeComponent();
        }
        TavolinatBLL tavolinatBLL = new TavolinatBLL();
        private void btnSubmitTavolina_Click(object sender, EventArgs e)
        {
            Tavolina model = new Tavolina(1,int.Parse(txbNrKarrikave.Text));

            tavolinatBLL.InsertTavoline(model);
        }
    }
}
