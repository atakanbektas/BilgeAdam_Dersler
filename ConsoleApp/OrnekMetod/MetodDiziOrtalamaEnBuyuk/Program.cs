using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodDiziOrtalamaEnBuyuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] arry = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arry[i] = rnd.Next(1, 50);
                Console.Write(arry[i] + " ");
            }
            Console.WriteLine();
            OrtalamaAl(arry);
            EnBuyukBul(arry);
            Console.ReadLine();
        }

        private static void EnBuyukBul(int[] dizi)
        {
            int i;
            int min = 50;
            for (i = 0; i < 10; i++)
            {
                if (min > dizi[i])
                {
                    min = dizi[i];
                }
            }
            Console.WriteLine(min);
        }

        private static void OrtalamaAl(int[] dizi)
        {
            int result = 0;
            foreach (var item in dizi)
            {
                result += item;
            }
            Console.WriteLine((double)result / dizi.Length);
        }
    }
}
