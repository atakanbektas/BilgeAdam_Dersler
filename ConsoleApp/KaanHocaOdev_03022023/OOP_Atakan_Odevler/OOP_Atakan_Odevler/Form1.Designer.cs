namespace OOP_Atakan_Odevler
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
            this.cbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.cbNumaralar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDepartmanOgren = new System.Windows.Forms.Button();
            this.btnNumaraOgren = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Numarası Öğrenme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbDepartmanlar
            // 
            this.cbDepartmanlar.FormattingEnabled = true;
            this.cbDepartmanlar.Location = new System.Drawing.Point(10, 50);
            this.cbDepartmanlar.Name = "cbDepartmanlar";
            this.cbDepartmanlar.Size = new System.Drawing.Size(158, 21);
            this.cbDepartmanlar.TabIndex = 2;
            // 
            // cbNumaralar
            // 
            this.cbNumaralar.FormattingEnabled = true;
            this.cbNumaralar.Location = new System.Drawing.Point(34, 69);
            this.cbNumaralar.Name = "cbNumaralar";
            this.cbNumaralar.Size = new System.Drawing.Size(121, 21);
            this.cbNumaralar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 62);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numara ile Departman Ogrenme";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDepartmanOgren
            // 
            this.btnDepartmanOgren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanOgren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDepartmanOgren.Location = new System.Drawing.Point(34, 73);
            this.btnDepartmanOgren.Name = "btnDepartmanOgren";
            this.btnDepartmanOgren.Size = new System.Drawing.Size(121, 62);
            this.btnDepartmanOgren.TabIndex = 4;
            this.btnDepartmanOgren.Text = "Numara Ogren";
            this.btnDepartmanOgren.UseVisualStyleBackColor = true;
            this.btnDepartmanOgren.Click += new System.EventHandler(this.btnNumaraOgren_Click);
            // 
            // btnNumaraOgren
            // 
            this.btnNumaraOgren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNumaraOgren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNumaraOgren.Location = new System.Drawing.Point(13, 96);
            this.btnNumaraOgren.Name = "btnNumaraOgren";
            this.btnNumaraOgren.Size = new System.Drawing.Size(158, 48);
            this.btnNumaraOgren.TabIndex = 4;
            this.btnNumaraOgren.Text = "Departman Ogren";
            this.btnNumaraOgren.UseVisualStyleBackColor = true;
            this.btnNumaraOgren.Click += new System.EventHandler(this.btnDepartmanOgren_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnNumaraOgren);
            this.panel1.Controls.Add(this.cbNumaralar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(31, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 165);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnDepartmanOgren);
            this.panel2.Controls.Add(this.cbDepartmanlar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(31, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 138);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(247, 374);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDepartmanOgren;
        private System.Windows.Forms.Button btnNumaraOgren;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox cbDepartmanlar;
        public System.Windows.Forms.ComboBox cbNumaralar;
    }
}

