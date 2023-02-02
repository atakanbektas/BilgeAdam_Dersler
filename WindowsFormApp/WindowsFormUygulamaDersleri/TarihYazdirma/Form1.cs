using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarihYazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            lbl1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbl2.Text = DateTime.Now.ToString("dddd MM yy");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
