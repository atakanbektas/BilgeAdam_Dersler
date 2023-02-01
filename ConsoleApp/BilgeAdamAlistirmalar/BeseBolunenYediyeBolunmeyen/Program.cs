using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeseBolunenYediyeBolunmeyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;

            for (int i = 5; i < 1001; i++)
            {
                if (i%5==0 && i%7!=0)
                {
                    Console.WriteLine(i);
                    toplam += i;
                }
            }
            Console.WriteLine($"Sayıların toplamı = {toplam}");


            Console.ReadKey();

        }
    }
}
