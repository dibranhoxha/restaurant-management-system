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
using RMS.BO;

namespace RestaurantManagementApp.Format.Produktet
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        ProduktetBLL produktetBLL = new ProduktetBLL();

        private void btnSubmitProduct_Click(object sender, EventArgs e)
        {
            Produkti produkti = new Produkti(0,0,txbEmriProdukt.Text, decimal.Parse(txbCmimiProdukt.Text),"test");
            produktetBLL.InsertProdukt(produkti);
            Close();

        }
    }
}
