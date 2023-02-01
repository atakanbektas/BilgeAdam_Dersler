using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char aranacak = char.Parse(Console.ReadLine());

            int indexNo = input.IndexOf(aranacak);

            if (indexNo!=-1)
            {
                Console.WriteLine($"{aranacak} harfi sırası {indexNo+1}");
            }
            else
            {
                Console.WriteLine($"Aradığınız {aranacak} harfi bulunamadı!");
            }
            Console.ReadLine();
        }
    }
}
