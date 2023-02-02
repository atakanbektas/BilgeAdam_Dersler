using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelEkle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string[] isimler = txtAd.Text.Trim().Split(' ');
            string isimSon = "";
            string soyad = txtSoyad.Text;
            string sehir = txtSehir.Text;

            foreach (var item in isimler)
            {
                isimSon += item.First().ToString().ToUpper() + item.Substring(1) + " ";
            }
            lstListe.Items.Add(isimSon+soyad.ToUpper()+" "+sehir.ToUpper());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
