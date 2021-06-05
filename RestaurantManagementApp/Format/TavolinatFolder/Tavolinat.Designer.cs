
namespace RestaurantManagementApp.Format.Tavolinat
{
    partial class Tavolinat
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTavolinat = new System.Windows.Forms.DataGridView();
            this.btnAddTavolina = new MetroSet_UI.Controls.MetroSetButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTavolinat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTavolinat
            // 
            this.dgvTavolinat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTavolinat.Location = new System.Drawing.Point(192, 21);
            this.dgvTavolinat.Name = "dgvTavolinat";
            this.dgvTavolinat.Size = new System.Drawing.Size(573, 407);
            this.dgvTavolinat.TabIndex = 0;
            // 
            // btnAddTavolina
            // 
            this.btnAddTavolina.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTavolina.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTavolina.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddTavolina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddTavolina.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddTavolina.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddTavolina.HoverTextColor = System.Drawing.Color.White;
            this.btnAddTavolina.IsDerivedStyle = true;
            this.btnAddTavolina.Location = new System.Drawing.Point(24, 106);
            this.btnAddTavolina.Name = "btnAddTavolina";
            this.btnAddTavolina.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTavolina.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddTavolina.NormalTextColor = System.Drawing.Color.White;
            this.btnAddTavolina.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddTavolina.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddTavolina.PressTextColor = System.Drawing.Color.White;
            this.btnAddTavolina.Size = new System.Drawing.Size(135, 68);
            this.btnAddTavolina.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddTavolina.StyleManager = null;
            this.btnAddTavolina.TabIndex = 1;
            this.btnAddTavolina.Text = "Add";
            this.btnAddTavolina.ThemeAuthor = "Narwin";
            this.btnAddTavolina.ThemeName = "MetroLite";
            this.btnAddTavolina.Click += new System.EventHandler(this.btnAddTavolina_Click);
            // 
            // Tavolinat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTavolina);
            this.Controls.Add(this.dgvTavolinat);
            this.Name = "Tavolinat";
            this.Text = "Tavolinat";
            this.Load += new System.EventHandler(this.Tavolinat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTavolinat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTavolinat;
        private MetroSet_UI.Controls.MetroSetButton btnAddTavolina;
    }
}