namespace WfaNortwind
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
            this.btnIlkCalisan = new System.Windows.Forms.Button();
            this.btnSonEmployee = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnAIceren = new System.Windows.Forms.Button();
            this.btnAndrewBul = new System.Windows.Forms.Button();
            this.btnEnPahaliPro = new System.Windows.Forms.Button();
            this.btnEnUcuzProduct = new System.Windows.Forms.Button();
            this.btnOrtalamaUstu = new System.Windows.Forms.Button();
            this.btnStokSirala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(81, 86);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowTemplate.Height = 25;
            this.dgvTable.Size = new System.Drawing.Size(636, 351);
            this.dgvTable.TabIndex = 0;
            // 
            // btnIlkCalisan
            // 
            this.btnIlkCalisan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIlkCalisan.Location = new System.Drawing.Point(12, 12);
            this.btnIlkCalisan.Name = "btnIlkCalisan";
            this.btnIlkCalisan.Size = new System.Drawing.Size(111, 34);
            this.btnIlkCalisan.TabIndex = 1;
            this.btnIlkCalisan.Text = "Ilk Calisan";
            this.btnIlkCalisan.UseVisualStyleBackColor = true;
            this.btnIlkCalisan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSonEmployee
            // 
            this.btnSonEmployee.Location = new System.Drawing.Point(129, 12);
            this.btnSonEmployee.Name = "btnSonEmployee";
            this.btnSonEmployee.Size = new System.Drawing.Size(140, 34);
            this.btnSonEmployee.TabIndex = 2;
            this.btnSonEmployee.Text = "Son Calisan";
            this.btnSonEmployee.UseVisualStyleBackColor = true;
            this.btnSonEmployee.Click += new System.EventHandler(this.btnSonEmployee_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(275, 12);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(105, 34);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "aIleBaslayanlar";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnAIceren
            // 
            this.btnAIceren.Location = new System.Drawing.Point(386, 12);
            this.btnAIceren.Name = "btnAIceren";
            this.btnAIceren.Size = new System.Drawing.Size(105, 34);
            this.btnAIceren.TabIndex = 3;
            this.btnAIceren.Text = "A İçerenler";
            this.btnAIceren.UseVisualStyleBackColor = true;
            this.btnAIceren.Click += new System.EventHandler(this.btnAIceren_Click);
            // 
            // btnAndrewBul
            // 
            this.btnAndrewBul.Location = new System.Drawing.Point(497, 12);
            this.btnAndrewBul.Name = "btnAndrewBul";
            this.btnAndrewBul.Size = new System.Drawing.Size(105, 34);
            this.btnAndrewBul.TabIndex = 3;
            this.btnAndrewBul.Text = "Andrew";
            this.btnAndrewBul.UseVisualStyleBackColor = true;
            this.btnAndrewBul.Click += new System.EventHandler(this.btnAndrewBul_Click);
            // 
            // btnEnPahaliPro
            // 
            this.btnEnPahaliPro.Location = new System.Drawing.Point(612, 12);
            this.btnEnPahaliPro.Name = "btnEnPahaliPro";
            this.btnEnPahaliPro.Size = new System.Drawing.Size(105, 52);
            this.btnEnPahaliPro.TabIndex = 3;
            this.btnEnPahaliPro.Text = "En Pahalı Product";
            this.btnEnPahaliPro.UseVisualStyleBackColor = true;
            this.btnEnPahaliPro.Click += new System.EventHandler(this.btnEnPahaliPro_Click);
            // 
            // btnEnUcuzProduct
            // 
            this.btnEnUcuzProduct.Location = new System.Drawing.Point(12, 52);
            this.btnEnUcuzProduct.Name = "btnEnUcuzProduct";
            this.btnEnUcuzProduct.Size = new System.Drawing.Size(169, 28);
            this.btnEnUcuzProduct.TabIndex = 3;
            this.btnEnUcuzProduct.Text = "En Ucuz Product";
            this.btnEnUcuzProduct.UseVisualStyleBackColor = true;
            this.btnEnUcuzProduct.Click += new System.EventHandler(this.btnEnUcuzProduct_Click);
            // 
            // btnOrtalamaUstu
            // 
            this.btnOrtalamaUstu.Location = new System.Drawing.Point(187, 52);
            this.btnOrtalamaUstu.Name = "btnOrtalamaUstu";
            this.btnOrtalamaUstu.Size = new System.Drawing.Size(133, 28);
            this.btnOrtalamaUstu.TabIndex = 3;
            this.btnOrtalamaUstu.Text = "Ortalama Ustu Urunler";
            this.btnOrtalamaUstu.UseVisualStyleBackColor = true;
            this.btnOrtalamaUstu.Click += new System.EventHandler(this.btnOrtalamaUstu_Click);
            // 
            // btnStokSirala
            // 
            this.btnStokSirala.Location = new System.Drawing.Point(326, 52);
            this.btnStokSirala.Name = "btnStokSirala";
            this.btnStokSirala.Size = new System.Drawing.Size(133, 28);
            this.btnStokSirala.TabIndex = 3;
            this.btnStokSirala.Text = "Stok Sırala";
            this.btnStokSirala.UseVisualStyleBackColor = true;
            this.btnStokSirala.Click += new System.EventHandler(this.btnStokSirala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnEnUcuzProduct);
            this.Controls.Add(this.btnEnPahaliPro);
            this.Controls.Add(this.btnAndrewBul);
            this.Controls.Add(this.btnStokSirala);
            this.Controls.Add(this.btnOrtalamaUstu);
            this.Controls.Add(this.btnAIceren);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnSonEmployee);
            this.Controls.Add(this.btnIlkCalisan);
            this.Controls.Add(this.dgvTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTable;
        private Button btnIlkCalisan;
        private Button btnSonEmployee;
        private Button btnA;
        private Button btnAIceren;
        private Button btnAndrewBul;
        private Button btnEnPahaliPro;
        private Button btnEnUcuzProduct;
        private Button btnOrtalamaUstu;
        private Button btnStokSirala;
    }
}