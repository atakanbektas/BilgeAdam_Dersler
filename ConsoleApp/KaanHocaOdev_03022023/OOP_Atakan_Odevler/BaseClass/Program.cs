using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.BilgileriIste();
            Console.WriteLine("\n\n\n");
            urun.BilgileriYazdir();
            Console.ReadLine();
        }
    }
}
