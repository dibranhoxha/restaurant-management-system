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
    public partial class ProduktiZgjedhurUserControl : UserControl
    {
        public ProduktiZgjedhurUserControl()
        {
            InitializeComponent();
        }

        public PictureBox pbox { get { return pictureBox1; } }
        public String lblEmri { get { return label1.Text; } set { label1.Text = value; } }
        public string lblCmimi { get { return gunaLabel3.Text; } set { gunaLabel3.Text = value; } }
        public string lblId { get { return label2.Text; } set { label2.Text = value; } }
        public Guna.UI.WinForms.GunaNumeric nup { get { return gunaNumeric1; } }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }
    }
}

