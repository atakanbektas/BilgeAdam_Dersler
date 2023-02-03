using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            int[] diziSayilar = new int[] { 6, 8, 9, 5, 78, 32, 12, 45, 85, 64, 9, 8, 78 };

            sayilar.AddRange(diziSayilar);
            Console.WriteLine($"Listenin elemanları:  {string.Join(" ",sayilar)}\nListenin ortalaması:  {sayilar.Average()}");

            Console.Write($"Ortalamadan büyük sayılar:  ");
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilar[i] > sayilar.Average())
                {
                    Console.Write(sayilar[i]+" ");
                }
                
            }

            Console.WriteLine();
            sayilar.Sort();
            Console.WriteLine($"Sayıların toplamı = {sayilar.Sum()}");
            Console.ReadLine();
        }
    }
}
