using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalansizBolunenEnKucuk
{
    internal class Program
    {
        public string isim = "mert";

        static void Main(string[] args)
        {
           
            Console.WriteLine("Lütfen başlangıç sayısı giriniz.");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bitiş sayısı giriniz.");
            int stop = int.Parse(Console.ReadLine());
            Console.WriteLine(getSmallestNumber(start, stop));
            Console.ReadKey();
        }

        private static int getSmallestNumber(int start2, int stop2)
        {
            int sayac = 0;
            int j = 1;
            for (int i = stop2; i < int.MaxValue; i += stop2)
            {
                for (j = start2; j < stop2; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == stop2 - start2) // 2. for'daki if'e her seferinde girdiyse: return i;
                {
                    return i;
                }
                else
                {
                    sayac = 0;
                }
            }
            return 0;
        }

    }
}
