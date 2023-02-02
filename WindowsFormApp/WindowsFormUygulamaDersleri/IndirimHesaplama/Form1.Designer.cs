namespace IndirimHesaplama
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
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.chcOnOzel = new System.Windows.Forms.CheckBox();
            this.chcOn = new System.Windows.Forms.CheckBox();
            this.chcBes = new System.Windows.Forms.CheckBox();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp1
            // 
            this.grp1.BackColor = System.Drawing.Color.Transparent;
            this.grp1.BackgroundImage = global::IndirimHesaplama.Properties.Resources.channels4_profile;
            this.grp1.Controls.Add(this.chcBes);
            this.grp1.Controls.Add(this.label6);
            this.grp1.Controls.Add(this.chcOnOzel);
            this.grp1.Controls.Add(this.chcOn);
            this.grp1.Controls.Add(this.label5);
            this.grp1.Controls.Add(this.label1);
            this.grp1.Controls.Add(this.btnHesapla);
            this.grp1.Controls.Add(this.txtTutar);
            this.grp1.Location = new System.Drawing.Point(37, 18);
            this.grp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp1.Size = new System.Drawing.Size(329, 489);
            this.grp1.TabIndex = 0;
            this.grp1.TabStop = false;
            this.grp1.Text = "İndirimler";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(187, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 47);
            this.label6.TabIndex = 4;
            this.label6.Text = "₺";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(68, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 47);
            this.label5.TabIndex = 3;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TUTAR";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(24, 77);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(281, 60);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(95, 43);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(210, 26);
            this.txtTutar.TabIndex = 0;
            // 
            // chcOnOzel
            // 
            this.chcOnOzel.AutoSize = true;
            this.chcOnOzel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chcOnOzel.Location = new System.Drawing.Point(78, 321);
            this.chcOnOzel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chcOnOzel.Name = "chcOnOzel";
            this.chcOnOzel.Size = new System.Drawing.Size(163, 24);
            this.chcOnOzel.TabIndex = 0;
            this.chcOnOzel.Text = "%10 Özel İndirim";
            this.chcOnOzel.UseVisualStyleBackColor = true;
            // 
            // chcOn
            // 
            this.chcOn.AutoSize = true;
            this.chcOn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chcOn.Location = new System.Drawing.Point(78, 290);
            this.chcOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chcOn.Name = "chcOn";
            this.chcOn.Size = new System.Drawing.Size(210, 24);
            this.chcOn.TabIndex = 0;
            this.chcOn.Text = "%10 kampanya indirimi";
            this.chcOn.UseVisualStyleBackColor = true;
            // 
            // chcBes
            // 
            this.chcBes.AutoSize = true;
            this.chcBes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chcBes.Location = new System.Drawing.Point(78, 259);
            this.chcBes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chcBes.Name = "chcBes";
            this.chcBes.Size = new System.Drawing.Size(154, 24);
            this.chcBes.TabIndex = 0;
            this.chcBes.Text = "%5 nakit indirim";
            this.chcBes.UseVisualStyleBackColor = true;
            // 
            // grp2
            // 
            this.grp2.BackgroundImage = global::IndirimHesaplama.Properties.Resources.abidas;
            this.grp2.Location = new System.Drawing.Point(383, 18);
            this.grp2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp2.Name = "grp2";
            this.grp2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp2.Size = new System.Drawing.Size(463, 489);
            this.grp2.TabIndex = 1;
            this.grp2.TabStop = false;
            this.grp2.Text = "Hesaplama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IndirimHesaplama.Properties.Resources.abidas;
            this.ClientSize = new System.Drawing.Size(859, 557);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.CheckBox chcOnOzel;
        private System.Windows.Forms.CheckBox chcOn;
        private System.Windows.Forms.CheckBox chcBes;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

