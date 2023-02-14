using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavNot
{
    public partial class NotGiris : Form
    {
        public NotGiris()
        {
            InitializeComponent();
        }

        string ad, soyad;
        int not1, not2, not3;
        double ort;
        bool adKontrol, soyadKontrol, not1Kontrol, not2Kontrol, not3Kontrol;

        void NotVeAdIste()
        {
            string[] isimListesi = txtAd.Text.Split(' ');
            foreach (var item in isimListesi)
            {
               ad += item.First().ToString().ToUpper() + item.Substring(1).ToLower()+" ";
            }

            //ad = txtAd.Text.First().ToString().ToUpper() + txtAd.Text.Substring(1).ToLower();
            soyad = txtSoyad.Text.ToUpper();

            not1Kontrol = int.TryParse(txtNot1.Text, out not1);
            not2Kontrol = int.TryParse(txtNot2.Text, out not2);
            not3Kontrol = int.TryParse(txtNot3.Text, out not3);

            ort = ((double)(not1 + not2 + not3)) / 3;
            ort = Math.Round(ort,2);
            adKontrol = ad.Any(char.IsDigit) || ad.Any(char.IsPunctuation);
            soyadKontrol = soyad.Any(char.IsDigit) || soyad.Any(char.IsPunctuation);

            if (!not1Kontrol || !not2Kontrol || !not3Kontrol)
            {
                MessageBox.Show("Lütfen not kısmına sadece sayı giriniz.");
            }
            if (adKontrol || soyadKontrol)
            {
                MessageBox.Show("Lütfen ad soyad kısmına sadece metin giriniz");
            }

        }


        private void btnKontrol_Click(object sender, EventArgs e)
        {


            NotVeAdIste();

            if (!adKontrol && !soyadKontrol && not1Kontrol && not2Kontrol && not3Kontrol)
            {
                Degerlendirme degerlendirme = new Degerlendirme();
                degerlendirme.lblAdSoyad.Text = $"{ad} {soyad}";
                degerlendirme.lblBasari.Text = ort >= 50 ? "Geçti" : "Kaldı";
                degerlendirme.lblNot.Text = ort.ToString();
                degerlendirme.Show();
            }
            else
            {
                Application.Restart();
            }

        }
    }
}
