using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBilgiGoster
{
    internal class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; } 
        public double Boy { get; set; } 
        public string Cinsiyet { get; set; } 

        public virtual void GetMessage()
        {
            Console.WriteLine($"Kişi Adı: {Ad}");   
            Console.WriteLine($"Kişi Soyadı: {Soyad}");   
            Console.WriteLine($"Kişi Boyu: {Boy}");   
            Console.WriteLine($"Kişi Cinsiyeti: {Cinsiyet}");
        }

        public Kisi()
        {
            Console.WriteLine("Adınızı Giriniz");
            Ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz");
            Soyad = Console.ReadLine();

            Console.WriteLine("Boyunuzu Giriniz");
            Boy = double.Parse(Console.ReadLine());

            Console.WriteLine("Cinsiyet Giriniz");
            Cinsiyet = Console.ReadLine();
        }

    }
}
