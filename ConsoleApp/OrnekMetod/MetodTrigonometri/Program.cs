using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodTrigonometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen açı giriniz!");
            double sayi = double.Parse(Console.ReadLine())*(Math.PI/180);
            Console.WriteLine("Lütfen seçim yapınız.\n1.Sin\n2.Cos\n3.Tan\n4.Cot");
            char ans = char.Parse(Console.ReadLine());

            switch (ans)
            {
                case '1': PrintSin(sayi); break;
                case '2': PrintCos(sayi); break;
                case '3': PrintTan(sayi); break;
                case '4': PrintCot(sayi); break;
            }

            Console.ReadLine();
            
        }

        private static void PrintCot(double sayi)
        {
            Console.WriteLine(Math.Round(1/Math.Tan(sayi),2));            
        }

        private static void PrintTan(double sayi)
        {
            Console.WriteLine(Math.Round(Math.Tan(sayi), 2));

        }

        private static void PrintCos(double sayi)
        {
            Console.WriteLine(Math.Round(Math.Cos(sayi), 2));
        }

        private static void PrintSin(double sayi)
        {
            Console.WriteLine(Math.Round(Math.Sin(sayi), 2));
        }
    }
}
