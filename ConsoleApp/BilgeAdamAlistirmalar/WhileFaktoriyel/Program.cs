using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileFaktoriyel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(ulong.MaxValue);
            //79228162514264337593543950335 decimal
            //
            Console.WriteLine("Sayı giriniz.");
            decimal i = decimal.Parse(Console.ReadLine());
            if (i>0)
            {
                decimal toplam = 1m;
                while (i > 0)
                {
                    toplam *= i--;
                }
                Console.WriteLine($"Sayınızın faktoriyeli = {toplam}");
                Console.ReadKey();
            }
           
        }
    }
}
