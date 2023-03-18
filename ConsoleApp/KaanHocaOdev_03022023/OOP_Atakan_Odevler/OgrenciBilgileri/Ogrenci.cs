using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgileri
{
    internal class Ogrenci
    {
        private static string _ogrenciNo;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
        public int Sinif { get; set; }

        public void OgrenciNoOlustur(string ad, string soyad, string bolum, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            Bolum = bolum;
            Sinif = sinif;
            _ogrenciNo = Bolum.First().ToString().ToUpper() + Sinif + new Random().Next(1000, 9001);            
        }
        public void OgrenciYazdir()
        {
            Console.WriteLine($"Ogrenci Adı = {Ad}");
            Console.WriteLine($"Ogrenci Soyadı = {Soyad}");
            Console.WriteLine($"Ogrenci Bölümü = {Bolum}");
            Console.WriteLine($"Ogrenci Sınıfı = {Sinif}");
            Console.WriteLine($"Ogrenci NO = {_ogrenciNo}");
        }

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci oluşturuldu..\n");    
        }
        
    }
}
