using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib;
using RMS.BLL;
using RMS.BO;


namespace RestaurantManagementApp.Format.Porosite.Porosia_nga_tavolina
{
    public partial class TabletiPorosiaForm : Form
    {
        PorosiaBLL porosiaBLL = new PorosiaBLL();
        public List<ProduktiPictureBox> liscollection =  new List<ProduktiPictureBox>();
        public List<ProduktiUserControl> liscollection2;
        public TabletiPorosiaForm()
        {
            InitializeComponent();

            Guna.UI2.WinForms.Guna2CheckBox ch = new Guna.UI2.WinForms.Guna2CheckBox();
            ch.Cursor = Cursors.Hand;
            ch.Text = "Te gjitha";


            List<Guna.UI2.WinForms.Guna2CheckBox> kategorite_chb = new List<Guna.UI2.WinForms.Guna2CheckBox>();
            for (int i = 0; i < 20; i++)
            {

                Guna.UI2.WinForms.Guna2CheckBox ch2 = new Guna.UI2.WinForms.Guna2CheckBox();
                ch2.Cursor = Cursors.Hand;
                ch2.Text = "Kategoria #";
                ch2.CheckedChanged += (sender, e) =>
                {
                    ch.CheckState = CheckState.Unchecked;
                    // call the function that will go througth the 'kategorite_chb' and get the checked
                    // checkboxes. Pass those as parameters to the db procedure
                };
                kategorite_chb.Add(ch2);
            }
            ch.CheckedChanged += (sender, e) =>
            {
                foreach (var item in kategorite_chb) item.CheckState = CheckState.Unchecked;
                // if( ch.CheckState == CheckState.Checked ) { call the db procedure }
            };

            flowLayoutPanel3.Controls.Add(ch);
            foreach (var item in kategorite_chb)
            {
                flowLayoutPanel3.Controls.Add(item);
            }


            Bitmap MyImage = new Bitmap(@"C:\Users\Rra\Downloads\191115120957-immigrant-food-columbia-road.jpg");

            ProduktetBLL produktetBLL = new ProduktetBLL();
            List<Produkti> produktet = produktetBLL.GetProduktet();
            foreach (var item in produktet)
            {
                ProduktiPictureBox p = new ProduktiPictureBox();
                p.Emri = item.Emri;
                p.ProduktiID = item.ProduktID;
                p.Cmimi = item.Cmimi;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.ClientSize = new Size(158, 108);
                p.Image = (Image)MyImage;
                p.Cursor = Cursors.Hand;

                liscollection.Add(p);
            }

            liscollection2 = new List<ProduktiUserControl>();
            foreach (ProduktiPictureBox p in liscollection)
            {
                ProduktiUserControl pr = Produkti_UserControl(p);
                flowLayoutPanel2.Controls.Add(pr);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel2, gunaVScrollBar1, true);
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper2 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, gunaVScrollBar2, true);
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            
            RMS.BO.Porosia porosia = new RMS.BO.Porosia();
            porosia.DataEPorosise = DateTime.Now;
            int PorosiID = porosiaBLL.ShtoPorosi(porosia);
            
            string msg = "Porosia Id - " + PorosiID.ToString() + "\r\n";

            foreach (UserControl us in flowLayoutPanel1.Controls)
            {
                ProduktiPictureBox pbox = us.Controls.OfType<ProduktiPictureBox>().First();
                ProduktiUserControl pr = us.Controls.OfType<ProduktiUserControl>().First();
                

                Guna.UI.WinForms.GunaNumeric nup = (Guna.UI.WinForms.GunaNumeric)us.Controls.Find("gunaNumeric1", true)[0];
                for (int i = 0; i < nup.Value; i++)
                {
                    msg += pbox.Emri + ", Cmimi - " + pbox.Cmimi + "\r\n";
                }
            }
            foreach (UserControl us in flowLayoutPanel1.Controls)
            {
                ProduktiPictureBox pbox = us.Controls.OfType<ProduktiPictureBox>().First();
                ProduktiUserControl pr = us.Controls.OfType<ProduktiUserControl>().First();

                pbox.CheckToggle();
                pr.Controls.Add(pbox);
                flowLayoutPanel2.Controls.Add(pr);
            }
            gunaLabel8.Text = "";
            gunaLabel6.Text = "";
            flowLayoutPanel1.Controls.Clear();
            MessageBox.Show(msg);
        }

        private ProduktiUserControl Produkti_UserControl(ProduktiPictureBox p)
        {
            ProduktiUserControl pr = new ProduktiUserControl();
            pr.Controls.Add(p);
            pr.Margin = new Padding(40, 10, 0, 40);
            pr.txtbox.Text = p.Emri;
            p.MouseHover += (thesender, thee) =>
            {
                pr.txtbox.Font = new Font("Century Gothic", 11, FontStyle.Italic);
                pr.txtbox.ForeColor = Color.Navy;
            };
            p.MouseLeave += (thesender, thee) =>
            {
                pr.txtbox.ForeColor = Color.Black;
                pr.txtbox.Font = new Font("Century Gothic", 11);
            };

            p.Click += (sender, e) =>
            {
                p.CheckToggle();

                if (p.CheckState == CheckState.Checked)
                {
                    ProduktiZgjedhurUserControl us = new ProduktiZgjedhurUserControl();
                    us.Controls.Add(p);
                    us.Controls.Add(pr);
                    us.lblId = p.ProduktiID.ToString();
                    us.lblEmri = p.Emri;
                    us.lblCmimi = (us.nup.Value * p.Cmimi).ToString();
                    us.pbox.MouseHover += (thesender, thee) =>
                    {

                    };
                    us.pbox.Click += (thesender, thee) =>
                    {
                        p.CheckToggle();
                        flowLayoutPanel1.Controls.Remove(us);
                        pr.Controls.Add(p);
                        flowLayoutPanel2.Controls.Add(pr);
                        kalkulo_totalin();
                    };
                    us.nup.ValueChanged += (thesender, thee) =>
                    {
                        decimal cmimi = us.nup.Value * p.Cmimi;
                        us.lblCmimi = cmimi.ToString();
                        kalkulo_totalin();
                    };
                    flowLayoutPanel2.Controls.Remove(pr);
                    flowLayoutPanel1.Controls.Add(us);
                }
                if (p.CheckState == CheckState.Unchecked)
                {
                    pr.Controls.Add(p);
                    flowLayoutPanel2.Controls.Add(pr);
                }
            };

            liscollection2.Add(pr);
            return pr;

        }

        private void kalkulo_totalin()
        {
            decimal subtotal = 0;
            
            foreach (ProduktiZgjedhurUserControl us in flowLayoutPanel1.Controls)
            {
                ProduktiPictureBox p = us.Controls.OfType<ProduktiPictureBox>().First();
                subtotal += us.nup.Value * p.Cmimi;
            }
            decimal bakshishi = subtotal * guna2TrackBar1.Value/100;
            subtotal = subtotal + bakshishi;
            decimal perqindja = 0.16m;
            decimal taksa = subtotal * perqindja;
            decimal total = subtotal + taksa;
            gunaLabel8.Text = subtotal.ToString();
            gunaLabel6.Text = total.ToString();
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();

            if (string.IsNullOrEmpty(guna2TextBox1.Text) == false)
            {
                foreach (ProduktiUserControl pr in liscollection2)
                {
                    ProduktiPictureBox p;
                    try
                    {
                        p = pr.Controls.OfType<ProduktiPictureBox>().First();
                        if (p.Kerko(guna2TextBox1.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            if (p.CheckState != CheckState.Checked)
                                flowLayoutPanel2.Controls.Add(pr);
                        }
                    }
                    catch (Exception)
                    {
                    }

                }
            }
            else
            {
                foreach (ProduktiUserControl pr in liscollection2)
                {
                    try
                    {
                        ProduktiPictureBox p = pr.Controls.OfType<ProduktiPictureBox>().First();
                        if (p.CheckState != CheckState.Checked)
                            flowLayoutPanel2.Controls.Add(pr);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gunaLabel9.Text = guna2TrackBar1.Value.ToString() + "%";

            kalkulo_totalin();
        }

    }
}
