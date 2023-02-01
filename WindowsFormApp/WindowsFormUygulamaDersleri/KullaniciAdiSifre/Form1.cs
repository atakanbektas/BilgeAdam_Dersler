using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciAdiSifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string id = "bilge.adam";
            const string password = "1234";

            if (id == txtID.Text && password == txtPassword.Text)
            {
                MessageBox.Show("Connected.");
            }
            else
            {
                MessageBox.Show("Try Again.");
                txtID.Clear();
                txtPassword.Clear();
            }

           



        }

        private void chcControl_CheckedChanged(object sender, EventArgs e)
        {
            if (chcControl.Checked == true)
            {
                chcControl.Text = "Show";
                txtPassword.UseSystemPasswordChar = true;
            }
            else if(chcControl.Checked ==false)
            {
                chcControl.Text = "Hide";
                txtPassword.UseSystemPasswordChar = false;
            }


          


        }

        
    }
}
