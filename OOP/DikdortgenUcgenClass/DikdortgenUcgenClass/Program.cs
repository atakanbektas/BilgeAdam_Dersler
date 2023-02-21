using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenUcgenClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(new Ucgen().Ciz() + "\n\n\n\n");
            Console.WriteLine(new Dikdörtgen().Ciz());

            Console.WriteLine(2>>1);
           
            Console.ReadKey();
        }
    }
}
