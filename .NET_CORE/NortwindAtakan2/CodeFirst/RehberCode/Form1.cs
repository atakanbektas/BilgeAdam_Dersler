using RehberCode.Context;
using RehberCode.Models;

namespace RehberCode
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        RehberContext _db = new RehberContext();

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Person person = _db.People.Where(per => per.PersonId == (int)dgvTable.SelectedCells[0].Value).FirstOrDefault();
            UpdeteMethod(person);
            _db.SaveChanges();
        }

        private void UpdeteMethod(Person? person)
        {
            person.Name = txtName.Text;
            person.Surname = txtSurname.Text;
            person.Phone = txtPhone.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text
            };
            _db.People.Add(person);
            _db.SaveChanges();
            MessageBox.Show("Kisi eklendi","TEBRÝKLER",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = _db.People.ToList();
            dgvTable.Columns["PersonId"].ReadOnly = true;
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = dgvTable.SelectedCells[1].Value.ToString();
                txtSurname.Text = dgvTable.SelectedCells[2].Value.ToString();
                txtPhone.Text = dgvTable.SelectedCells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            var people = _db.People.Where(per => per.Name.Contains(txtPerson.Text) || per.Surname.Contains(txtPerson.Text)).ToList();
            if (people==null)
            {
                MessageBox.Show("Bu isme ait kimse bulunamadý!");
            }
            else
            {
                dgvTable.DataSource = people;
            }

        }
    }
}