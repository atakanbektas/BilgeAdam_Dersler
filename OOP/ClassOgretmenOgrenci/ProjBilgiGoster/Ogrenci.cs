using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBilgiGoster
{
    internal class Ogrenci : Kisi
    {
        private int OgrenciNo { get; set; } 
        private string Fakulte { get; set; } 
        private string Bolum { get; set; } 

        public override void GetMessage()
        {
            Console.WriteLine($"Ogrenci Adı: {Ad}");
            Console.WriteLine($"Ogrenci Soyadı: {Soyad}");
            Console.WriteLine($"Ogrenci Boyu: {Boy}");
            Console.WriteLine($"Ogrenci Cinsiyeti: {Cinsiyet}");
            Console.WriteLine($"Ogrenci No: {OgrenciNo}");
            Console.WriteLine($"Ogrenci Fakülte: {Fakulte}");
            Console.WriteLine($"Ogrenci Bölüm: {Bolum}");
        }

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci No Giriniz");
            OgrenciNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Fakülte Giriniz");
            Fakulte = Console.ReadLine();

            Console.WriteLine("Bolum Giriniz");
            Bolum = Console.ReadLine();            
        }
    }
}
