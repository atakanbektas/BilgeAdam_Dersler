using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemberClassModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        Dictionary<string, Cember> cemberlerDic = new Dictionary<string, Cember>();
        private void btnCemberOlustur_Click(object sender, EventArgs e)
        {


            double x = 0, y = 0, r = 1;
            string cemberAd = txtCemberAdi.Text;

            try
            {
                x = double.Parse(txtKoordinatX.Text);
                y = double.Parse(txtKoordinatY.Text);
                r = double.Parse(txtYariCap.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + "\n\nÇemberiniz (0,0) Noktasında 1 yarıçapında isimsiz olarak oluşturuldu.");
                x = 0; y = 0; r = 1; cemberAd = "isimsiz";
            }// koordinatları ve yarıçap girişi kontrol edildi. 


            Cember cember = new Cember(x, y, r);
            cember.Ad = cemberAd;

            if (!cbCemberler.Items.Contains(cemberAd))
            {
                cemberlerDic.Add(cemberAd, cember);
                cbCember1.Items.Add(cemberlerDic[cemberAd].Ad);
                cbCember2.Items.Add(cemberlerDic[cemberAd].Ad);
                cbCemberler.Items.Add(cemberlerDic[cemberAd].Ad);
                cbCemberler2.Items.Add(cemberlerDic[cemberAd].Ad);
                MessageBox.Show("Cember Oluşturuldu!");

            }// Eğer daha önceden aynı ada sahip çember oluşturulmadıysa ComboBox'lara item olarak cemberlerin adını ekle...
            else
            {
                MessageBox.Show("Bu ada sahip çember zaten var!");
            }// Eğer daha önceden aynı ada sahip çember oluştuysa combobax'ın itemlerine ekleme!
        }





        private void cbCemberler_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (sender.Equals(cbCemberler))
            {
                grpCemberOzellikleri.Visible = true;
                string index = cbCemberler.SelectedItem.ToString();

                lblKoordinatX.Text = cemberlerDic[index].MerkezX.ToString();
                lblKoordinatY.Text = cemberlerDic[index].MerkezY.ToString();
                lblYariCap.Text = cemberlerDic[index].YariCap.ToString();
                lblAlan.Text = cemberlerDic[index].GetAlan().ToString();
                lblCevre.Text = cemberlerDic[index].GetCevre().ToString();
                lblCemberTegetX.Text = cemberlerDic[index].TegetYap('X');
                lblCemberTegetY.Text = cemberlerDic[index].TegetYap('Y');


            }
            else
            {
                grpCemberOzellikleri2.Visible = true;
                string index = cbCemberler2.SelectedItem.ToString();

                lblKoordinatX2.Text = cemberlerDic[index].MerkezX.ToString();
                lblKoordinatY2.Text = cemberlerDic[index].MerkezY.ToString();
                lblYariCap2.Text = cemberlerDic[index].YariCap.ToString();
                lblAlan2.Text = cemberlerDic[index].GetAlan().ToString();
                lblCevre2.Text = cemberlerDic[index].GetCevre().ToString();
                lblCemberTegetX2.Text = cemberlerDic[index].TegetYap('X');
                lblCemberTegetY2.Text = cemberlerDic[index].TegetYap('Y');
            }

        }

        private void btnKiyasla_Click(object sender, EventArgs e)
        {
            string index1 = cbCember1.SelectedItem.ToString();
            string index2 = cbCember2.SelectedItem.ToString();
            Cember cember1 = cemberlerDic[index1];
            Cember cember2 = cemberlerDic[index2];
            Cember buyukOlan = cember1.BuyukOlan(cember2);
            double mesafe = cember1.Mesafe(cember2);

            lblMerkezlerArasiUzaklik.Text = cember1.Mesafe(cember2).ToString();
            lblIcindeMi.Text = cember1.IcindeMi(cember2) ? "Evet" : "Hayır";
            lblBuyukOlanCember.Text = buyukOlan != null ? buyukOlan.Ad : "Eşit"; 
            // eğer cemberler eşitse, değilse (null referance exception hatasını önlemek için...)

        }

    }
}
