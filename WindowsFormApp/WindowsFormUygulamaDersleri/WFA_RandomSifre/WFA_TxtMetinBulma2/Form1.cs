using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WFA_TxtMetinBulma2
{
    
    public partial class Form1 : Form
    {

        public Form1()

        {
            InitializeComponent();
        }

        private string dosyaYolu;
        List<string> list;

        private void btnAra_Click(object sender, EventArgs e)
        {

            StringListesiOlustur();
            SecilenKelimeleriBoya();
        }
        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            DosyaOlusturVeOku();
        }
        private void DosyaOlusturVeOku()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            dosyaYolu = ofd.FileName;
            StreamReader sr = new StreamReader(dosyaYolu);
            rtxtMetin.Text = sr.ReadToEnd();
        }
        private void StringListesiOlustur()
        {

            string[] dizi = rtxtMetin.Text.Split(' ');
            list = new List<string>();
            list.AddRange(dizi);
        }
        private void SecilenKelimeleriBoya()
        {
            rtxtMetin.Clear();
            foreach (string word in list)
            {
                if (word == txtAranacak.Text)
                {
                    rtxtMetin.SelectionColor = Color.White;
                    rtxtMetin.SelectionBackColor = Color.DarkGreen;
                }
                rtxtMetin.AppendText(word);
                rtxtMetin.SelectionColor = Color.Black;
                rtxtMetin.SelectionBackColor = Color.Transparent;
                rtxtMetin.AppendText(" ");



            }

        }
    }
}
