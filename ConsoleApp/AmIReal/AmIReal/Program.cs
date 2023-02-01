using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmIReal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Kisi kisi = new Kisi();
        BasaDon:
            Console.WriteLine("Lütfen adınızı giriniz.");
            //kisi.Ad = Console.ReadLine();
            kisi.Ad = "atakan";

            Console.WriteLine("Lütfen soyadınızı giriniz.");
            //kisi.Soyad = Console.ReadLine();
            kisi.Soyad = "bektaş";

            Console.WriteLine("Lütfen doğum yılınızı giriniz.");
            //kisi.DogumYili = int.Parse(Console.ReadLine());
            kisi.DogumYili = 1995;

            Console.WriteLine("Lütfen T.C No giriniz.");
            //kisi.TcNo = long.Parse(Console.ReadLine());
            kisi.TcNo = rnd.Next(1000, 10000) * 100000000;
            bool durum;
           
            try
            {
                using (KimlikDogrula.KPSPublicSoapClient service = new KimlikDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kisi.TcNo, kisi.Ad, kisi.Soyad, kisi.DogumYili);
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (durum==true)
            {
                Console.WriteLine("T.C VATANDAŞLARI ARASINDASINIZ..");
            }
            else
            {
                Console.WriteLine("BÖYLE BİRİ BULUNAMAMIŞTIR..!");
            }
            goto BasaDon;
        }

        class Kisi
        {
            public string Ad { get; set; }

            public string Soyad { get; set; }

            public int DogumYili { get; set; }

            public long TcNo { get; set; }
        }
    }
}
