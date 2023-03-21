
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
            dgvTable.DataSource = _db.Employees.ToList();
        }
    }
}