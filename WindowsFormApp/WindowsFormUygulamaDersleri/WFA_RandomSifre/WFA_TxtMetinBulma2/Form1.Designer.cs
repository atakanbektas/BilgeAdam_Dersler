namespace WFA_TxtMetinBulma2
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
            this.rtxtMetin = new System.Windows.Forms.RichTextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAranacak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtMetin
            // 
            this.rtxtMetin.Location = new System.Drawing.Point(12, 105);
            this.rtxtMetin.Name = "rtxtMetin";
            this.rtxtMetin.Size = new System.Drawing.Size(818, 494);
            this.rtxtMetin.TabIndex = 0;
            this.rtxtMetin.Text = "";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAra.Location = new System.Drawing.Point(686, 605);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(144, 45);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAranacak
            // 
            this.txtAranacak.Location = new System.Drawing.Point(396, 605);
            this.txtAranacak.Multiline = true;
            this.txtAranacak.Name = "txtAranacak";
            this.txtAranacak.Size = new System.Drawing.Size(284, 45);
            this.txtAranacak.TabIndex = 2;
            this.txtAranacak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(173, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranacak Kelime :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDosyaSec.Location = new System.Drawing.Point(12, 12);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(818, 87);
            this.btnDosyaSec.TabIndex = 5;
            this.btnDosyaSec.Text = "DOSYA SEÇ";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(861, 663);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAranacak);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.rtxtMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtMetin;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAranacak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDosyaSec;
    }
}

