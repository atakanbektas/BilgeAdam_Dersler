using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasgeleKesirliSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(10, 20) + rnd.NextDouble());
                //Console.WriteLine(rnd.Next(1000, 2001) / 100d);
            }
            Console.ReadLine();
        }
    }
}
