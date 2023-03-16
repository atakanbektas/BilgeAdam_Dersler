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
            var x = _db.Regions.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}