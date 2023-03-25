using Microsoft.VisualBasic;
using WFA_Nortwind.UI.Models;

namespace WFA_Nortwind.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindContext _db = new NorthwindContext();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TiklamaAnimasyonu(object sender)
        {
            lblTakip.Top = (sender as Button).Top;
        }

        /// <summary>
        /// Fiyat� 20 ile 50 aras�nda olan �r�nlerimin, ID, �r�n Ad�, Fiyat�, Stok Miktar� ve Kategori Ad� bilgilerini listeler.
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Click</param>
        private void btnYirmiElliDolarArasiUrunler_Click(object sender, EventArgs e)
        {
            TiklamaAnimasyonu(sender);
            var yirmiElliDolarArasiUrunler = _db.Products.Where(pro => pro.UnitPrice >= 20 && pro.UnitPrice <= 50).ToList();
            var kategoriler = _db.Categories.ToList();

            dgvTable.DataSource = yirmiElliDolarArasiUrunler.Select(urun => new
            {
                ID = urun.ProductId,
                UrunAdi = urun.ProductName,
                Fiyat = urun.UnitPrice,
                StokMiktari = urun.UnitsInStock,
                KategoriAdi = kategoriler.Where(kat => kat.CategoryId == urun.CategoryId).FirstOrDefault().CategoryName
            }).ToList();
        }


        /// <summary>
        /// Sipari�ler tablosundan kolon isimleri M�steriSirketAdi, CalisanAdiSoyadi, SiparisID, SiparisTarihi ve KargoSirketAdi olacak �ekilde verileri listeler.
        /// </summary>
        /// <param name="sender">Buton</param>
        /// <param name="e">Click</param>
        private void btnTumSiparisler_Click(object sender, EventArgs e)
        {
            /* Sipari�ler tablosundan kolon isimleri 
             * M�steriSirketAdi Company Name(Customers), 
             * CalisanAdiSoyadi FirstName + LastName(Employees), 
             * SiparisID OrderId(Orders), 
             * SiparisTarihi OrderDate(Orders)
             * KargoSirketAdi CompanyName(Shippers)
             * olacak �ekilde verileri listeleyiniz.*/
            TiklamaAnimasyonu(sender);
            var siparisler = _db.Orders.ToList();
            var musteriler = _db.Customers.ToList();
            var calisanlar = _db.Employees.ToList();
            var kargoSirketleri = _db.Shippers.ToList();


            dgvTable.DataSource = siparisler.Select(siparis => new
            {
                M�steriSirketAdi = musteriler.Where(musteri => musteri.CustomerId == siparis.CustomerId).FirstOrDefault().CompanyName,
                CalisanAdiSoyadi = calisanlar.Where(calisan => calisan.EmployeeId == siparis.EmployeeId).FirstOrDefault().FirstName + " " + calisanlar.Where(calisan => calisan.EmployeeId == siparis.EmployeeId).FirstOrDefault().LastName,
                SiparisID = siparis.OrderId,
                SiparisTarihi = siparis.OrderDate,
                KargoSirketAdi = kargoSirketleri.Where(kargo => kargo.ShipperId == siparis.ShipVia).FirstOrDefault().CompanyName,
            }).ToList();
        }


        /// <summary>
        /// �irket ad�nda restaurant ge�en m��terileri listeler.
        /// </summary>
        /// <param name="sender">Buton</param>
        /// <param name="e">Click</param>
        private void btnRestauranAdindakiMusteriler_Click(object sender, EventArgs e)
        {
            TiklamaAnimasyonu(sender);
            var sirketiRestaurantOlanMusteriler = _db.Customers.Where(m�steri => m�steri.CompanyName.Contains("restaurant")).ToList();
            dgvTable.DataSource = sirketiRestaurantOlanMusteriler;
        }


        /// <summary>
        /// Beverages kategorisine sahip olan ve �r�n ad� Kola, fiyat� 5$, stok miktar� 500 olan bir �r�n ekler.
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Click</param>
        private void btnBeverages_Click(object sender, EventArgs e)
        {
            TiklamaAnimasyonu(sender);

            _db.Products.Add(new Product()
            {
                CategoryId = _db.Categories.Where(cat => cat.CategoryName == "Beverages").FirstOrDefault().CategoryId,
                ProductName = "Kola",
                UnitPrice = 5,
                UnitsInStock = 500,
            });

            _db.SaveChanges();
            MessageBox.Show("�r�n�n�z Eklendi!");

            dgvTable.DataSource = _db.Products.ToList();
        }


        /// <summary>
        ///  �al��anlar�n ad�n�, soyad�n�, do�um tarihini ve y�l baz�nda ya��n� listeler.
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Click</param>
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            TiklamaAnimasyonu(sender);
            var calisanlar = _db.Employees.ToList();
            dgvTable.DataSource = calisanlar.Select(calisan => new
            {
                Ad� = calisan.FirstName,
                Soyad� = calisan.LastName,
                Do�umTarihi = calisan.BirthDate.Value.ToShortDateString(),
                Ya�� = DateTime.Now.Year - calisan.BirthDate.Value.Year,
            }).ToList();
        }


        /// <summary>
        /// Her bir kategorinin stoktaki toplam �r�n miktar�n� listeler.
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Click</param>
        private void button9_Click(object sender, EventArgs e)
        {
            TiklamaAnimasyonu(sender);
            var kategoriler = _db.Categories.ToList();
            var urunler = _db.Products.ToList();
            var stokGrup = urunler.
                GroupBy(urun => urun.CategoryId).
                Select(grup => new{ 
                    KategoriAdi = kategoriler.First(kategori=>kategori.CategoryId==grup.Key).CategoryName,
                    StokMiktari = grup.Sum(urun=>urun.UnitsInStock)           
            }).OrderByDescending(stok=>stok.StokMiktari).ToList();

            dgvTable.DataSource = stokGrup;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TiklamaAnimasyonu(sender);
            var urunler = _db.Products.ToList();
            dgvTable.DataSource = urunler.OrderByDescending(urun => urun.ProductName).OrderByDescending(urun => urun.UnitsInStock).ToList();

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            TiklamaAnimasyonu(sender);
            var urunler = _db.Products.ToList();
            var siparisDetaylari = _db.OrderDetails.GroupBy(detay => detay.OrderId).Select(grup => new
            {
                   OrderId = grup.Key,
                   ToplamSatisTutari = grup.Sum(grup=>grup.Quantity*(1-grup.Discount)*Convert.ToDouble(grup.UnitPrice)),
            }).Where(g=>g.ToplamSatisTutari<=500).OrderByDescending(g=>g.ToplamSatisTutari).ToList();
            dgvTable.DataSource = siparisDetaylari;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TiklamaAnimasyonu(sender);
            var urunler = _db.Products.ToList();
            var kategoriler = _db.Categories.ToList();

            dgvTable.DataSource = urunler.Select(urun => new
            {
                UrunAdi = urun.ProductName,
                KategoriName = kategoriler.Where(kat=>kat.CategoryId == urun.CategoryId).First().CategoryName,
            }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            TiklamaAnimasyonu(sender);
            var urunler = _db.Products.ToList();
            var kategoriler = _db.Categories.ToList();
            var tedarikciler = _db.Suppliers.ToList();

            dgvTable.DataSource = urunler.Select(urun => new
            {
                UrunAdi = urun.ProductName,
                KategoriName = kategoriler.Where(kat => kat.CategoryId == urun.CategoryId).First()?.CategoryName,
                TedarikciName = tedarikciler.Where(tedarikci => tedarikci.SupplierId == urun.SupplierId).FirstOrDefault()?.CompanyName,
            }).ToList();
        }
    }
}