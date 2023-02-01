using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaBirimiConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal tl; 

            Console.WriteLine("Lütfen TL cinsinden değer giriniz.");
            tl = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"{tl} TL = {tl * (decimal)0.053} DOLAR");
            Console.WriteLine($"{tl} TL = {tl * (decimal)0.049} EURO");

            Console.ReadKey();

            // decimal genellikle para değerlerinde kullanılır.
            // desimal'a dönüştürmek için sayının sonuna 'm' karakteri konulur.
            
        }
    }
}
