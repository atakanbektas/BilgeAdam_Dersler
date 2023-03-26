using Wfa_KisiRehberi_DbFirst_EF.Func;

namespace Wfa_KisiRehberi_DbFirst_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPhone.ShowDgv();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                dgvPhone.DataSource = ContactFunc.ToListContact();
                dgvPhone.Columns[0].Visible = false;
            }
            else
            {
                dgvPhone.ShowDgvByAll(txtSearch.Text);
            }



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactFunc.Add(txtName.Text, txtSurname.Text, txtPhoneNumber.Text);
            ContactFunc.DbSave();
            dgvPhone.ShowDgv();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvPhone.ShowDgv();
        }

        private void dgvPhone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvPhone.SelectedCells[0].Value.ToString();
            txtSurname.Text = dgvPhone.SelectedCells[1].Value.ToString();
            txtPhoneNumber.Text = dgvPhone.SelectedCells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var index = dgvPhone.GetIndex(0);
            var listem = ContactFunc.ToListContact();
            var contact = ContactFunc._db.Contacts.Where(con => con.Id.Equals(listem[index].Id)).FirstOrDefault();            
            ContactFunc.UpdateById(contact.Id, txtName.Text, txtSurname.Text, txtPhoneNumber.Text);
            ContactFunc.DbSave();
            dgvPhone.ShowDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = ContactFunc.GetIdAccordingPhone(txtPhoneNumber.Text);
            ContactFunc.DeleteById(id);
            ContactFunc.DbSave();
            dgvPhone.ShowDgv();
        }
    }
}