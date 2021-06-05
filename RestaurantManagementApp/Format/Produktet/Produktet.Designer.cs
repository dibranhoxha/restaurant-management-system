
namespace RestaurantManagementApp.Format.Produktet
{
    partial class Produktet
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
            this.btnCreateProduct = new MetroSet_UI.Controls.MetroSetButton();
            this.btnDeleteProduct = new MetroSet_UI.Controls.MetroSetButton();
            this.dgvProduktet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduktet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCreateProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCreateProduct.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreateProduct.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCreateProduct.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCreateProduct.HoverTextColor = System.Drawing.Color.White;
            this.btnCreateProduct.IsDerivedStyle = true;
            this.btnCreateProduct.Location = new System.Drawing.Point(39, 137);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCreateProduct.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCreateProduct.NormalTextColor = System.Drawing.Color.White;
            this.btnCreateProduct.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCreateProduct.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCreateProduct.PressTextColor = System.Drawing.Color.White;
            this.btnCreateProduct.Size = new System.Drawing.Size(142, 62);
            this.btnCreateProduct.Style = MetroSet_UI.Enums.Style.Light;
            this.btnCreateProduct.StyleManager = null;
            this.btnCreateProduct.TabIndex = 0;
            this.btnCreateProduct.Text = "Add";
            this.btnCreateProduct.ThemeAuthor = "Narwin";
            this.btnCreateProduct.ThemeName = "MetroLite";
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteProduct.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteProduct.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteProduct.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteProduct.HoverTextColor = System.Drawing.Color.White;
            this.btnDeleteProduct.IsDerivedStyle = true;
            this.btnDeleteProduct.Location = new System.Drawing.Point(39, 224);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteProduct.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteProduct.NormalTextColor = System.Drawing.Color.White;
            this.btnDeleteProduct.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteProduct.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteProduct.PressTextColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Size = new System.Drawing.Size(142, 62);
            this.btnDeleteProduct.Style = MetroSet_UI.Enums.Style.Light;
            this.btnDeleteProduct.StyleManager = null;
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.ThemeAuthor = "Narwin";
            this.btnDeleteProduct.ThemeName = "MetroLite";
            // 
            // dgvProduktet
            // 
            this.dgvProduktet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduktet.Location = new System.Drawing.Point(217, 12);
            this.dgvProduktet.Name = "dgvProduktet";
            this.dgvProduktet.Size = new System.Drawing.Size(397, 415);
            this.dgvProduktet.TabIndex = 3;
            // 
            // Produktet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.dgvProduktet);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnCreateProduct);
            this.Name = "Produktet";
            this.Text = "Produktet";
            this.Load += new System.EventHandler(this.Produktet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduktet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetButton btnCreateProduct;
        private MetroSet_UI.Controls.MetroSetButton btnDeleteProduct;
        private System.Windows.Forms.DataGridView dgvProduktet;
    }
}