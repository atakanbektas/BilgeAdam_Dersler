using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeserBeserYazdir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -5;
            while (i<100)
            {
                Console.WriteLine(i+=5);                
            }
          
            Console.ReadLine();
        }
    }
}
