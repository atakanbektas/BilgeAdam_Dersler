using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodEnKucuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 3 sayıyı giriniz.!");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSmallestNumber(i, j, k));
            Console.Read();
        }

        private static int GetSmallestNumber(int i, int j, int k)
        {
            int min = GetSmallest(i, j);
            int minSum = GetSmallest(k, min);
            return minSum;
        }

        private static int GetSmallest(int i, int j)
        { 
            return j>i ? i : j;
        }
    }
}
