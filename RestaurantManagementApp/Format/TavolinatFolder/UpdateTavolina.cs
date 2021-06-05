using RMS.BLL;
using RMS.BO;
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
    public partial class UpdateTavolina : Form
    {
        public UpdateTavolina()
        {
            InitializeComponent();
        }
        TavolinatBLL tavolinatBLL;

        public UpdateTavolina(int TavolinaID)
        {
            tavolinatBLL = new TavolinatBLL();
            Tavolina tavolina = tavolinatBLL.ShowTavolinaDataById(TavolinaID);

            txbTavolinaID.Text = tavolina.TavolinaID.ToString();
            switch (tavolina.Disponueshmeria)
            {
                case 1:
                    txbDisponueshmeria.Text = "E lire";
                    break;
                case 2:
                    txbDisponueshmeria.Text = "E zene";
                    break;
                default:
                    break;
            }

            InitializeComponent();
        }




        
    }
}
