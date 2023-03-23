using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_MostPopularCities.Models;

namespace WFA_MostPopularCities
{
    public partial class ChooseCity : Form
    {
        CityContext _db = new CityContext();   
        int id=0;
        public ChooseCity()
        {
            InitializeComponent();
        }
        
        private void btnSeç_Click(object sender, EventArgs e)
        {
            id = _db.Cities.Where(city => city.Name.Equals(lstCities.SelectedItem.ToString())).First().CityId;
            Hide();
        }

        public int GetId()
        {
            return id;
        }

        private void ChooseCity_Load(object sender, EventArgs e)
        {
            lstCities.DataSource = _db.Cities.ToList();
        }
    }
}
