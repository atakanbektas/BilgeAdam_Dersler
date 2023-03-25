namespace HomePage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetList = new System.Windows.Forms.Button();
            this.txtSearchingWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetList
            // 
            this.btnGetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGetList.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnGetList.FlatAppearance.BorderSize = 0;
            this.btnGetList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGetList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGetList.Location = new System.Drawing.Point(47, 334);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(262, 41);
            this.btnGetList.TabIndex = 0;
            this.btnGetList.Text = "Listele";
            this.btnGetList.UseVisualStyleBackColor = false;
            // 
            // txtSearchingWord
            // 
            this.txtSearchingWord.Location = new System.Drawing.Point(47, 299);
            this.txtSearchingWord.Name = "txtSearchingWord";
            this.txtSearchingWord.Size = new System.Drawing.Size(262, 29);
            this.txtSearchingWord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(47, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama Sözcüğü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(47, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(47, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tür Seçiniz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvFilms
            // 
            this.dgvFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFilms.BackgroundColor = System.Drawing.Color.Cyan;
            this.dgvFilms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Location = new System.Drawing.Point(348, 42);
            this.dgvFilms.MultiSelect = false;
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.RowTemplate.Height = 25;
            this.dgvFilms.Size = new System.Drawing.Size(571, 333);
            this.dgvFilms.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(348, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "FİLMLER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 410);
            this.Controls.Add(this.dgvFilms);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchingWord);
            this.Controls.Add(this.btnGetList);
            this.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetList;
        private TextBox txtSearchingWord;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridView dgvFilms;
        private Label label3;
    }
}