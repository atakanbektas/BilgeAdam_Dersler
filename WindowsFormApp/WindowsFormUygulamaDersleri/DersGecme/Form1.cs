using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersGecme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string[] ad = txtAd.Text.Trim().Split(' ');
            string sonucIsim = "";
            foreach (var item in ad)
            {
                sonucIsim += item.First().ToString().ToUpper() + item.Substring(1) + " ";
            }

           

            if (rbtnGecti.Checked)
            {
                Gecenler.Items.Add(sonucIsim +  txtSoyad.Text.ToUpper());
            }
            else
            {
                Kalanlar.Items.Add(sonucIsim +  txtSoyad.Text.ToUpper());

            }


        }
    }
}
