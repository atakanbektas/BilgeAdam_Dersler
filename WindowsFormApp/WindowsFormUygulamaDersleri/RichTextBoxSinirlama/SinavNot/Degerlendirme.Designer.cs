namespace SinavNot
{
    partial class Degerlendirme
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.lblBasari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Not Ortalaması :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Başarı Durumu :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Location = new System.Drawing.Point(206, 26);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(444, 26);
            this.lblAdSoyad.TabIndex = 0;
            // 
            // lblNot
            // 
            this.lblNot.Location = new System.Drawing.Point(206, 81);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(444, 26);
            this.lblNot.TabIndex = 1;
            // 
            // lblBasari
            // 
            this.lblBasari.Location = new System.Drawing.Point(206, 137);
            this.lblBasari.Name = "lblBasari";
            this.lblBasari.Size = new System.Drawing.Size(444, 26);
            this.lblBasari.TabIndex = 1;
            // 
            // Degerlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 215);
            this.Controls.Add(this.lblBasari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Degerlendirme";
            this.Text = "Degerlendirme";
            this.Load += new System.EventHandler(this.Degerlendirme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Label lblNot;
        public System.Windows.Forms.Label lblBasari;
    }
}