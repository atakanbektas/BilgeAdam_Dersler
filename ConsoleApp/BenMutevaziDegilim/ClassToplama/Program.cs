using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToplama
{
     class Program
    {
        static void Main(string[] args)
        {
            SayilariIste();
            Console.WriteLine(Toplama.Topla());

            Console.ReadKey();
        }

        private static void SayilariIste()
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz.");
            Toplama.Sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz.");
            Toplama.Sayi2 = int.Parse(Console.ReadLine());

        }
        private static void Sayi2Iste()
        {

        }
    }
}
