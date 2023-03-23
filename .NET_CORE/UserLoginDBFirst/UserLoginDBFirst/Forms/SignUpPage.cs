using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLoginDBFirst.Models;

namespace UserLoginDBFirst.Forms
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        Profile profile;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            profile = new Profile();
            profile.ProfileId = txtId.Text;
            profile.Password = txtPassword.Text;
            Human human = new Human()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Phone = Convert.ToInt64(txtPhone.Text)          
            };
            profile.Human = human;

            try
            {
                this.Db().Profiles.Add(profile);
                this.Db().SaveChanges();
                MessageBox.Show("Hesap Oluşturuldu");
            }
            catch 
            {
                this.Db().Profiles.Remove(profile);
                MessageBox.Show("Failed","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
