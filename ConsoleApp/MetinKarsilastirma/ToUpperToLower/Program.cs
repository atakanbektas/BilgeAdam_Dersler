using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpperToLower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kelimeyi giriniz");
            Console.WriteLine($"BÜYÜK HARF = {Console.ReadLine().ToUpper()}");
            Console.WriteLine($"küçük harf = {Console.ReadLine().ToLower()}");
            Console.ReadLine();
        }
    }
}
