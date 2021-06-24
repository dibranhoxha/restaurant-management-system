
namespace RestaurantManagementApp.UserKontrollat
{
	partial class TavolinaUserKontroll
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TavolinaUserKontroll));
			this.lblNrTavolines = new Guna.UI.WinForms.GunaLabel();
			this.paneliDisponueshmeria = new System.Windows.Forms.Panel();
			this.btnImageTavolina = new Guna.UI.WinForms.GunaImageButton();
			this.SuspendLayout();
			// 
			// lblNrTavolines
			// 
			this.lblNrTavolines.AutoSize = true;
			this.lblNrTavolines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNrTavolines.ForeColor = System.Drawing.Color.Tomato;
			this.lblNrTavolines.Location = new System.Drawing.Point(4, 3);
			this.lblNrTavolines.Name = "lblNrTavolines";
			this.lblNrTavolines.Size = new System.Drawing.Size(23, 28);
			this.lblNrTavolines.TabIndex = 1;
			this.lblNrTavolines.Text = "0";
			this.lblNrTavolines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// paneliDisponueshmeria
			// 
			this.paneliDisponueshmeria.BackColor = System.Drawing.Color.Green;
			this.paneliDisponueshmeria.Location = new System.Drawing.Point(83, 144);
			this.paneliDisponueshmeria.Name = "paneliDisponueshmeria";
			this.paneliDisponueshmeria.Size = new System.Drawing.Size(34, 10);
			this.paneliDisponueshmeria.TabIndex = 2;
			// 
			// btnImageTavolina
			// 
			this.btnImageTavolina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImageTavolina.BackgroundImage")));
			this.btnImageTavolina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnImageTavolina.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btnImageTavolina.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnImageTavolina.Image = null;
			this.btnImageTavolina.ImageSize = new System.Drawing.Size(64, 64);
			this.btnImageTavolina.Location = new System.Drawing.Point(0, 0);
			this.btnImageTavolina.Name = "btnImageTavolina";
			this.btnImageTavolina.OnHoverImage = null;
			this.btnImageTavolina.OnHoverImageOffset = new System.Drawing.Point(0, 0);
			this.btnImageTavolina.Size = new System.Drawing.Size(199, 166);
			this.btnImageTavolina.TabIndex = 0;
			this.btnImageTavolina.Click += new System.EventHandler(this.btnImageTavolina_Click);
			// 
			// TavolinaUserKontroll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.paneliDisponueshmeria);
			this.Controls.Add(this.lblNrTavolines);
			this.Controls.Add(this.btnImageTavolina);
			this.Name = "TavolinaUserKontroll";
			this.Size = new System.Drawing.Size(199, 166);
			this.Load += new System.EventHandler(this.TavolinaUserKontroll_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI.WinForms.GunaImageButton btnImageTavolina;
		private Guna.UI.WinForms.GunaLabel lblNrTavolines;
		private System.Windows.Forms.Panel paneliDisponueshmeria;
	}
}
