namespace WFA_Nortwind.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.pnlBanner = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblTakip = new System.Windows.Forms.Label();
            this.btnTumSiparisler = new System.Windows.Forms.Button();
            this.btnRestauranAdindakiMusteriler = new System.Windows.Forms.Button();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnYirmiElliDolarArasiUrunler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.pnlBanner.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(295, 95);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowTemplate.Height = 25;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(1226, 730);
            this.dgvTable.TabIndex = 0;
            // 
            // pnlBanner
            // 
            this.pnlBanner.BackColor = System.Drawing.Color.Transparent;
            this.pnlBanner.BackgroundImage = global::WFA_Nortwind.UI.Properties.Resources.indir;
            this.pnlBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlBanner.Controls.Add(this.btnMinimize);
            this.pnlBanner.Controls.Add(this.btnExit);
            this.pnlBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBanner.Location = new System.Drawing.Point(0, 0);
            this.pnlBanner.Name = "pnlBanner";
            this.pnlBanner.Size = new System.Drawing.Size(1521, 95);
            this.pnlBanner.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.Location = new System.Drawing.Point(1371, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(72, 89);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::WFA_Nortwind.UI.Properties.Resources.CloseButton;
            this.btnExit.Location = new System.Drawing.Point(1449, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 89);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.BackgroundImage = global::WFA_Nortwind.UI.Properties.Resources.blue;
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.lblTakip);
            this.pnlMenu.Controls.Add(this.btnTumSiparisler);
            this.pnlMenu.Controls.Add(this.btnRestauranAdindakiMusteriler);
            this.pnlMenu.Controls.Add(this.btnBeverages);
            this.pnlMenu.Controls.Add(this.btnEmployees);
            this.pnlMenu.Controls.Add(this.button9);
            this.pnlMenu.Controls.Add(this.btnProducts);
            this.pnlMenu.Controls.Add(this.button7);
            this.pnlMenu.Controls.Add(this.button6);
            this.pnlMenu.Controls.Add(this.button4);
            this.pnlMenu.Controls.Add(this.btnYirmiElliDolarArasiUrunler);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 95);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(298, 730);
            this.pnlMenu.TabIndex = 2;
            // 
            // lblTakip
            // 
            this.lblTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTakip.Location = new System.Drawing.Point(8, 3);
            this.lblTakip.Name = "lblTakip";
            this.lblTakip.Size = new System.Drawing.Size(10, 50);
            this.lblTakip.TabIndex = 1;
            // 
            // btnTumSiparisler
            // 
            this.btnTumSiparisler.BackColor = System.Drawing.Color.Transparent;
            this.btnTumSiparisler.FlatAppearance.BorderSize = 0;
            this.btnTumSiparisler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTumSiparisler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTumSiparisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumSiparisler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTumSiparisler.ForeColor = System.Drawing.Color.Yellow;
            this.btnTumSiparisler.Location = new System.Drawing.Point(18, 77);
            this.btnTumSiparisler.Name = "btnTumSiparisler";
            this.btnTumSiparisler.Size = new System.Drawing.Size(271, 50);
            this.btnTumSiparisler.TabIndex = 0;
            this.btnTumSiparisler.Text = "TUM SIPARISLER";
            this.btnTumSiparisler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTumSiparisler.UseVisualStyleBackColor = false;
            this.btnTumSiparisler.Click += new System.EventHandler(this.btnTumSiparisler_Click);
            // 
            // btnRestauranAdindakiMusteriler
            // 
            this.btnRestauranAdindakiMusteriler.BackColor = System.Drawing.Color.Transparent;
            this.btnRestauranAdindakiMusteriler.FlatAppearance.BorderSize = 0;
            this.btnRestauranAdindakiMusteriler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRestauranAdindakiMusteriler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRestauranAdindakiMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestauranAdindakiMusteriler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRestauranAdindakiMusteriler.ForeColor = System.Drawing.Color.Yellow;
            this.btnRestauranAdindakiMusteriler.Location = new System.Drawing.Point(18, 151);
            this.btnRestauranAdindakiMusteriler.Name = "btnRestauranAdindakiMusteriler";
            this.btnRestauranAdindakiMusteriler.Size = new System.Drawing.Size(271, 50);
            this.btnRestauranAdindakiMusteriler.TabIndex = 0;
            this.btnRestauranAdindakiMusteriler.Text = "SIRKET ADI RESTAURANT OLAN MUSTERILER";
            this.btnRestauranAdindakiMusteriler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestauranAdindakiMusteriler.UseVisualStyleBackColor = false;
            this.btnRestauranAdindakiMusteriler.Click += new System.EventHandler(this.btnRestauranAdindakiMusteriler_Click);
            // 
            // btnBeverages
            // 
            this.btnBeverages.BackColor = System.Drawing.Color.Transparent;
            this.btnBeverages.FlatAppearance.BorderSize = 0;
            this.btnBeverages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBeverages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBeverages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeverages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBeverages.ForeColor = System.Drawing.Color.Yellow;
            this.btnBeverages.Location = new System.Drawing.Point(18, 225);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(271, 50);
            this.btnBeverages.TabIndex = 0;
            this.btnBeverages.Text = "BEVERAGES KATEGORİSİNDE STOK>50 ve Fiyat=5 ve KOLA";
            this.btnBeverages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeverages.UseVisualStyleBackColor = false;
            this.btnBeverages.Click += new System.EventHandler(this.btnBeverages_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployees.ForeColor = System.Drawing.Color.Yellow;
            this.btnEmployees.Location = new System.Drawing.Point(18, 299);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(271, 50);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "CALISANLAR ( AD SOYAD YAŞ ) ";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Yellow;
            this.button9.Location = new System.Drawing.Point(18, 373);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(271, 50);
            this.button9.TabIndex = 0;
            this.button9.Text = "HER BIR KATEGORININ STOKTAKI URUN MIKTARI";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.ForeColor = System.Drawing.Color.Yellow;
            this.btnProducts.Location = new System.Drawing.Point(18, 521);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(271, 50);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "500$ ALTINDAKI SIPARISLER";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Yellow;
            this.button7.Location = new System.Drawing.Point(18, 447);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(271, 50);
            this.button7.TabIndex = 0;
            this.button7.Text = "TUM URUNLER";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Yellow;
            this.button6.Location = new System.Drawing.Point(17, 595);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(271, 50);
            this.button6.TabIndex = 0;
            this.button6.Text = "URUNLER VE KATEGORILERI";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Location = new System.Drawing.Point(18, 669);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 50);
            this.button4.TabIndex = 0;
            this.button4.Text = "URUN KATEGORI TEDARIKCILER";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnYirmiElliDolarArasiUrunler
            // 
            this.btnYirmiElliDolarArasiUrunler.BackColor = System.Drawing.Color.Transparent;
            this.btnYirmiElliDolarArasiUrunler.FlatAppearance.BorderSize = 0;
            this.btnYirmiElliDolarArasiUrunler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYirmiElliDolarArasiUrunler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYirmiElliDolarArasiUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYirmiElliDolarArasiUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYirmiElliDolarArasiUrunler.ForeColor = System.Drawing.Color.Yellow;
            this.btnYirmiElliDolarArasiUrunler.Location = new System.Drawing.Point(18, 3);
            this.btnYirmiElliDolarArasiUrunler.Name = "btnYirmiElliDolarArasiUrunler";
            this.btnYirmiElliDolarArasiUrunler.Size = new System.Drawing.Size(271, 50);
            this.btnYirmiElliDolarArasiUrunler.TabIndex = 0;
            this.btnYirmiElliDolarArasiUrunler.Text = "20-50 TL ARASI URUNLER";
            this.btnYirmiElliDolarArasiUrunler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYirmiElliDolarArasiUrunler.UseVisualStyleBackColor = false;
            this.btnYirmiElliDolarArasiUrunler.Click += new System.EventHandler(this.btnYirmiElliDolarArasiUrunler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 825);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBanner);
            this.Controls.Add(this.dgvTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nortwind Sorgular";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.pnlBanner.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTable;
        private Panel pnlBanner;
        private Button btnMinimize;
        private Button btnExit;
        private Panel pnlMenu;
        private Button btnTumSiparisler;
        private Button btnRestauranAdindakiMusteriler;
        private Button btnBeverages;
        private Button btnEmployees;
        private Button button9;
        private Button btnProducts;
        private Button button7;
        private Button button6;
        private Button button4;
        private Button btnYirmiElliDolarArasiUrunler;
        private Label lblTakip;
    }
}