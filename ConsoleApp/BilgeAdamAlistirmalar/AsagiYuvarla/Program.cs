using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsagiYuvarla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi = 0;
            

            Console.WriteLine("Kullanıcı sayı gir.");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Floor(sayi));
            Console.WriteLine(Math.Ceiling(sayi));

            Console.ReadKey();

        }
    }
}
