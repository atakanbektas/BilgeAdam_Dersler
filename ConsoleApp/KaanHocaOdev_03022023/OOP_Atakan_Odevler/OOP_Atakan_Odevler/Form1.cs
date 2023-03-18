using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Atakan_Odevler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnNumaraOgren_Click(object sender, EventArgs e)
        {
            Departman departman = new Departman();
            MessageBox.Show(departman.DepartmanNoSoyle(cbDepartmanlar.SelectedIndex).ToString(),"Departman No");
            
        }
    

        private void btnDepartmanOgren_Click(object sender, EventArgs e)
        { 
            Departman departman = new Departman();           

            MessageBox.Show(departman.DepartmanAdiSoyle(int.Parse(cbNumaralar.SelectedItem.ToString())),"Departman Adı");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNumaralar.Items.Add(0);
            cbNumaralar.Items.Add(1);
            cbNumaralar.Items.Add(2);        
            cbDepartmanlar.Items.Add("Uretim");
            cbDepartmanlar.Items.Add("Pazarlama");
            cbDepartmanlar.Items.Add("Finans");        
        }
    }
}
