namespace RichTextBoxSinirlama
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
            this.txtGiris = new System.Windows.Forms.RichTextBox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(65, 43);
            this.txtGiris.MaxLength = 255;
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(327, 139);
            this.txtGiris.TabIndex = 0;
            this.txtGiris.Text = "";
            this.txtGiris.TextChanged += new System.EventHandler(this.txtGiris_TextChanged);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Location = new System.Drawing.Point(61, 185);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(39, 20);
            this.lblGiris.TabIndex = 1;
            this.lblGiris.Text = "255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 270);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.txtGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtGiris;
        private System.Windows.Forms.Label lblGiris;
    }
}

