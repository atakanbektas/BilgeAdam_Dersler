using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosuYediler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 7, k = 0;
            while (k <= 10)
                Console.WriteLine($"{i}*{k} = {i * k++}");


            Console.ReadKey();
        }
    }
}
