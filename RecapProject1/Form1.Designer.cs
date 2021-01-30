
namespace RecapProject1
{
    partial class Form1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(661, 73);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(80, 34);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(209, 20);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(80, 29);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(209, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 32);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Location = new System.Drawing.Point(12, 91);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(661, 78);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 41);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(23, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ara";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 175);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(661, 260);
            this.dgwProduct.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 454);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}

