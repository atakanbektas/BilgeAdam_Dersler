﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {            
            new NormalForm().Show();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            new DialogForm().ShowDialog();
            Form5 frm = new Form5();
            frm.i = 5;
           
        }
    }
}