using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Merhaba BilgeAdam Boost Programına Hoşgeldiniz. İsminizi öğrenebilir miyiz?");
            string isim = Console.ReadLine().ToUpper();
            Console.WriteLine("Soyadınızı girer misiniz");
            string soyad = Console.ReadLine().ToUpper();

            Console.WriteLine($"Merhaba {isim} {soyad} programımıza hoşgeldin!");

            Console.WriteLine("Merhaba {0}{1}", isim,soyad);

            Console.WriteLine("");


            Console.ReadKey();
        }
    }
}
