using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinBirlestirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = Console.ReadLine();
            string soyad = Console.ReadLine();
            int yas = int.Parse(Console.ReadLine());
            string adSoyadYas = string.Concat($"Benim adım {ad} soyadım {soyad} yaşım {yas}");
            
            Console.WriteLine(adSoyadYas);
            Console.ReadLine();
        }
       
    }
}
