
namespace RestaurantManagementApp.UserKontrollat
{
	partial class RezervimiUserKontroll
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervimiUserKontroll));
			this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
			this.lblRezervimi = new System.Windows.Forms.Label();
			this.lblDataERezervimit = new System.Windows.Forms.Label();
			this.lblEmriKlientit = new System.Windows.Forms.Label();
			this.lblTavolina = new System.Windows.Forms.Label();
			this.gunaGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gunaGradientPanel1
			// 
			this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
			this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.gunaGradientPanel1.Controls.Add(this.lblRezervimi);
			this.gunaGradientPanel1.Controls.Add(this.lblDataERezervimit);
			this.gunaGradientPanel1.Controls.Add(this.lblEmriKlientit);
			this.gunaGradientPanel1.Controls.Add(this.lblTavolina);
			this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.WhiteSmoke;
			this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
			this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.White;
			this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.WhiteSmoke;
			this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.gunaGradientPanel1.Name = "gunaGradientPanel1";
			this.gunaGradientPanel1.Size = new System.Drawing.Size(1007, 57);
			this.gunaGradientPanel1.TabIndex = 0;
			this.gunaGradientPanel1.Text = "gunaGradientPanel1";
			// 
			// lblRezervimi
			// 
			this.lblRezervimi.AutoSize = true;
			this.lblRezervimi.BackColor = System.Drawing.Color.Transparent;
			this.lblRezervimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRezervimi.Location = new System.Drawing.Point(31, 16);
			this.lblRezervimi.Name = "lblRezervimi";
			this.lblRezervimi.Size = new System.Drawing.Size(97, 25);
			this.lblRezervimi.TabIndex = 6;
			this.lblRezervimi.Text = "Rezervimi";
			// 
			// lblDataERezervimit
			// 
			this.lblDataERezervimit.AutoSize = true;
			this.lblDataERezervimit.BackColor = System.Drawing.Color.Transparent;
			this.lblDataERezervimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataERezervimit.Location = new System.Drawing.Point(699, 16);
			this.lblDataERezervimit.Name = "lblDataERezervimit";
			this.lblDataERezervimit.Size = new System.Drawing.Size(157, 25);
			this.lblDataERezervimit.TabIndex = 5;
			this.lblDataERezervimit.Text = "Data e rezervimit";
			// 
			// lblEmriKlientit
			// 
			this.lblEmriKlientit.AutoSize = true;
			this.lblEmriKlientit.BackColor = System.Drawing.Color.Transparent;
			this.lblEmriKlientit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmriKlientit.Location = new System.Drawing.Point(234, 16);
			this.lblEmriKlientit.Name = "lblEmriKlientit";
			this.lblEmriKlientit.Size = new System.Drawing.Size(119, 25);
			this.lblEmriKlientit.TabIndex = 4;
			this.lblEmriKlientit.Text = "Emri i klientit";
			// 
			// lblTavolina
			// 
			this.lblTavolina.AutoSize = true;
			this.lblTavolina.BackColor = System.Drawing.Color.Transparent;
			this.lblTavolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTavolina.Location = new System.Drawing.Point(477, 16);
			this.lblTavolina.Name = "lblTavolina";
			this.lblTavolina.Size = new System.Drawing.Size(87, 25);
			this.lblTavolina.TabIndex = 3;
			this.lblTavolina.Text = "Tavolina";
			// 
			// RezervimiUserKontroll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gunaGradientPanel1);
			this.Name = "RezervimiUserKontroll";
			this.Size = new System.Drawing.Size(1012, 57);
			this.Load += new System.EventHandler(this.RezervimiUserKontroll_Load);
			this.gunaGradientPanel1.ResumeLayout(false);
			this.gunaGradientPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
		private System.Windows.Forms.Label lblDataERezervimit;
		private System.Windows.Forms.Label lblEmriKlientit;
		private System.Windows.Forms.Label lblTavolina;
		private System.Windows.Forms.Label lblRezervimi;
	}
}
