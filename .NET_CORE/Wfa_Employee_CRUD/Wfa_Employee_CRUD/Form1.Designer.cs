namespace Wfa_Employee_CRUD
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.rdbEvli = new System.Windows.Forms.RadioButton();
            this.rdbBekar = new System.Windows.Forms.RadioButton();
            this.rdbBosanmis = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.grpMedeniHal = new System.Windows.Forms.GroupBox();
            this.grpCalisiyorMu = new System.Windows.Forms.GroupBox();
            this.rdbHayir = new System.Windows.Forms.RadioButton();
            this.rdbEvet = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpMedeniHal.SuspendLayout();
            this.grpCalisiyorMu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(102, 15);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(262, 30);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(102, 56);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(262, 30);
            this.txtSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // txtYas
            // 
            this.txtYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYas.Location = new System.Drawing.Point(102, 97);
            this.txtYas.Margin = new System.Windows.Forms.Padding(6);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(262, 30);
            this.txtYas.TabIndex = 2;
            // 
            // rdbEvli
            // 
            this.rdbEvli.AutoSize = true;
            this.rdbEvli.Location = new System.Drawing.Point(6, 29);
            this.rdbEvli.Name = "rdbEvli";
            this.rdbEvli.Size = new System.Drawing.Size(55, 24);
            this.rdbEvli.TabIndex = 3;
            this.rdbEvli.TabStop = true;
            this.rdbEvli.Text = "Evli";
            this.rdbEvli.UseVisualStyleBackColor = true;
            // 
            // rdbBekar
            // 
            this.rdbBekar.AutoSize = true;
            this.rdbBekar.Location = new System.Drawing.Point(101, 29);
            this.rdbBekar.Name = "rdbBekar";
            this.rdbBekar.Size = new System.Drawing.Size(74, 24);
            this.rdbBekar.TabIndex = 3;
            this.rdbBekar.TabStop = true;
            this.rdbBekar.Text = "Bekar";
            this.rdbBekar.UseVisualStyleBackColor = true;
            // 
            // rdbBosanmis
            // 
            this.rdbBosanmis.AutoSize = true;
            this.rdbBosanmis.Location = new System.Drawing.Point(208, 29);
            this.rdbBosanmis.Name = "rdbBosanmis";
            this.rdbBosanmis.Size = new System.Drawing.Size(105, 24);
            this.rdbBosanmis.TabIndex = 3;
            this.rdbBosanmis.TabStop = true;
            this.rdbBosanmis.Text = "Bosanmis";
            this.rdbBosanmis.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yaş";
            // 
            // grpMedeniHal
            // 
            this.grpMedeniHal.Controls.Add(this.rdbEvli);
            this.grpMedeniHal.Controls.Add(this.rdbBekar);
            this.grpMedeniHal.Controls.Add(this.rdbBosanmis);
            this.grpMedeniHal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMedeniHal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpMedeniHal.Location = new System.Drawing.Point(21, 152);
            this.grpMedeniHal.Name = "grpMedeniHal";
            this.grpMedeniHal.Size = new System.Drawing.Size(343, 84);
            this.grpMedeniHal.TabIndex = 4;
            this.grpMedeniHal.TabStop = false;
            this.grpMedeniHal.Text = "Medeni Hali";
            // 
            // grpCalisiyorMu
            // 
            this.grpCalisiyorMu.Controls.Add(this.rdbHayir);
            this.grpCalisiyorMu.Controls.Add(this.rdbEvet);
            this.grpCalisiyorMu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCalisiyorMu.Location = new System.Drawing.Point(21, 253);
            this.grpCalisiyorMu.Name = "grpCalisiyorMu";
            this.grpCalisiyorMu.Size = new System.Drawing.Size(343, 84);
            this.grpCalisiyorMu.TabIndex = 5;
            this.grpCalisiyorMu.TabStop = false;
            this.grpCalisiyorMu.Text = "Çalışıyor mu ?";
            // 
            // rdbHayir
            // 
            this.rdbHayir.AutoSize = true;
            this.rdbHayir.Location = new System.Drawing.Point(193, 39);
            this.rdbHayir.Name = "rdbHayir";
            this.rdbHayir.Size = new System.Drawing.Size(68, 24);
            this.rdbHayir.TabIndex = 4;
            this.rdbHayir.TabStop = true;
            this.rdbHayir.Text = "Hayır";
            this.rdbHayir.UseVisualStyleBackColor = true;
            // 
            // rdbEvet
            // 
            this.rdbEvet.AutoSize = true;
            this.rdbEvet.Location = new System.Drawing.Point(56, 39);
            this.rdbEvet.Name = "rdbEvet";
            this.rdbEvet.Size = new System.Drawing.Size(63, 24);
            this.rdbEvet.TabIndex = 4;
            this.rdbEvet.TabStop = true;
            this.rdbEvet.Text = "Evet";
            this.rdbEvet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(84, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(84, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(84, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = ":";
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.ItemHeight = 25;
            this.lstPersonel.Location = new System.Drawing.Point(429, 15);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(499, 229);
            this.lstPersonel.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEkle.Location = new System.Drawing.Point(429, 253);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(335, 88);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(770, 300);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(158, 41);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Location = new System.Drawing.Point(770, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(158, 41);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 348);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstPersonel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpCalisiyorMu);
            this.Controls.Add(this.grpMedeniHal);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMedeniHal.ResumeLayout(false);
            this.grpMedeniHal.PerformLayout();
            this.grpCalisiyorMu.ResumeLayout(false);
            this.grpCalisiyorMu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.RadioButton rdbEvli;
        private System.Windows.Forms.RadioButton rdbBekar;
        private System.Windows.Forms.RadioButton rdbBosanmis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpMedeniHal;
        private System.Windows.Forms.GroupBox grpCalisiyorMu;
        private System.Windows.Forms.RadioButton rdbHayir;
        private System.Windows.Forms.RadioButton rdbEvet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

