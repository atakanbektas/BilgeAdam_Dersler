using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdenYirmiyeKadarSayiYaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<20)
            {
                Console.WriteLine(++i);
            }
            Console.ReadKey();
        }
    }
}
