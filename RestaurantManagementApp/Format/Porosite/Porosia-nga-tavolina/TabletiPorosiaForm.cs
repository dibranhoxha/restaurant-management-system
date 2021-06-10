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
        KategoriteBLL kategoriteBLL = new KategoriteBLL();
        NenkategoriteBLL nenkategoriteBLL = new NenkategoriteBLL();
        public List<ProduktiPictureBox> liscollection = new List<ProduktiPictureBox>();
        public List<ProduktiUserControl> liscollection2 = new List<ProduktiUserControl>();
        public List<Kategoria> kategorite = new List<Kategoria>();
        public int KategoriID_global = 1;

        public TabletiPorosiaForm()
        {
            InitializeComponent();

            ShtoNenkategoriteNeCbox();

            kategorite = kategoriteBLL.KtheKategorite();
            foreach (var item in kategorite)
            {
                InicializoProduktet(item.Id);
            }
            foreach (var item in liscollection)
            {
                InicializoProduktiUserControl(item);
            }
            ParaqitProduktet(KategoriID_global,1);
        }
        
        private void InicializoProduktet(int kategoria)
        {
            Bitmap MyImage = new Bitmap(@"C:\Users\L\Downloads\pizza-pizza-filled-with-tomatoes-salami-olives.jpg");

            ProduktetBLL produktetBLL = new ProduktetBLL();
            List<Produkti> produktet = produktetBLL.KtheProduktet(kategoria);
            foreach (var item in produktet)
            {
                ProduktiPictureBox p = new ProduktiPictureBox();
                p.Emri = item.Emri;
                p.ProduktiID = item.ProduktID;
                p.KategoriID = item.KategoriID;
                p.Cmimi = item.Cmimi;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.ClientSize = new Size(158, 108);
                p.Image = (Image)MyImage;
                p.Cursor = Cursors.Hand;

                liscollection.Add(p);
            }
        }

        private void ParaqitProduktet(int kategoriaId, int nenkategoriId)
        {
            flowLayoutPanel2.Controls.Clear();

            foreach (ProduktiPictureBox p in liscollection)
            {
                Kategoria kategoria = kategorite.Find(x => x.Id == kategoriaId);
                if (kategoria != null)
                {
                    foreach (var item in kategoria.Nenkategorite)
                    {
                        if (p.FilteroTeGjitha(item.Id))
                        {
                            foreach (ProduktiUserControl pus in liscollection2)
                            {
                                try
                                {
                                    ProduktiPictureBox pbox = pus.Controls.OfType<ProduktiPictureBox>().First();
                                    if (pbox.ProduktiID == p.ProduktiID)
                                    {
                                        if (nenkategoriId==0)
                                        {
                                            flowLayoutPanel2.Controls.Add(pus);
                                        }
                                        else if(p.KategoriID == nenkategoriId)
                                        {
                                            flowLayoutPanel2.Controls.Add(pus);
                                        }
                                    }
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void InicializoProduktiUserControl(ProduktiPictureBox p)
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
                        try
                        {
                            Kategoria kategoria = kategorite.Find(x => x.Id == KategoriID_global);
                            Nenkategoria nkat = kategoria.Nenkategorite.Find(x => x.Id == p.KategoriID);
                            if (nkat != null)
                            {
                                if (p.KategoriID == Convert.ToInt32(guna2ComboBox1.SelectedItem))
                                {
                                    flowLayoutPanel2.Controls.Add(pr);
                                }
                                
                            }
                        }
                        catch { }
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
            };
            liscollection2.Add(pr);
        }
        
        private void ShtoNenkategoriteNeCbox()
        {
            List<Nenkategoria> nenkategorit = nenkategoriteBLL.KtheNenkategoriNgaKategoria(KategoriID_global);
            guna2ComboBox1.DataSource = nenkategorit;
            guna2ComboBox1.DisplayMember = "Emri";
            guna2ComboBox1.ValueMember = "Id";
        }

        private void kalkulo_totalin()
        {
            decimal subtotal = 0;

            foreach (ProduktiZgjedhurUserControl us in flowLayoutPanel1.Controls)
            {
                ProduktiPictureBox p = us.Controls.OfType<ProduktiPictureBox>().First();
                subtotal += us.nup.Value * p.Cmimi;
            }
            decimal bakshishi = subtotal * guna2TrackBar1.Value / 100;
            subtotal = subtotal + bakshishi;
            decimal perqindja = 0.16m;
            decimal taksa = subtotal * perqindja;
            decimal total = subtotal + taksa;
            gunaLabel8.Text = subtotal.ToString();
            gunaLabel6.Text = total.ToString();
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
            porosia.PorosiaID = porosiaBLL.ShtoPorosi(porosia);
            
            foreach (UserControl us in flowLayoutPanel1.Controls)
            {
                ProduktiPictureBox pbox = us.Controls.OfType<ProduktiPictureBox>().First();
                ProduktiUserControl pr = us.Controls.OfType<ProduktiUserControl>().First();
                Guna.UI.WinForms.GunaNumeric nup = (Guna.UI.WinForms.GunaNumeric)us.Controls.Find("gunaNumeric1", true)[0];
                
                porosiaBLL.ShtoProduktePerPorosi(porosia, pbox.ProduktiID, Convert.ToInt32(nup.Value));
                MessageBox.Show(porosia.PorosiaID.ToString() + " - " + pbox.ProduktiID.ToString() +" - "+ nup.Value.ToString());
            }
            foreach (UserControl us in flowLayoutPanel1.Controls)
            {
                ProduktiPictureBox pbox = us.Controls.OfType<ProduktiPictureBox>().First();
                ProduktiUserControl pr = us.Controls.OfType<ProduktiUserControl>().First();

                pbox.CheckToggle();
                pr.Controls.Add(pbox);
                flowLayoutPanel2.Controls.Add(pr);
            }
            gunaLabel8.Text = "0.00";
            gunaLabel6.Text = "0.00";
            flowLayoutPanel1.Controls.Clear();
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

        private void gunaGradientTileButton1_Click(object sender, EventArgs e)
        {
            ParaqitProduktet(1,1);
            KategoriID_global = 1;
            ShtoNenkategoriteNeCbox();
        }

        private void gunaGradientTileButton2_Click(object sender, EventArgs e)
        {
            ParaqitProduktet(2,1);
            KategoriID_global = 2;
            ShtoNenkategoriteNeCbox();
        }

        private void gunaGradientTileButton4_Click(object sender, EventArgs e)
        {
            ParaqitProduktet(3,1);
            KategoriID_global = 3;
            ShtoNenkategoriteNeCbox();
        }

        private void gunaGradientTileButton3_Click(object sender, EventArgs e)
        {
            ParaqitProduktet(4,1);
            KategoriID_global = 4;
            ShtoNenkategoriteNeCbox();
        }
       
        private void guna2ComboBox1_SelectionChangeCommited(object sender, EventArgs e)
        {
            ParaqitProduktet(KategoriID_global, Convert.ToInt32(guna2ComboBox1.SelectedValue.ToString()));
        }
    }
}
