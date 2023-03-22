using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginDBFirst.Models;

namespace UserLoginDBFirst.Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            

            SignUpPage signUp = new SignUpPage();
            signUp.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            

            var list = this.Db().Profiles.Where(prof => prof.ProfileId== txtId.Text).ToList();
            if (list.Count>0)
            {
                var list2 = this.Db().Profiles.Where(prof => prof.Password== txtPassword.Text).ToList();
                if (list2.Count>0) 
                {
                    new Form2().ShowDialog();
                }                
                MessageBox.Show("Hatalı Şifre Girdiniz!");                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Hatalı");
            }


            //foreach (var item in this.Db().Profiles)
            //{
            //    if (item == profile)
            //    {
            //        isExist= true;
            //    }
            //}
     
            

            
        }
    }
}
