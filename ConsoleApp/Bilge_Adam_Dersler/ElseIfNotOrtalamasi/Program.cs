using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfNotOrtalamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekrarCalistir:

            Console.WriteLine("Lütfen notunuzu giriniz");
            int i = int.Parse(Console.ReadLine());

            if (i>=90)
            {
                Console.WriteLine("Notunuz= " + i + " AA");
            }
            else if (i>=80)
            {
                Console.WriteLine("Notunuz= " + i + " BB");
            }
            else if (i >= 70)
            {
                Console.WriteLine("Notunuz= " + i + " CC");
            }
            else if (i >= 60)
            {
                Console.WriteLine("Notunuz= " + i + " DD");
            }
            else if (i < 60)
            {
                Console.WriteLine("Notunuz= " + i + " FF");
            }

            goto TekrarCalistir;

           

        }
    }
}
