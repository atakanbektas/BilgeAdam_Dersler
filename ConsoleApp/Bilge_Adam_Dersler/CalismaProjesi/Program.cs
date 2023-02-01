using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalismaProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n1 = 5;
            int n2 = 3;
            Console.WriteLine($"Sonucunuz = {Topla(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");
            Console.WriteLine($"Sonucunuz = {Cıkar(n1, n2)}");
            Console.WriteLine($"{int.MaxValue}");

            var n3 = Console.ReadLine();

            Console.ReadKey();
        }

       
            static int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }


            static int Cıkar(int sayi1, int sayi2)
            {

                return sayi1 - sayi2;
            }
        
        
    }
   

}
