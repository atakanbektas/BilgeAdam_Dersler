using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanOgrenciMemurClass
{
    internal class Ogrenci : Insan
    {
        public string BirimAdi { get; set; }
        public string Bolum { get; set; }
        public int OgrenciNo { get; set; }
        public string Sinif { get; set; }

        public override void BilgileriGoster()
        {
            Console.WriteLine("Bu bir öğrencidir.");
            Console.WriteLine($"Adı = {Adi}");
            Console.WriteLine($"Soyadı = {Soyadi}");
            Console.WriteLine($"Dogum Tarihi = {DogumTarihi.ToShortDateString()}");
            Console.WriteLine($"T.C = {tcKimlikNo}");
            Console.WriteLine($"BirimAdi = {BirimAdi}");
            Console.WriteLine($"Bolum = {Bolum}");
            Console.WriteLine($"OgrenciNo = {OgrenciNo}");
            Console.WriteLine($"Sinif = {Sinif}");
            
        }
        public override void BilgileriAl()
        {
            base.BilgileriAl();
            Console.WriteLine("Birim adı giriniz.");
            BirimAdi = Console.ReadLine();
            Console.WriteLine("Bolum giriniz.");
            Bolum = Console.ReadLine();
            Console.WriteLine("Ogrenci no giriniz.");
            OgrenciNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Sınıf adı giriniz.");
            Sinif = Console.ReadLine();
        }
    }
}
