using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnYuksekNotBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0, min = 100, toplam = 0;

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i + 1}.sayıyı giriniz");
                    int not = int.Parse(Console.ReadLine());
                    if (not <= 100 && not >= 0)
                    {
                        if (not < min)
                        {
                            min = not;
                        }
                        if (not > max)
                        {
                            max = not;
                        }
                        toplam += not;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen 0-100 arasında sayı giriniz!");
                        i--;
                    }
                }
                Console.WriteLine($"Max Not = {max}");
                Console.WriteLine($"Min Not = {min}");
                Console.WriteLine($"Ortalama Not = {toplam / 10}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                throw;
            }

            Console.ReadKey();
        }
    }
}
