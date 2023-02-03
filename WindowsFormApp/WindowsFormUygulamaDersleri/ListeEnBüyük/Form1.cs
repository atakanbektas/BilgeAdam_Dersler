using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeEnBüyük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> sayilar = new List<int>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sayilar.Add(int.Parse(txtSayi.Text));
                lstKontrol.Items.Add(int.Parse(txtSayi.Text));
                
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("Hatalı giriş yaptınız tekrar denemek ister misiniz ?", "UYARI", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    txtSayi.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            
            
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            int enBuyuk = sayilar.Max();
            int enKucuk = sayilar.Min();

            MessageBox.Show($"En küçük sayınız = {enKucuk}\nEn büyük sayınız = {enBuyuk}");
        }
    }
}
