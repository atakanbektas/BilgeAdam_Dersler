using System.Security.Cryptography.X509Certificates;
using WFA_MostPopularCities.Models;

namespace WFA_MostPopularCities
{
    public partial class Form1 : Form
    {
        int selectedCityId = 0;
        CityContext _db = new CityContext();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListBoxCityUpdate();
        }

        private void ListBoxCityUpdate()
        {
            lstCities.DataSource = _db.Cities.ToList();
        }        
        private void btnAddCity_Click(object sender, EventArgs e)
        {
            City city = new City()
            {
                Name = txtCityName.Text,
            };
            _db.Cities.Add(city);
            _db.SaveChanges();
            ListBoxCityUpdate();
        }

        private void btnDeletecCity_Click(object sender, EventArgs e)
        {
            var cityList = _db.Cities.Where(x => x.Name == lstCities.SelectedItem.ToString()).ToList();
            var city = cityList[0];
            _db.Cities.Remove(city);
            _db.SaveChanges();
            ListBoxCityUpdate();
        }

        private void btnOzellikEkle_Click(object sender, EventArgs e)
        {
            ChooseCity formChoose = new ChooseCity();
            formChoose.ShowDialog();

            Product product = new Product();
            product.CityId = formChoose.GetId();
            product.City = _db.Cities.Where(city => city.CityId == product.CityId).First();
            product.Name = txtPopularProduct.Text;
            _db.Products.Add(product);  
            _db.SaveChanges();
            lstCities.GetSelected();

        }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCities.SelectedIndex >= 0)
            {
                selectedCityId = _db.Cities.Where(city => city == (lstCities.SelectedItem)).FirstOrDefault().CityId;
                var productsOfSelectedCity = _db.Products.Where(p => p.CityId.Equals(selectedCityId)).ToList();
                lstPopularProduct.DataSource = productsOfSelectedCity;
            }
        }
    }
}