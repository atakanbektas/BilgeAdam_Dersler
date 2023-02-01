using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitMetodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;

            char[] ayraclar = " _+/*&-% ".ToCharArray();
            string[] metin = Console.ReadLine().Split(ayraclar);


            foreach (var item in metin)
            {

                Console.WriteLine($"{sayac++} Index numaralı veri = {item}");
            }

            Console.ReadKey();
        }
    }
}
