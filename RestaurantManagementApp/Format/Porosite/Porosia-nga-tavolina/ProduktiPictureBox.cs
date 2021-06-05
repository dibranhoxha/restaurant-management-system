using System;
using System.Windows.Forms;


namespace RestaurantManagementApp.Format.Porosite.Porosia_nga_tavolina
{
    public partial class ProduktiPictureBox : PictureBox
    {
        public ProduktiPictureBox() : base() { }

        public int ProduktiID { get; set; }

        public string Emri { get; set; }

        public int Cmimi { get; set; }

        public CheckState CheckState { get; set; } = CheckState.Unchecked;

        public void CheckToggle()
        {
            if (CheckState == CheckState.Unchecked)
            {
                CheckState = CheckState.Checked;
            }
            else
            {
                CheckState = CheckState.Unchecked;
            }
        }

        public bool Kerko(string str, StringComparison comparison)
        {
            return Emri.IndexOf(str, comparison) >= 0;
        }
    }
}
