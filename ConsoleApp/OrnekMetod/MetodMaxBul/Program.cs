using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodMaxBul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1. sayı giriniz");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayı giriniz");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n{GetMaxValue(i,j)} sayısı büyüktür.!");

            Console.ReadKey();
        }

        private static int GetMaxValue(int i ,int j)
        {
            return Math.Max(i, j);
        }
    }
}
