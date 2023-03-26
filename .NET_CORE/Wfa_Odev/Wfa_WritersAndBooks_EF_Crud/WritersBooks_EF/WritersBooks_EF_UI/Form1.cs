using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WritersBooks_EF_UI.Models;

namespace WritersBooks_EF_UI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        WritersAndBooksContext _db = new WritersAndBooksContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cbWriters.DataSource = _db.Writers.ToList();
        }

        private void cbWriters_SelectedIndexChanged(object sender, EventArgs e)
        {           

            int index = cbWriters.SelectedIndex;
            int id = _db.Writers.ToList()[index].WriterId;
            var writer = _db.Writers.Include(w => w.Books).SingleOrDefault(w => w.WriterId == id);

            dgvBooks.DataSource = writer.Books.Select(b => new { b.BookName}).ToList();





        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookName = txtKitapAdi.Text;
            book.Description = txtKitapAciklama.Text;

            Writer writer = new Writer();
            writer.FirstName = txtYazarAdi.Text;
            writer.LastName = txtYazarSoyadi.Text;

            book.Writers.Add(writer);
            writer.Books.Add(book);


            _db.Writers.Add(writer);
            _db.Books.Add(book);
            _db.SaveChanges();
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = _db.Books.ToList();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = dgvBooks.CurrentCell.RowIndex;
            var id = _db.Books.ToList()[index].BookId;
            var silinecekKitap = _db.Books.Where(book => book.BookId == id).FirstOrDefault();

            
            _db.Books.Remove(silinecekKitap);



            _db.SaveChanges();
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = _db.Books.ToList();
        }
    }
}