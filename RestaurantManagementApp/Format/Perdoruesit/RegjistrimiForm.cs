using System;
using System.Windows.Forms;
using RMS.BO;
using RMS.BLL;


namespace RestaurantManagementApp.Format.Perdoruesit
{
    public partial class RegjistrimiForm : Form
    {
        public RegjistrimiForm()
        {
            InitializeComponent();
        }
        PerdoruesitBLL perdoruesitBLL = new PerdoruesitBLL();

        private void regjistroButton_Click(object sender, EventArgs e)
        {
            Perdoruesi perdoruesi = new Perdoruesi(usernameTextBox.Text, emailTextBox.Text, emailTextBox.Text, roliComboBox.Text);
            string mesazhi = perdoruesitBLL.RegjistroPerdorues(perdoruesi);

            MessageBox.Show(mesazhi);
            if (mesazhi == "Perdoruesi u regjistrua.")
            {
                Hide();
            }
        }
    }
}
