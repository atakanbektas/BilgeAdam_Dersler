using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodTekCift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı giriniz!");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(GetEvenOrOdd(i));

            Console.Read();
        }

        private static string GetEvenOrOdd(int i)
        {
            string ans = "Tek";
            if (i%2==0)
            {
                ans = "Cift";
            }
            return ans;
        }
    }
}
