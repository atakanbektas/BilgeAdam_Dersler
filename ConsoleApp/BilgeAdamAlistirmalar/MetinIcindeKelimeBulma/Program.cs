using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinIcindeKelimeBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Console.ReadLine().ToUpper().Replace(" ","").Contains("HAVA"))
            {
                Console.WriteLine("Çok HAVALISIN");
            }
            else
            {
                Console.WriteLine("HAVASIZSIN");
            }
            Console.ReadLine();
        }
    }
}
