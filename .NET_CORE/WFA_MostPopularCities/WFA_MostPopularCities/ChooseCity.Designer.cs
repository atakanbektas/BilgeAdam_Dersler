namespace WFA_MostPopularCities
{
    partial class ChooseCity
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
            this.lstCities = new System.Windows.Forms.ListBox();
            this.btnSeç = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCities
            // 
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 15;
            this.lstCities.Location = new System.Drawing.Point(12, 12);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(768, 304);
            this.lstCities.TabIndex = 0;
            // 
            // btnSeç
            // 
            this.btnSeç.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeç.Location = new System.Drawing.Point(12, 322);
            this.btnSeç.Name = "btnSeç";
            this.btnSeç.Size = new System.Drawing.Size(768, 63);
            this.btnSeç.TabIndex = 1;
            this.btnSeç.Text = "Seç";
            this.btnSeç.UseVisualStyleBackColor = true;
            this.btnSeç.Click += new System.EventHandler(this.btnSeç_Click);
            // 
            // ChooseCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 397);
            this.Controls.Add(this.btnSeç);
            this.Controls.Add(this.lstCities);
            this.Name = "ChooseCity";
            this.Text = "ChooseCity";
            this.Load += new System.EventHandler(this.ChooseCity_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstCities;
        private Button btnSeç;
    }
}