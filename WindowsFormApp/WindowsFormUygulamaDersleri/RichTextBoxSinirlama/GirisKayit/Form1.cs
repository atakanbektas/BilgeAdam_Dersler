using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string id = "admin";
        const string sifre = "1234";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==id)
            {
                if (textBox2.Text==sifre)
                {
                    MessageBox.Show("Giriş Yapıldı.");
                    Hide();
                    Form2 frm = new Form2();
                    frm.kullaniciAdi = id;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Şifre Hatalı!");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı!.");
            }
        }
    }
}
