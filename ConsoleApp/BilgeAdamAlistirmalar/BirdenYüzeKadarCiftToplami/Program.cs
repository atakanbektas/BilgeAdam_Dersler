using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdenYüzeKadarCiftToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, toplam = 0;
            while (i<100)
            {
                Console.WriteLine(i += 2);
                toplam += i;
            }
            Console.WriteLine($"Toplam = {toplam}");
            Console.ReadLine();
        }
    }
}
