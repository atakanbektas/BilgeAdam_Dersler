using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxSinirlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtGiris_TextChanged(object sender, EventArgs e)
        {
            lblGiris.Text = (txtGiris.MaxLength - txtGiris.Text.Length).ToString();
            lblGiris.ForeColor = Color.FromArgb(txtGiris.Text.Length, 0, 0);
        }
    }
}
