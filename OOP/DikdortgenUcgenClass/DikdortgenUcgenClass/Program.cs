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

            CizimAraci dikdortgen1= new CizimAraci(new Dikdörtgen());
            Console.WriteLine(dikdortgen1.Ciz());

            CizimAraci ucgen1 = new CizimAraci(new Ucgen());
            Console.WriteLine(ucgen1.Ciz());
           
            Console.ReadKey();
        }
    }
}
