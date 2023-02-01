using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringGetType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short shortSayi1 = 5;


            Console.WriteLine($"short sayı ve tipi:  {shortSayi1.ToString().GetType()}");

            Console.ReadKey();
     
        }
    }
}
