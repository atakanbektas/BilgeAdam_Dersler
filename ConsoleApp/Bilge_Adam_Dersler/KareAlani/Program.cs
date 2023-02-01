using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAlani
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen karenin bir kenar uzunluğunu giriniz.");
            double kenar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Karenin alanı = {kenar*kenar} \nKarenin Çevresi = {kenar*4}");


            Console.ReadKey();
        }

       
    }
}
