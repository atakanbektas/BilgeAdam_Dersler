using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortgenYildiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lütfen kısa kenar uzunluğunu giriniz.");
            int kısa = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen kısa kenar uzunluğunu giriniz.");
            int uzun = int.Parse(Console.ReadLine());


            Console.WriteLine(new String('*',uzun));
            for (int i = 0; i < kısa-2; i++)
            {
                Console.Write("*");
                Console.Write(new String(' ', uzun - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(new String('*', uzun));

            
            Console.ReadLine();
        }
    }
}
