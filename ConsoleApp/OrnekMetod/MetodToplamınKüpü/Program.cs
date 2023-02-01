using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodToplamınKüpü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayi 1 giriniz!");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen sayi 2 giriniz!");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(ToplamınKupunuAl(n1, n2));
            Console.ReadLine();
        }

        private static int ToplamınKupunuAl(int n1, int n2)
        {
            return (int)Math.Pow(n1 + n2, 3);
        }
    }
}
