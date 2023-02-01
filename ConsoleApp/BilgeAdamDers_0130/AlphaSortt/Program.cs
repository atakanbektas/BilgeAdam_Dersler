using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaSortt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string[] names = new string[5];

            foreach (var item in names)
            {
                Console.WriteLine($"Lütfen {i+1}. kişiyi giriniz");
                names[i++] = Console.ReadLine();
                
            }
            i = 0;
            Array.Sort(names);
            foreach (var item in names)
            {
                Console.WriteLine($"{i+1}. kişi = {names[i]}");
                i++;
            }
            Console.ReadLine();


        }
    }
}
