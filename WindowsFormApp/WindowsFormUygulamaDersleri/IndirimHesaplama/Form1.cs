using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndirimHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal tutar = decimal.Parse(txtTutar.Text);
            decimal indirim = 0;

            if (chcBes.Checked)
            {
                indirim += tutar * 0.05m;
            }
            if (chcOn.Checked)
            {
                indirim += tutar * 0.1m;
            }
            if (chcOnOzel.Checked)
            {
                indirim += tutar * 0.1m;
            }

            label5.Text = (tutar - indirim).ToString();
            label6.Visible = true;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
