namespace Wfa_Customer_Crud
{
    public partial class Form1 : Form
    {
        NorthwindContext _db = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowCustomersOnDataGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _db.Customers.Add(new Customer()
            {
                CustomerId = txtCustomerId.Text,
                CompanyName = txtName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtTitle.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
            });
            _db.SaveChanges();
            ShowCustomersOnDataGrid();
        }

        private void ShowCustomersOnDataGrid()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _db.Customers.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Text = dgvCustomers.SelectedCells[0].Value.ToString();
            txtName.Text = dgvCustomers.SelectedCells[1].Value.ToString();
            txtContactName.Text = dgvCustomers.SelectedCells[2].Value.ToString();
            txtTitle.Text = dgvCustomers.SelectedCells[3].Value.ToString();
            txtAddress.Text = dgvCustomers.SelectedCells[4].Value.ToString();
            txtCity.Text = dgvCustomers.SelectedCells[5].Value.ToString();
            txtRegion.Text = dgvCustomers.SelectedCells[6].Value!=null ? dgvCustomers.SelectedCells[6].Value.ToString() : "";  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           var customerToBeRemove = _db.Customers.Where(c => c.CustomerId == txtCustomerId.Text).FirstOrDefault();
            if (customerToBeRemove != null)
            {
                _db.Customers.Remove(customerToBeRemove); 
                _db.SaveChanges();
                ShowCustomersOnDataGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customerToBeUpdate = _db.Customers.Where(cus => cus.CustomerId == txtCustomerId.Text).FirstOrDefault();
            if (customerToBeUpdate != null) 
            {
                customerToBeUpdate.CompanyName = txtName.Text;
                customerToBeUpdate.ContactName = txtContactName.Text;
                customerToBeUpdate.ContactTitle = txtTitle.Text;
                customerToBeUpdate.City = txtCity.Text; 
                customerToBeUpdate.Region = txtRegion.Text;
                customerToBeUpdate.Address = txtAddress.Text;
                _db.SaveChanges();
                ShowCustomersOnDataGrid();  
            }
           
        }
    }
}