using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreZorlukDerecesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sayilar = "0123456789";
        string ozelKarakterler = "!'^+%&/()=?_-";
        string buyukHarfler = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
        int sayacSayi = 0;
        int sayacBuyukHarf = 0;
        int sayacOzelKarakter = 0;
        int sayacUzunluk = 0;
        int sayac = 0;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {           

            if (txtSifre.Text.Length < 6)
            {
                sayacBuyukHarf = 0;
                sayacOzelKarakter = 0;
                sayacSayi = 0;
                sayacUzunluk = 0;
            }
            else if (txtSifre.Text.Length >= 6)
            {
                sayacUzunluk = 1;
                if (sayilar.Contains(txtSifre.Text[txtSifre.Text.Length-1]))
                {
                    sayacSayi = 1;
                }                
                else if (ozelKarakterler.Contains(txtSifre.Text[txtSifre.Text.Length-1]))
                {
                    sayacOzelKarakter = 1;
                }
                else if (buyukHarfler.Contains(txtSifre.Text[txtSifre.Text.Length-1]))
                {
                    sayacBuyukHarf = 1;
                }
               
            }

            sayac = sayacBuyukHarf + sayacOzelKarakter + sayacSayi + sayacUzunluk;
            if (sayac == 0)
            {
                lblLevel.Text = "Çok Düşük";
                lblLevel.ForeColor = Color.Red;
            }
            else if (sayac == 1)
            {
                lblLevel.Text = "Düşük";
                lblLevel.ForeColor = Color.OrangeRed;
            }
            else if (sayac == 2)
            {
                lblLevel.Text = "Orta";
                lblLevel.ForeColor = Color.DarkOrange;
            }
            else if (sayac == 3)
            {
                lblLevel.Text = "Yüksek";
                lblLevel.ForeColor = Color.Green;
            }
            else if (sayac == 4)
            {
                lblLevel.Text = "Çok Yüksek";
                lblLevel.ForeColor = Color.DarkGreen;
            }
        }
    }
}
