namespace FormGirisUygulamaları
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.btnIsimGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIsim.Location = new System.Drawing.Point(16, 48);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(454, 35);
            this.txtIsim.TabIndex = 0;
            // 
            // lblIsim
            // 
            this.lblIsim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsim.AutoSize = true;
            this.lblIsim.BackColor = System.Drawing.Color.Transparent;
            this.lblIsim.Location = new System.Drawing.Point(147, 13);
            this.lblIsim.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(186, 29);
            this.lblIsim.TabIndex = 1;
            this.lblIsim.Text = "İsminizi giriniz:";
            // 
            // btnIsimGoster
            // 
            this.btnIsimGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIsimGoster.Location = new System.Drawing.Point(16, 100);
            this.btnIsimGoster.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnIsimGoster.Name = "btnIsimGoster";
            this.btnIsimGoster.Size = new System.Drawing.Size(456, 74);
            this.btnIsimGoster.TabIndex = 2;
            this.btnIsimGoster.Text = "Göster";
            this.btnIsimGoster.UseVisualStyleBackColor = true;
            this.btnIsimGoster.Click += new System.EventHandler(this.btnIsimGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormGirisUygulamaları.Properties.Resources.GRİ_BACK;
            this.ClientSize = new System.Drawing.Size(507, 206);
            this.Controls.Add(this.btnIsimGoster);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.txtIsim);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Button btnIsimGoster;
    }
}

