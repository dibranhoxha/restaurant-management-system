using System;
using System.Windows.Forms;
using RMS.BLL;
using RMS.BO;

namespace RestaurantManagementApp.Format.Perdoruesit
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        PerdoruesitBLL perdoruesitBLL = new PerdoruesitBLL();

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
        {
            if (fjalekalimiTextBox.UseSystemPasswordChar) fjalekalimiTextBox.UseSystemPasswordChar = false; else fjalekalimiTextBox.UseSystemPasswordChar = true;
        }

        private void kycuButton_Click(object sender, EventArgs e)
        {
            string mesazhi = perdoruesitBLL.KyçPerdorues(usernameTextBox.Text, fjalekalimiTextBox.Text);

            if (PerdoruesiAktiv.LoggedIn == true)
            {
                MessageBox.Show(mesazhi);
                Hide();

                Form1 AdminHome = new Form1();
                AdminHome.Show();
            }
            else
            {
                MessageBox.Show("Kyçja nuk mund te behej. Rishikoni fushat: Username dhe Fjalekalimi");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
