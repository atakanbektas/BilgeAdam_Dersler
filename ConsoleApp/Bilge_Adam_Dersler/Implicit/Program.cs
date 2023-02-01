using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 3;
            double sayi2 = sayi1;

            Console.WriteLine($"sayi1 tipi : {sayi1.GetType() }");
            Console.WriteLine($"sayi2 tipi : { sayi2.GetType() }");


            float sayi3 = 3.53f;
            sayi2 = sayi3;
            Console.WriteLine($"{sayi2.GetType()}");

            Console.ReadKey();
            
        }
    }
}
// byte bi değeri int'e dönüştürmek unboxing'e örnektir.
