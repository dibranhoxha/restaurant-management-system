using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementApp.Format.Porosite.Porosia_nga_tavolina
{
    public partial class ProduktiUserControl : UserControl
    {
        public ProduktiUserControl()
        {
            InitializeComponent();
        }
        public TextBox txtbox { get { return textBox1; } set { textBox1 = value; } }
    }
}
