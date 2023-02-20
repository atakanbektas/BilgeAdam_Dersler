using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTurClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan1 = new Insan();
            Insan insan2 = new Insan();
            Insan insan3 = new Insan();

            insan1.Aile = "İnsan";
            insan1.Familya = "Canlı";
            insan1.CanliTuru = "Çok Canlı";
            insan1.AileGoster();
            insan1.FamilyaGoster();
            insan1.TurGoster();

            Console.ReadLine();
        }
    }
}
