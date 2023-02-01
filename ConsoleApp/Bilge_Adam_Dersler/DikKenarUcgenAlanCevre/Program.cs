using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikKenarUcgenAlanCevre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k1 = int.Parse(Console.ReadLine());
            double k2 = int.Parse(Console.ReadLine());
            double k3 = Math.Sqrt(Math.Pow(k1, 2) + Math.Pow(k2, 2));

            Console.WriteLine($"Hipotenus değeri= {k3}");
            Console.WriteLine($"Ucgenin Alanı= {k1*k2/2}");
            Console.WriteLine($"Ucgen Cevresi= {k1+k2+k3}");

            Console.ReadKey();
        }
    }
}
