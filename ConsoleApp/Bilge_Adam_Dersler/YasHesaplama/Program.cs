using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen doğum yılını giriniz.");
            Console.WriteLine($"Yaşınız =  {2023-short.Parse(Console.ReadLine())}");
            
            Console.ReadKey();
        }
    }
}
