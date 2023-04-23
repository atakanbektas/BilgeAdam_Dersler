namespace Uygulama1904.Models
{
    public class Product
    {
        public int UrunId { get; set; }
        public string Isim { get; set; }
        public int StokMiktarı { get; set; }
        public string Kategori { get; set; }

        public static List<Product> Urunler { get; } = new()
        {
            new Product(1,"ayva",50,"meyve"),
            new Product(2,"elma",320,"meyve"),
            new Product(3,"pantolon",82,"tekstil")
        };
        public Product(int urunId, string isim, int stokMiktari, string kategori)
        {
            UrunId = urunId;
            Isim = isim;
            StokMiktarı = stokMiktari;
            Kategori = kategori;
        }
    }
}
