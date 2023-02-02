using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            lblScreen.Text = (Convert.ToInt32(txtSayi1.Text) + Convert.ToInt32(txtSayi2.Text)).ToString();          
               
           
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            lblScreen.Text = (Convert.ToInt32(txtSayi1.Text) - Convert.ToInt32(txtSayi2.Text)).ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            lblScreen.Text = (Convert.ToInt32(txtSayi1.Text) * Convert.ToInt32(txtSayi2.Text)).ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSayi2.Text)==0)
            {
                MessageBox.Show("0'a bölünemez!");
                txtSayi2.Text = "";
            }
            else
            {
            lblScreen.Text = (Convert.ToInt32(txtSayi1.Text) / Convert.ToInt32(txtSayi2.Text)).ToString();
            }
        }

     

        private void txtSayi1_Click_1(object sender, EventArgs e)
        {
            txtSayi1.Text = "";
            lblScreen.Text = "";
        }

        private void txtSayi2_Click_1(object sender, EventArgs e)
        {
            txtSayi2.Text = "";
            lblScreen.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrLight.Start();           
        }

        private void tmrLight_Tick(object sender, EventArgs e)
        {
            int i = rnd.Next(200, 255);
            int j = rnd.Next(200, 255);
            int k = rnd.Next(200, 255);
            label1.ForeColor = Color.FromArgb(i, j, k);
        }
    }
}
