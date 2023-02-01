using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CemberCevreVeAlani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Çemberin Alanı: {r * r * 3.14} \n Çemberin çevresi: {2 * 3.14 * r}");

            Console.WriteLine($"Çemberin Alanı: {r*r*Math.PI} \n Çemberin çevresi: {2*Math.PI*r}");


           

            Console.ReadKey();

        }
    }
}
