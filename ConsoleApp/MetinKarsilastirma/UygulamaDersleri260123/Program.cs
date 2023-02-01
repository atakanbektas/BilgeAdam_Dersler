using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UygulamaDersleri260123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. metni giriniz");
            string metin1 = Console.ReadLine().ToLower();
            Console.WriteLine("Lütfen 2. metni giriniz");
            string metin2 = Console.ReadLine().ToLower();
            int kontrol = metin1.CompareTo(metin2);

            if (kontrol==0)
            {
                Console.WriteLine("Girdiğiniz metinler aynıdır!");
            }
            if (kontrol==-1)
            {
                Console.WriteLine($"{metin1} alfabe sıralamasına göre daha öncedir!");
            }
            if (kontrol==1)
            {
                Console.WriteLine($"{metin2} alfabe sıralamasına göre daha öncedir!");
            }
            Console.ReadLine();

        }
    }
}
