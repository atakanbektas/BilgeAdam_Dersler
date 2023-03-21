
using WfaNortwind.Models;

namespace WfaNortwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindContext _db = new NorthwindContext();
        private void button1_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = new List<Employee> { _db.Employees.ToList().FirstOrDefault() };


            string ad = _db.Employees.ToList().Where(emp=>emp.EmployeeId==1).Single().FirstName;
            MessageBox.Show(ad);

            MessageBox.Show("Ad : "+_db.Employees.ToList().FirstOrDefault().FirstName.ToString()+"\n"+ "Soyad : " + _db.Employees.ToList().FirstOrDefault().LastName.ToString());

            
        }       

        private void btnSonEmployee_Click(object sender, EventArgs e)
        {
            
            dgvTable.DataSource = new List<Employee> { _db.Employees.OrderByDescending(emp => emp.FirstName).FirstOrDefault() };


        }

        private void btnA_Click(object sender, EventArgs e)
        {  
            dgvTable.DataSource = _db.Employees.Where(e => e.FirstName.StartsWith("A")).ToList() ;
        }

        private void btnAIceren_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = _db.Employees.Where(emp => emp.FirstName.Contains("A")).ToList();
        }

        private void btnAndrewBul_Click(object sender, EventArgs e)
        {
            //dgvTable.DataSource = _db.Employees.Where(emp => emp.FirstName == "Andrew").ToList();

            dgvTable.DataSource = _db.Employees.Where(emp => emp.FirstName.Equals("Andrew")).ToList();
        }

        private void btnEnPahaliPro_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = new List<Product> { _db.Products.OrderByDescending(pro => pro.UnitPrice).FirstOrDefault() };
        }

        private void btnEnUcuzProduct_Click(object sender, EventArgs e)
        {
            //dgvTable.DataSource = new List<Product> { _db.Products.OrderBy(pro => pro.UnitPrice).FirstOrDefault() };

            dgvTable.DataSource =  _db.Products.Where(x=>x.UnitPrice.Value==(_db.Products.Min(y=>y.UnitPrice))).ToList() ;
        }
        private void btnOrtalamaUstu_Click(object sender, EventArgs e)
        {       
            decimal ortalamaFiyat = Convert.ToDecimal(_db.Products.Average(x => x.UnitPrice));
            MessageBox.Show($"Ortalama Fiyat = {Math.Round(ortalamaFiyat,2)}$");
            dgvTable.DataSource = _db.Products.Where(prod => prod.UnitPrice > ortalamaFiyat).ToList();
        }

        private void btnStokSirala_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = _db.Products.OrderBy(p => p.UnitsInStock).ToList();
        }
    }
}