using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaasHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal maas = decimal.Parse(txtMaas.Text);
            decimal zam = 0;

            if (chkIngilizce.Checked)
            {
                zam += maas * 0.05m;
            }
            if (chcFransizca.Checked)
            {
                zam += maas * 0.05m;
            }
            if (chcAlmanca.Checked)
            {
                zam += maas * 0.05m;
            }
            if (rbtn1.Checked)
            {
                zam += maas * 0.05m;
            }
            if (rbtn2.Checked)
            {
                zam += maas * 0.10m;
            }
            if (rbtn3.Checked)
            {
                zam += maas * 0.20m;
            }
            if (rbtnEvli.Checked)
            {
                zam += maas * 0.05m;
            }
            if (rbtnBekar.Checked)
            {
                zam += maas * 0.50m;
            }

            lblSonuc.Text = (maas + zam).ToString();
        }

    }
}
