namespace DersGecme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.rbtnGecti = new System.Windows.Forms.RadioButton();
            this.rbtnKaldi = new System.Windows.Forms.RadioButton();
            this.btnGonder = new System.Windows.Forms.Button();
            this.Gecenler = new System.Windows.Forms.ListBox();
            this.Kalanlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(128, 14);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(122, 26);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(128, 46);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(122, 26);
            this.txtSoyad.TabIndex = 1;
            // 
            // rbtnGecti
            // 
            this.rbtnGecti.AutoSize = true;
            this.rbtnGecti.Location = new System.Drawing.Point(58, 101);
            this.rbtnGecti.Name = "rbtnGecti";
            this.rbtnGecti.Size = new System.Drawing.Size(70, 24);
            this.rbtnGecti.TabIndex = 2;
            this.rbtnGecti.TabStop = true;
            this.rbtnGecti.Text = "Geçti";
            this.rbtnGecti.UseVisualStyleBackColor = true;
            // 
            // rbtnKaldi
            // 
            this.rbtnKaldi.AutoSize = true;
            this.rbtnKaldi.Location = new System.Drawing.Point(184, 101);
            this.rbtnKaldi.Name = "rbtnKaldi";
            this.rbtnKaldi.Size = new System.Drawing.Size(66, 24);
            this.rbtnKaldi.TabIndex = 2;
            this.rbtnKaldi.TabStop = true;
            this.rbtnKaldi.Text = "Kaldı";
            this.rbtnKaldi.UseVisualStyleBackColor = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(58, 159);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(192, 37);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // Gecenler
            // 
            this.Gecenler.FormattingEnabled = true;
            this.Gecenler.ItemHeight = 20;
            this.Gecenler.Location = new System.Drawing.Point(300, 12);
            this.Gecenler.Name = "Gecenler";
            this.Gecenler.Size = new System.Drawing.Size(202, 184);
            this.Gecenler.TabIndex = 4;
            // 
            // Kalanlar
            // 
            this.Kalanlar.FormattingEnabled = true;
            this.Kalanlar.ItemHeight = 20;
            this.Kalanlar.Location = new System.Drawing.Point(524, 12);
            this.Kalanlar.Name = "Kalanlar";
            this.Kalanlar.Size = new System.Drawing.Size(202, 184);
            this.Kalanlar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 263);
            this.Controls.Add(this.Kalanlar);
            this.Controls.Add(this.Gecenler);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.rbtnKaldi);
            this.Controls.Add(this.rbtnGecti);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.RadioButton rbtnGecti;
        private System.Windows.Forms.RadioButton rbtnKaldi;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ListBox Gecenler;
        private System.Windows.Forms.ListBox Kalanlar;
    }
}

