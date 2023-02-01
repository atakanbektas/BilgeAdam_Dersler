using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciftSayilariOgrenmeSorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            int k = i >> 1;
            if (i==(k+k))
            {
                Console.WriteLine("Sayiniz çifttir.");
            }
            else
                Console.WriteLine("Sayiniz tektir.");


            if (i%2!=0)
            {
                Console.WriteLine("Sayiniz tektir!!!!!");
            }
            else
                Console.WriteLine("Sayiniz çifttir!!!!!");


            if (i%2==0)
                Console.WriteLine("Sayıniz çifttir");

            Console.ReadKey();
        }
    }
}
