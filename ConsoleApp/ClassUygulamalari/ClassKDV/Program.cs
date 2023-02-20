using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun(100m);
            Console.WriteLine("Urun fiyatı = "+ urun.Fiyat+"$");
            Console.WriteLine("Kdv'li fiyatı = "+ urun.KdvFiyati+" $");

            Console.ReadKey();
        }
    }
}
