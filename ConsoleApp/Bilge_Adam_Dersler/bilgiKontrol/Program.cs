using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgiKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int erkekSayi = 0;
            int kizSayi = 0;
            int tempKiz = 0;
            int tempErkek = 0;

        BastanKontrol:
            Console.WriteLine("Cinsiyetiniz nedir");
            string cinsiyet = Console.ReadLine();

            if (cinsiyet == "e")
            {
                
                Console.WriteLine("Kilonuz nedir");
                int kiloErkek = int.Parse(Console.ReadLine());
                tempErkek += kiloErkek;
                erkekSayi++;
            }
            else if (cinsiyet == "k")
            {
                
                Console.WriteLine("Kilonuz nedir");
                int kiloKiz = int.Parse(Console.ReadLine());
                tempKiz += kiloKiz;
                kizSayi++;
            }
            Console.WriteLine("Sınıfta başka öğrenci var mı?");
            string varMi = Console.ReadLine();

            if (varMi == "e")
            {
                goto BastanKontrol;
            }
            else if (varMi == "h")
            {
                Console.WriteLine($"-----------------------------------------\nSınıf mevcudu= {kizSayi + erkekSayi} \nErkek öğrenci sayısı = {erkekSayi}\nKız öğrenci sayısı ={kizSayi}\n\n\nErkek öğrencilerin kilo ortalaması ={tempErkek/erkekSayi}\nKız öğrencilerin kilo ortalaması ={tempKiz/kizSayi}");
            }

            Console.ReadKey();
            



        }
    }
}
