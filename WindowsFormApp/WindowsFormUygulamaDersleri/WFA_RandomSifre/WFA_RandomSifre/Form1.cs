using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_RandomSifre
{
    internal partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        List<int> ASCII = new List<int>();
        bool buyukse, kucukse, ozelse, rakamsa;
        int randomIndex;
        string sifre = string.Empty;

        void btnUret_Click(object sender, EventArgs e)
        {

            CheckBoxKontrol(); // hepsinin bool değerlerini aldım.
            CheckBoxaGoreListeOlustur(); // elemanları kullacının seçimlerini içeren liste oluşturdum.         
            SifreOlusturEkle();
        }
        void CheckBoxKontrol()
        {
            buyukse = chkBuyuk.Checked;
            kucukse = chkKucuk.Checked;
            ozelse = chkOzel.Checked;
            rakamsa = chkRakam.Checked;
        }
        void CheckBoxaGoreListeOlustur()
        {
            for (int i = 32; i <= 125; i++)
            {
                if (rakamsa && i >= 48 && i <= 57)
                {
                    ASCII.Add(i);
                }
                if (buyukse && i >= 65 && i <= 90)
                {
                    ASCII.Add(i);
                }
                if (kucukse && i >= 97 && i <= 122)
                {
                    ASCII.Add(i);
                }
                if (ozelse && ((i >= 33 && i < 48) || (i >= 58 && i < 65) || (i >= 91 && i < 97)))
                {
                    ASCII.Add(i);
                }
            }
        }
        void RandomIndexAl()
        {
            randomIndex = rnd.Next(0, ASCII.Count);
        }
        void SifreOlusturEkle()
        {
            lstBox.Items.Clear();

            for (int i = 0; i < numSayi.Value; i++)
            {
                for (int j = 0; j < numUzunluk.Value; j++)
                {
                    RandomIndexAl();
                    sifre += Convert.ToChar(ASCII[randomIndex]);
                }
                lstBox.Items.Add($"{i+1}-)    {sifre}");
                sifre = string.Empty;
            }
            ASCII.Clear();
        }       
    }
}
