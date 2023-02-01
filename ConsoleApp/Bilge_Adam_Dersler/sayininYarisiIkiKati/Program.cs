using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayininYarisiIkiKati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            don:
            int i = int.Parse(Console.ReadLine());

            if (i%2==0)
            {
                i *= 2;
                Console.WriteLine(i);
            }
            else
                Console.WriteLine(i*0.5);

            goto don;

            Console.ReadKey();
        }
    }
}
