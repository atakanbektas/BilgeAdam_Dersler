using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdvHesap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kdv'siz fiyatı giriniz.");
            decimal fiyat = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Yemek kdv'li fiyatı = {fiyat * 1.08m} TL");
            Console.WriteLine($"Ekmek kdv'li fiyatı = {fiyat * 1.01m} TL");
            Console.WriteLine($"Normal hayat kdv'li fiyatı = {fiyat * 1.18m} TL");

            Console.ReadLine();
        }
    }
}
