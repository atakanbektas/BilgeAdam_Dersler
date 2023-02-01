using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdamAlistirmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ciftSonuc = 0, tekSonuc = 0;
            for (int i = 0; i < 21; i++)
            {
                if (i%2==0)
                {
                    ciftSonuc += i;
                }
                else
                {
                    tekSonuc += i;
                }
            }
            Console.WriteLine($"Tek sayıların toplamı ={tekSonuc}");
            Console.WriteLine($"Çift sayıların toplamı ={ciftSonuc}");

            Console.ReadKey();
        }
        
    }
}
