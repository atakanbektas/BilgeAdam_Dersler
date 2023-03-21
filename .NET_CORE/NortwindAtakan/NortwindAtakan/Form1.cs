using Microsoft.IdentityModel.Tokens;
using NortwindAtakan.Models;

namespace NortwindAtakan
{
    public partial class Form1 : Form
    {

        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvGoster();
        }

        private void DgvGoster()
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = _db.Customers.ToList<Customer>();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            try
            {
                customer.CustomerId = txtId.Text;
                customer.CompanyName = txtCompanyName.Text;
                _db.Customers.Add(customer);
            }
            catch (Exception ex)
            {
                _db.Customers.Remove(customer); // bunu yazmadýðým zaman hata alýyordum, mantýðýný anladýðým söylenemez...                
                MessageBox.Show(ex.Message);
            }
            _db.SaveChanges();
            DgvGoster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            //var customers = _db.Customers.ToList<Customer>();
            string id = dgvTable.SelectedCells[0].Value.ToString();

            //for (int i = 0; i < customers.Count; i++)
            //{
            //    if (customers[i].CustomerId == id)
            //    {
            //        _db.Customers.Remove(customers[i]);
            //        customers.Remove(customers[i]);
            //        i--;
            //    }
            //}      
            Customer customer;
            customer = _db.Customers.Where(x => x.CustomerId == id).First();
            _db.Customers.Remove(customer);
            _db.SaveChanges();
            DgvGoster();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var customers = _db.Customers.ToList();
            string id = dgvTable.SelectedCells[0].Value.ToString();


            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].CustomerId == id)
                {
                    customers[i].CustomerId = txtId.Text;
                    customers[i].CompanyName = txtCompanyName.Text;
                }
            }
            _db.SaveChanges();
            DgvGoster();
        }

        Random rnd = new Random();
        private void txtId_Leave(object sender, EventArgs e)
        {
            int textBoxUzunluk = txtId.Text.Length;
            txtId.Text = txtId.Text.ToUpper();

            if (textBoxUzunluk < 5)
            {
                for (int i = 0; i < 5 - textBoxUzunluk; i++)
                {
                    txtId.Text += Convert.ToChar(rnd.Next(65, 91));
                }
            }
            else if (textBoxUzunluk > 5)
            {
                txtId.Text = txtId.Text.Substring(0, 5);
            }

        }
        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}