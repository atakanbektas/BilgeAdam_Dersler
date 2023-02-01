using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcBasamakliSayiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, sayi = 0, sayac = 0;
            do
            {
                Console.WriteLine($"Lütfen {++i}. sayıyı giriniz!");
                sayi = int.Parse(Console.ReadLine());
                if (sayi / 100 >= 1 && sayi / 1000 < 1)
                {
                    sayac++;
                }

            } while (i<10);
            
           

            Console.WriteLine($"Uc basamaklı sayılarınızın sayısı ={sayac}");
            Console.ReadLine();
        }
    }
}
