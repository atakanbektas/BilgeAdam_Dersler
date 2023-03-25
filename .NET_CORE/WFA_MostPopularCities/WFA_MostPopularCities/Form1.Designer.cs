namespace WFA_MostPopularCities
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
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.nudPlakaNum = new System.Windows.Forms.NumericUpDown();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPopularProduct = new System.Windows.Forms.ListBox();
            this.btnDeletecCity = new System.Windows.Forms.Button();
            this.txtPopularProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOzellikEkle = new System.Windows.Forms.Button();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlakaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(70, 50);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(230, 29);
            this.txtCityName.TabIndex = 0;
            // 
            // nudPlakaNum
            // 
            this.nudPlakaNum.Location = new System.Drawing.Point(306, 50);
            this.nudPlakaNum.Name = "nudPlakaNum";
            this.nudPlakaNum.Size = new System.Drawing.Size(55, 29);
            this.nudPlakaNum.TabIndex = 1;
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddCity.Location = new System.Drawing.Point(367, 50);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(107, 29);
            this.btnAddCity.TabIndex = 2;
            this.btnAddCity.Text = "Ekle";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sehir Adı";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(304, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plaka No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstPopularProduct
            // 
            this.lstPopularProduct.FormattingEnabled = true;
            this.lstPopularProduct.ItemHeight = 21;
            this.lstPopularProduct.Location = new System.Drawing.Point(682, 85);
            this.lstPopularProduct.Name = "lstPopularProduct";
            this.lstPopularProduct.Size = new System.Drawing.Size(400, 424);
            this.lstPopularProduct.TabIndex = 4;
            // 
            // btnDeletecCity
            // 
            this.btnDeletecCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeletecCity.Location = new System.Drawing.Point(70, 515);
            this.btnDeletecCity.Name = "btnDeletecCity";
            this.btnDeletecCity.Size = new System.Drawing.Size(404, 29);
            this.btnDeletecCity.TabIndex = 2;
            this.btnDeletecCity.Text = "Sil";
            this.btnDeletecCity.UseVisualStyleBackColor = false;
            this.btnDeletecCity.Click += new System.EventHandler(this.btnDeletecCity_Click);
            // 
            // txtPopularProduct
            // 
            this.txtPopularProduct.Location = new System.Drawing.Point(682, 50);
            this.txtPopularProduct.Name = "txtPopularProduct";
            this.txtPopularProduct.Size = new System.Drawing.Size(287, 29);
            this.txtPopularProduct.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(809, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meşhur Özelliği";
            // 
            // btnOzellikEkle
            // 
            this.btnOzellikEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOzellikEkle.Location = new System.Drawing.Point(975, 50);
            this.btnOzellikEkle.Name = "btnOzellikEkle";
            this.btnOzellikEkle.Size = new System.Drawing.Size(107, 29);
            this.btnOzellikEkle.TabIndex = 2;
            this.btnOzellikEkle.Text = "Ekle";
            this.btnOzellikEkle.UseVisualStyleBackColor = false;
            this.btnOzellikEkle.Click += new System.EventHandler(this.btnOzellikEkle_Click);
            // 
            // lstCities
            // 
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 21;
            this.lstCities.Location = new System.Drawing.Point(70, 85);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(404, 424);
            this.lstCities.TabIndex = 4;
            this.lstCities.SelectedIndexChanged += new System.EventHandler(this.lstCities_SelectedIndexChanged);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteProduct.Location = new System.Drawing.Point(682, 514);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(400, 29);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Sil";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 626);
            this.Controls.Add(this.lstCities);
            this.Controls.Add(this.lstPopularProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnDeletecCity);
            this.Controls.Add(this.btnOzellikEkle);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.nudPlakaNum);
            this.Controls.Add(this.txtPopularProduct);
            this.Controls.Add(this.txtCityName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlakaNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCityName;
        private NumericUpDown nudPlakaNum;
        private Button btnAddCity;
        private Label label1;
        private Label label2;
        private ListBox lstPopularProduct;
        private Button btnDeletecCity;
        private TextBox txtPopularProduct;
        private Label label3;
        private Button btnOzellikEkle;
        private ListBox lstCities;
        private Button btnDeleteProduct;
    }
}