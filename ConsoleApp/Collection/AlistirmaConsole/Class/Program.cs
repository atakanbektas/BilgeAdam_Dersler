using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            Ogrenci ogrenci2 = new Ogrenci();

            ogrenci1.OgrenciNo = 61;
            ogrenci1.AdSoyad = "Atakan Bektaş";
            ogrenci1.Bolum = "Yıldız Yazılımcı";
            ogrenci1.MezunMu = "İnşallah olacak.";

            ogrenci2.OgrenciNo = 01;
            ogrenci2.AdSoyad = "Aykut Terzi";
            ogrenci2.Bolum = "Çok Yıldız Yazılımcı";
            ogrenci2.MezunMu = "İnşallah olacak.";

            List<Ogrenci> ogrenciler = new List<Ogrenci>() { ogrenci1, ogrenci2 };

            Console.WriteLine("--------------------------------");
            foreach (var item in ogrenciler)
            {
                
                Console.WriteLine($"Ogrenci No : {item.OgrenciNo}");
                Console.WriteLine($"Ad Soyad   : {item.AdSoyad}");
                Console.WriteLine($"Bolum      : {item.Bolum}");
                Console.WriteLine($"Mezun mu   : {item.MezunMu}");
                Console.WriteLine("--------------------------------");
            }
           
            Console.ReadKey();
        }
    }  
        
}
