using NortwindDBFirst.Models;

namespace NortwindDBFirst
{
    public partial class Form1 : Form
    {
        NorthwindContext _db;
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();
            var customers = _db.Customers.ToList();
            dgvTable.DataSource = customers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }
    }
}