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

namespace RestaurantManagementApp.Format.Produktet
{
    public partial class Produktet : Form
    {
        public Produktet()
        {
            InitializeComponent();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct();
            addForm.Show();
            addForm.FormClosing += (thesender, thee) =>
            {
                Produktet_Load(null,null);
            };
        }

        private void Produktet_Load(object sender, EventArgs e)
        {
            ProduktetBLL produktetBLL = new ProduktetBLL();
            DataTable list = produktetBLL.ShowProduktet();
            dgvProduktet.DataSource = list;
        }
    }
}
