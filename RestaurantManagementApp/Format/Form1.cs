using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RMS.BLL;
using RMS.BO;
using RestaurantManagementApp.UserKontrollat;
using RestaurantManagementApp.Format.Porosite.Porosia_nga_tavolina;
using System.Drawing;
using System.Globalization;

namespace RestaurantManagementApp
{
	public partial class Form1 : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		ProduktetBLL produktetBLL = new ProduktetBLL();
		TavolinatBLL tavolinatBLL = new TavolinatBLL();
		RezervimetBLL rezervimetBLL = new RezervimetBLL();
		NenkategoriteBLL nenkategoriteBLL = new NenkategoriteBLL();
		public static int nrTavolines;

		public static bool shfaqFormen = true;
		int paneliAktiv = 1; // 1 - tavolinat, 2 - produktet, 3 - Rezervimet, 4 - Statistikat
		int kategoriaEProduktit = 1;
		List<Tavolina> tavolinatELira = new List<Tavolina>();
		List<ProduktiPictureBox> listaMeProduktePB = new List<ProduktiPictureBox>();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dtpDataERezervimit.Format = DateTimePickerFormat.Custom;
			dtpDataERezervimit.CustomFormat = "MM/dd/yyyy hh:mm:ss";
			cmbTavolinaELire.DataSource = tavolinatBLL.GetTavolinat();
			cmbTavolinaELire.DisplayMember = "TavolinaID";
			cmbTavolinaELire.ValueMember = "TavolinaID";
			panelShtoTavoline.Visible = false;
			panelFshiTavoline.Visible = false;
			Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(PaneliKryesor, gunaVScrollBar1, true);
			//Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper2 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(PaneliKryesor, gunaVScrollBar2, true);
			List<Produkti> listaEProdukteve = new List<Produkti>();
			listaEProdukteve = produktetBLL.KtheTeGjithaProduktet();
			listaMeProduktePB = ListaMeProduktePB(listaEProdukteve);
			mbushPanelinMeTavolina();
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		List<TavolinaUserKontroll> ListaMeTavolinaUC(List<Tavolina> tavolinat)
		{
			List<TavolinaUserKontroll> listaETavolinaveUC = new List<TavolinaUserKontroll>();
			TavolinaUserKontroll tavolinaUC;
			if (tavolinat.Count > 0)
			{
				foreach (Tavolina tavolina in tavolinat)
				{
					nrTavolines = tavolina.TavolinaID;
					tavolinaUC = new TavolinaUserKontroll(nrTavolines, tavolina.NrKarrikave, tavolina.Disponueshmeria);
					listaETavolinaveUC.Add(tavolinaUC);
				}
			}
			return listaETavolinaveUC;
		}

		void mbushPanelinMeTavolina()
		{

			List<Tavolina> listaETavolinave = new List<Tavolina>();
			listaETavolinave = tavolinatBLL.GetTavolinat();
			List<TavolinaUserKontroll> listaETavolinaveUC = ListaMeTavolinaUC(listaETavolinave);

			if (listaETavolinaveUC.Count > 0)
			{
				foreach (TavolinaUserKontroll tavolinaUC in listaETavolinaveUC)
				{
					PaneliKryesor.Controls.Add(tavolinaUC);
				}
			}
		}

		List<ProduktiPictureBox> ListaMeProduktePB(List<Produkti> listaMeProdukte)
		{
			List<ProduktiPictureBox> listaEProduktevePB = new List<ProduktiPictureBox>();
			foreach (Produkti item in listaMeProdukte)
			{
				ProduktiPictureBox p = new ProduktiPictureBox();
				p.Emri = item.Emri;
				p.ProduktiID = item.ProduktID;
				p.KategoriID = item.KategoriID;
				p.Cmimi = item.Cmimi;
				p.Foto = item.Foto;
				p.SizeMode = PictureBoxSizeMode.StretchImage;
				p.ClientSize = new Size(158, 108);
				p.Load(p.Foto);
				p.Cursor = Cursors.Hand;

				p.Click += (sender, e) =>
				{
					txbEmriProduktitPerFshirje.Text = p.Emri;
				};

					listaEProduktevePB.Add(p);
			}
			return listaEProduktevePB;

		}

		List<ProduktiUserControl> ListaMeProdukteUC(List<ProduktiPictureBox> listaMeProduktePB)
		{
			List<ProduktiUserControl> listaEProdukteveUC = new List<ProduktiUserControl>();
			ProduktiUserControl produktiUC;
			foreach (ProduktiPictureBox produktiPB in listaMeProduktePB)
			{
				produktiUC = new ProduktiUserControl();
				produktiUC.Margin = new Padding(40, 10, 0, 40);
				produktiUC.txtbox.Text = produktiPB.Emri;
				produktiUC.Controls.Add(produktiPB);
				listaEProdukteveUC.Add(produktiUC);
			}
			return listaEProdukteveUC;

		}

		void mbushPanelinMeProdukte()
		{

			List<ProduktiUserControl> listaEProdukteveUC = ListaMeProdukteUC(listaMeProduktePB);

			if (listaEProdukteveUC.Count > 0)
			{
				foreach (ProduktiUserControl produktiUC in listaEProdukteveUC)
				{
					PaneliKryesor.Controls.Add(produktiUC);
				}
			}
		}

		void mbushPanelinMeProdukteNgaKategoria(int kategoria)
		{

			List<Produkti> listaEProdukteve = new List<Produkti>();
			listaEProdukteve = produktetBLL.KtheProduktet(kategoria);
			List<ProduktiPictureBox> listaMeProduktePB = ListaMeProduktePB(listaEProdukteve);
			List<ProduktiUserControl> listaEProdukteveUC = ListaMeProdukteUC(listaMeProduktePB);

			if (listaEProdukteveUC.Count > 0)
			{
				foreach (ProduktiUserControl produktiUC in listaEProdukteveUC)
				{
					PaneliKryesor.Controls.Add(produktiUC);
				}
			}
		}


		List<RezervimiUserKontroll> ListaMeRezervimeUC(List<Rezervimi> rezervimet)
		{
			List<RezervimiUserKontroll> listaERezervimeveUC = new List<RezervimiUserKontroll>();
			RezervimiUserKontroll rezervimiUC;
			if (rezervimet.Count > 0)
			{
				foreach (Rezervimi rezervimi in rezervimet)
				{
					//nrTavolines = rezervimi.;
					rezervimiUC = new RezervimiUserKontroll(rezervimi.RezervimiID, rezervimi.TavolinaID, rezervimi.EmriKlientit, rezervimi.DataERezervimit);
					listaERezervimeveUC.Add(rezervimiUC);
				}
			}
			return listaERezervimeveUC;
		}

		void mbushPanelinMeRezervime()
		{
			List<Rezervimi> listaERezervimeve = new List<Rezervimi>();
			listaERezervimeve = rezervimetBLL.GetRezervimet();
			List<RezervimiUserKontroll> listaERezervimeveUC = ListaMeRezervimeUC(listaERezervimeve);

			if (listaERezervimeveUC.Count > 0)
			{
				foreach (RezervimiUserKontroll rezervimiUC in listaERezervimeveUC)
				{
					PaneliKryesor.Controls.Add(rezervimiUC);
				}
			}
		}

		private void btnTavolinat_Click(object sender, EventArgs e)
		{
			btnShto.Visible = true;
			btnFshi.Visible = true;
			paneliAktiv = 1;
			panelKategorite.Visible = false;
			panelKerko.Visible = true;
			PaneliKryesor.Controls.Clear();
			mbushPanelinMeTavolina();
		}

		private void btnProduktet_Click(object sender, EventArgs e)
		{
			btnShto.Visible = false;
			btnFshi.Visible = false;
			paneliAktiv = 2;
			PaneliShtoRezervim.Visible = false;
			panelShtoTavoline.Visible = false;
			panelFshiTavoline.Visible = false;
			panelKerko.Visible = true;
			panelKategorite.Visible = true;
			PaneliKryesor.Controls.Clear();
			mbushPanelinMeProdukte();
		}

		private void btnRezervimet_Click(object sender, EventArgs e)
		{
			btnShto.Visible = true;
			btnFshi.Visible = true;
			paneliAktiv = 3;
			panelShtoTavoline.Visible = false;
			panelFshiTavoline.Visible = false;
			panelKerko.Visible = true;
			panelKategorite.Visible = false;
			PaneliKryesor.Controls.Clear();
			mbushPanelinMeRezervime();
		}

		private void btnStatistikat_Click(object sender, EventArgs e)
		{
			panelKerko.Visible = false;
			btnShto.Visible = true;
			btnFshi.Visible = true;
			paneliAktiv = 4;
		}

		private void btnShtoTavoline_Click(object sender, EventArgs e)
		{
			Tavolina tavolina = new Tavolina(1, (int)nUDNrKarrikave.Value);
			tavolinatBLL.InsertTavoline(tavolina);
			PaneliKryesor.Controls.Clear();
			mbushPanelinMeTavolina();
			nUDNrKarrikave.Value = 2;
		}

		private void btnFshiTavoline_Click(object sender, EventArgs e)
		{
			tavolinatBLL.FshiTavoline(Convert.ToInt32(Math.Round(nUDIdETavolines.Value)));
			PaneliKryesor.Controls.Clear();
			mbushPanelinMeTavolina();
			nUDIdETavolines.Value = 0;
		}
		private void btnShto_Click(object sender, EventArgs e)
		{
			switch (paneliAktiv)
			{
				case 1:
					panelShtoTavoline.BringToFront();
					panelFshiTavoline.Visible = false;
					panelFshiProdukt.Visible = false;
					panelFshiRezervim.Visible = false;
					PaneliShtoRezervim.Visible = false;
					panelShtoProdukt.Visible = false;
					panelShtoTavoline.Visible = !panelShtoTavoline.Visible;
					break;
				case 2:
					panelShtoProdukt.BringToFront();
					panelFshiTavoline.Visible = false;
					panelFshiProdukt.Visible = false;
					panelFshiRezervim.Visible = false;
					PaneliShtoRezervim.Visible = false;
					panelShtoTavoline.Visible = false;
					panelShtoProdukt.Visible = !panelShtoProdukt.Visible;
					break;
				case 3:
					PaneliShtoRezervim.BringToFront();
					panelFshiTavoline.Visible = false;
					panelFshiProdukt.Visible = false;
					panelFshiRezervim.Visible = false;
					panelShtoProdukt.Visible = false;
					panelShtoTavoline.Visible = false;
					PaneliShtoRezervim.Visible = !PaneliShtoRezervim.Visible;
					break;
			}

		}

		private void btnFshi_Click(object sender, EventArgs e)
		{
			switch (paneliAktiv)
			{
				case 1:
					panelFshiTavoline.BringToFront();
					panelFshiRezervim.Visible = false;
					panelFshiProdukt.Visible = false;
					panelShtoTavoline.Visible = false;
					PaneliShtoRezervim.Visible = false;
					panelShtoProdukt.Visible = false;
					panelFshiTavoline.Visible = !panelFshiTavoline.Visible;
					break;
				case 2:
					panelFshiProdukt.BringToFront();
					panelFshiTavoline.Visible = false;
					panelFshiRezervim.Visible = false;
					PaneliShtoRezervim.Visible = false;
					panelShtoTavoline.Visible = false;
					panelShtoProdukt.Visible = false;
					panelFshiProdukt.Visible = !panelFshiProdukt.Visible;
					break;
				case 3:
					panelFshiRezervim.BringToFront();
					panelFshiTavoline.Visible = false;
					panelFshiProdukt.Visible = false;
					panelShtoTavoline.Visible = false;
					panelShtoProdukt.Visible = false;
					PaneliShtoRezervim.Visible = false;
					panelFshiRezervim.Visible = !panelFshiRezervim.Visible;
					break;
			}
		}

		private void btnShtoRezervim_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(txbEmriIKlientit.Text);
			Rezervimi rezervimi = new Rezervimi(int.Parse(cmbTavolinaELire.Text), txbEmriIKlientit.Text, dtpDataERezervimit.Value);
			rezervimetBLL.ShtoRezervim(rezervimi);
			PaneliKryesor.Controls.Clear();
			mbushPanelinMeRezervime();
			txbEmriIKlientit.Clear();
			txbEmriIKlientit.Clear();
		}

		private void btnFshiRezervim_Click(object sender, EventArgs e)
		{
			rezervimetBLL.FshiRezervim(Convert.ToInt32(Math.Round(nUDRezervimiID.Value)));
			PaneliKryesor.Controls.Clear();
			mbushPanelinMeRezervime();
			nUDRezervimiID.Value = 0;
		}
		void ListaMeTavolinaEFiltruarPerTavoline(int idETavolines)
		{
			PaneliKryesor.Controls.Clear();
			List<Tavolina> listaETavolinave = new List<Tavolina>();
			listaETavolinave = tavolinatBLL.GetTavolinat();
			List<TavolinaUserKontroll> listaETavolinaveUC = ListaMeTavolinaUC(listaETavolinave.FindAll(e => e.TavolinaID == idETavolines));

			if (listaETavolinaveUC.Count > 0)
			{
				foreach (TavolinaUserKontroll tavolinaUC in listaETavolinaveUC)
				{
					PaneliKryesor.Controls.Add(tavolinaUC);
				}
			}
		}

		void ProduktetEFiltruaraPerProdukt(string emri)
		{
			PaneliKryesor.Controls.Clear();

			List<ProduktiUserControl> listaEProdukteveUC = ListaMeProdukteUC(listaMeProduktePB.FindAll(e => e.Emri.Contains(emri)));

			if (listaEProdukteveUC.Count > 0)
			{
				foreach (ProduktiUserControl produktiUC in listaEProdukteveUC)
				{
					PaneliKryesor.Controls.Add(produktiUC);
				}
			}
		}

		void RezervimetEFiltruaraPerDate(DateTime data)
		{
			PaneliKryesor.Controls.Clear();
			List<Rezervimi> listaERezervimeve = new List<Rezervimi>();
			listaERezervimeve = rezervimetBLL.GetRezervimet();
			List<RezervimiUserKontroll> listaERezervimeveUC = ListaMeRezervimeUC(listaERezervimeve.FindAll(e => e.DataERezervimit.Date == data));

			if (listaERezervimeveUC.Count > 0)
			{
				foreach (RezervimiUserKontroll rezervimiUC in listaERezervimeveUC)
				{
					PaneliKryesor.Controls.Add(rezervimiUC);
				}
			}
		}


		void RezervimetEFiltruara()
		{
			DateTime data;
			if (DateTime.TryParse(txbKerko.Text, out data))
			{
				RezervimetEFiltruaraPerDate(data);
			}
			else
			{
				PaneliKryesor.Controls.Clear();
				mbushPanelinMeRezervime();
			}
		}

		void TavolinatEFiltruara()
		{
			int tavolina;
			if (int.TryParse(txbKerko.Text, out tavolina))
			{
				ListaMeTavolinaEFiltruarPerTavoline(tavolina);
			}
			else
			{
				PaneliKryesor.Controls.Clear();
				mbushPanelinMeTavolina();
			}
		}

		void ProduktetEFiltruara()
		{
			string emriIProduktit = txbKerko.Text;
			if (!String.IsNullOrEmpty(emriIProduktit))
			{
				ProduktetEFiltruaraPerProdukt(emriIProduktit);
			}
			else
			{
				PaneliKryesor.Controls.Clear();
				mbushPanelinMeProdukte();
			}
		}

		private void txbCmimi_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && txbCmimi.Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog
			{
				InitialDirectory = @"C:\",
				Title = "Browse Text Files",

				CheckFileExists = true,
				CheckPathExists = true,

				DefaultExt = "txt",
				Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;",
				FilterIndex = 2,
				RestoreDirectory = true,

				ReadOnlyChecked = true,
				ShowReadOnly = true
			};

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txbFoto.Text = openFileDialog1.FileName;
			}
		}

		private void mbushNenkategorite(int kategoria)
		{
			List<Nenkategoria> nenkategorite = nenkategoriteBLL.KtheNenkategoriNgaKategoria(kategoria);
			cmbNenkategoria.DataSource = nenkategorite;
			cmbNenkategoria.DisplayMember = "Emri";
			cmbNenkategoria.ValueMember = "Id";
			PaneliKryesor.Controls.Clear();
		}

		private void btnKategoriaUshqim_Click(object sender, EventArgs e)
		{
			panelKerko.Visible = false;
			btnShto.Visible = true;
			btnFshi.Visible = true;
			kategoriaEProduktit = 1;
			mbushNenkategorite(kategoriaEProduktit);
			mbushPanelinMeProdukteNgaKategoria(kategoriaEProduktit);
		}

		private void btnKategoriaPije_Click(object sender, EventArgs e)
		{
			panelKerko.Visible = false;
			btnShto.Visible = true;
			btnFshi.Visible = true;
			kategoriaEProduktit = 2;
			mbushNenkategorite(kategoriaEProduktit);
			mbushPanelinMeProdukteNgaKategoria(kategoriaEProduktit);
		}

		private void btnKategoriaEmbelsire_Click(object sender, EventArgs e)
		{
			panelKerko.Visible = false;
			btnShto.Visible = true;
			btnFshi.Visible = true;
			kategoriaEProduktit = 3;
			mbushNenkategorite(kategoriaEProduktit);
			mbushPanelinMeProdukteNgaKategoria(kategoriaEProduktit);	
		}

		private void btnShtoProdukt_Click(object sender, EventArgs e)
		{
			Produkti produkti = new Produkti(txbEmriProduktit.Text, Convert.ToInt32(cmbNenkategoria.SelectedValue), Convert.ToDecimal(txbCmimi.Text), txbFoto.Text);
			produktetBLL.InsertProdukt(produkti);
			PaneliKryesor.Controls.Clear();
			mbushPanelinMeProdukteNgaKategoria(kategoriaEProduktit);
			txbEmriProduktit.Clear();
			txbCmimi.Clear();
			txbFoto.Clear();
		}

		private void btnFshiProdukt_Click(object sender, EventArgs e)
		{
			if(!String.IsNullOrEmpty(txbEmriProduktitPerFshirje.Text))
			{
				produktetBLL.FshiProdukt(txbEmriProduktitPerFshirje.Text);
				PaneliKryesor.Controls.Clear();
				mbushPanelinMeProdukteNgaKategoria(kategoriaEProduktit);
				txbEmriProduktitPerFshirje.Clear();
			}
		}

		private void txbKerko_TextChanged(object sender, EventArgs e)
		{
			switch (paneliAktiv)
			{
				case 1:
					TavolinatEFiltruara();
					break;
				case 2:
					ProduktetEFiltruara();
					break;
				case 3:
					RezervimetEFiltruara();
					break;
			}
		}
	}
}
