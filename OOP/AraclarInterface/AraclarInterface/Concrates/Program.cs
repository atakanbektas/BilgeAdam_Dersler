using AraclarInterface.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraclarInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            Console.WriteLine(araba.Durdur("araba"));
            
            Console.ReadLine();
        }
    }
}
