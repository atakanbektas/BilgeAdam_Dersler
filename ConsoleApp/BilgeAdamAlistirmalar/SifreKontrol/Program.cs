using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sifre = "";
            string sifreOrj = "123";
            do
            {
                Console.WriteLine("Lütfen şifrenizi giriniz.");
                
                sifre = Console.ReadLine();
                if (sifre==sifreOrj)
                {
                    Console.WriteLine("Giriş Yapıldı");
                }
                else
                {
                    Console.WriteLine("Giriş yapılamadı.Tekrar Deneyin.");
                }
              

            } while (sifre!=sifreOrj);
            Console.ReadKey();
        }
    }
}
