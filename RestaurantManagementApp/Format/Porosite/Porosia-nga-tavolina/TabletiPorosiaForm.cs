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

namespace RestaurantManagementApp.Format.Porosite.Porosia_nga_tavolina
{
    public partial class TabletiPorosiaForm : Form
    {
        public List<ProduktiPictureBox> liscollection;
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


            //TODO: put this in a function
            Bitmap MyImage = new Bitmap(@"C:\Users\L\Downloads\pizza-pizza-filled-with-tomatoes-salami-olives.jpg");

            liscollection = new List<ProduktiPictureBox>();
            for (int i = 0; i < 100; i++)
            {

                ProduktiPictureBox p = new ProduktiPictureBox();
                p.Emri = i.ToString();
                p.ProduktiID = i;
                p.Cmimi = i;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.ClientSize = new Size(138, 108);
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
            //Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper3 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel3, sb, true);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            // int PorosiID = usp_RegjistroPorosine(TavolinaID);
            foreach (UserControl us in flowLayoutPanel1.Controls)
            {
                ProduktiPictureBox pbox = us.Controls.OfType<ProduktiPictureBox>().First();

                Guna.UI.WinForms.GunaNumeric nup = (Guna.UI.WinForms.GunaNumeric)us.Controls.Find("gunaNumeric1", true)[0];
                MessageBox.Show(nup.Value.ToString());
                for (int i = 0; i < nup.Value; i++)
                {
                    // usp_RegjistroProduktin(PorosiID, kontrollerat[0].ProduktiID)
                    MessageBox.Show((i + 1) + " -- " + pbox.Emri);
                }
            }
        }

        private ProduktiUserControl Produkti_UserControl(ProduktiPictureBox p)
        {
            ProduktiUserControl pr = new ProduktiUserControl();
            pr.Controls.Add(p);
            pr.Margin = new Padding(40, 10, 0, 40);
            pr.txtbox.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore ";
            p.MouseHover += (thesender, thee) =>
            {
                pr.txtbox.Font = new Font("Century Gothic", 10, FontStyle.Italic);
                pr.txtbox.ForeColor = Color.Navy;
            };
            p.MouseLeave += (thesender, thee) =>
            {
                pr.txtbox.ForeColor = Color.Black;
                pr.txtbox.Font = new Font("Century Gothic", 10);
            };

            p.Click += (sender, e) =>
            {
                p.CheckToggle();

                if (p.CheckState == CheckState.Checked)
                {
                    ProduktiZgjedhurUserControl us = new ProduktiZgjedhurUserControl();
                    us.Controls.Add(p);
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
                    };
                    us.nup.ValueChanged += (thesender, thee) =>
                    {
                        double cmimi = us.nup.Value * p.Cmimi;
                        us.lblCmimi = cmimi.ToString();
                        double subtotal = kalkulo_subtotalin();
                        double perqindja = 0.19;
                        double taksa = subtotal * perqindja;
                        double total = subtotal + taksa;
                        gunaLabel8.Text = subtotal.ToString();
                        gunaLabel6.Text = total.ToString();
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

        private double kalkulo_subtotalin()
        {
            double subtotal = 0;
            foreach (ProduktiZgjedhurUserControl us in flowLayoutPanel1.Controls)
            {
                ProduktiPictureBox p = us.Controls.OfType<ProduktiPictureBox>().First();
                subtotal += us.nup.Value * p.Cmimi;
            }
            return subtotal;
        }

        private void gunaVScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
