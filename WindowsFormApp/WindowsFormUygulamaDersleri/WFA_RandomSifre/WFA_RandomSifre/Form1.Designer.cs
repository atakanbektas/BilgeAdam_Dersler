namespace WFA_RandomSifre
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.chkKucuk = new System.Windows.Forms.CheckBox();
            this.chkBuyuk = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkOzel = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSayi = new System.Windows.Forms.NumericUpDown();
            this.numUzunluk = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 20;
            this.lstBox.Location = new System.Drawing.Point(350, 0);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(537, 408);
            this.lstBox.TabIndex = 0;
            // 
            // chkKucuk
            // 
            this.chkKucuk.AutoSize = true;
            this.chkKucuk.Checked = true;
            this.chkKucuk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKucuk.Location = new System.Drawing.Point(35, 75);
            this.chkKucuk.Name = "chkKucuk";
            this.chkKucuk.Size = new System.Drawing.Size(128, 26);
            this.chkKucuk.TabIndex = 1;
            this.chkKucuk.Text = "Küçük Harf";
            this.chkKucuk.UseVisualStyleBackColor = true;
            // 
            // chkBuyuk
            // 
            this.chkBuyuk.AutoSize = true;
            this.chkBuyuk.Checked = true;
            this.chkBuyuk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBuyuk.Location = new System.Drawing.Point(35, 107);
            this.chkBuyuk.Name = "chkBuyuk";
            this.chkBuyuk.Size = new System.Drawing.Size(128, 26);
            this.chkBuyuk.TabIndex = 1;
            this.chkBuyuk.Text = "Büyük Harf";
            this.chkBuyuk.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Checked = true;
            this.chkRakam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRakam.Location = new System.Drawing.Point(35, 139);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(90, 26);
            this.chkRakam.TabIndex = 1;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkOzel
            // 
            this.chkOzel.AutoSize = true;
            this.chkOzel.Checked = true;
            this.chkOzel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOzel.Location = new System.Drawing.Point(35, 171);
            this.chkOzel.Name = "chkOzel";
            this.chkOzel.Size = new System.Drawing.Size(151, 26);
            this.chkOzel.TabIndex = 1;
            this.chkOzel.Text = "Özel Karakter";
            this.chkOzel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnUret);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numSayi);
            this.groupBox1.Controls.Add(this.numUzunluk);
            this.groupBox1.Controls.Add(this.chkOzel);
            this.groupBox1.Controls.Add(this.chkRakam);
            this.groupBox1.Controls.Add(this.chkBuyuk);
            this.groupBox1.Controls.Add(this.chkKucuk);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 408);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(230, 336);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(91, 60);
            this.btnUret.TabIndex = 4;
            this.btnUret.Text = "ÜRET";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre Uzunluğu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şifre Sayısı";
            // 
            // numSayi
            // 
            this.numSayi.Location = new System.Drawing.Point(230, 270);
            this.numSayi.Name = "numSayi";
            this.numSayi.Size = new System.Drawing.Size(91, 27);
            this.numSayi.TabIndex = 2;
            // 
            // numUzunluk
            // 
            this.numUzunluk.Location = new System.Drawing.Point(230, 303);
            this.numUzunluk.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUzunluk.Name = "numUzunluk";
            this.numUzunluk.Size = new System.Drawing.Size(91, 27);
            this.numUzunluk.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(887, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUzunluk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.CheckBox chkKucuk;
        private System.Windows.Forms.CheckBox chkBuyuk;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkOzel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSayi;
        private System.Windows.Forms.NumericUpDown numUzunluk;
    }
}

