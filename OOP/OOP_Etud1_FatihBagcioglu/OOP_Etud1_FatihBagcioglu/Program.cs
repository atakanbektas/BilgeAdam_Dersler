using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Etud1_FatihBagcioglu
{
    internal class Program
    {
        // OOP nedir? Object oriented programming (Nesne yönelimli proglamlama)
        // Instance oluşturuluyor bununla birlikte biz nesneleri oluşturup kendi içerisindeki metotlarla birlikte projede yürütülen operasyonları gerçekleştiriyoruz.
        // Encapsulation ( Kapsülleme )
        // Inheritance ( Kalıtım )
        // Abstraction ( Soyutlama )
        // Pholimophizm ( Çok Kalıtımlılık)
        // public,protected,internal,private,internal protected

        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "Atakan"; // set kısmı
            kisi.Soyad = "Bektaş";
            kisi.Yas = Convert.ToInt32(Console.ReadLine());

            Kisi.Metot();

            Console.WriteLine($"{kisi.Ad} {kisi.Soyad} {kisi.Yas}"); // get kısmı
            Console.ReadKey();
        }
    }
}
