namespace CokluForm
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
            this.btnDialog = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(340, 74);
            this.btnDialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(290, 69);
            this.btnDialog.TabIndex = 0;
            this.btnDialog.Text = "Dialog Form Ac";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(25, 74);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(290, 69);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Normal Form Aç";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 211);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnDialog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.Button btnNormal;
    }
}

