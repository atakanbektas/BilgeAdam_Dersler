using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilarınToplamVeOrtalamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine((i+1)+". Sayıyı giriniz!");
                toplam += int.Parse(Console.ReadLine());
            }
            double ort = (double)toplam / 12;
            Console.WriteLine($"Sayıların toplamı ={toplam}");
            Console.WriteLine($"Sayıların ortalaması ={ort}");
            Console.ReadKey();
        }
    }
}
