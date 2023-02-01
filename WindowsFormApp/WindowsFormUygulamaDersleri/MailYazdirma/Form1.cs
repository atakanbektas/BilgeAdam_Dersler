using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailYazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            lblScreen.Text = "Hesabınız Oluşturuldu.\n\n"+ txtName.Text + txtSurname.Text + "@bilgeadamboost.com";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Clear();
            lblScreen.Text = null;
        }
    }
}
