using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanGirilenSayiArasiToplam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("VERSİYON 1");
                Console.WriteLine();

                int toplam = 0;
                Console.WriteLine("1.sayıyı giriniz!");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz!");
                int sayi2 = int.Parse(Console.ReadLine());


                while (sayi1 > sayi2 + 1)
                {
                    toplam += ++sayi2;
                }

                while (sayi2 > sayi1 + 1)
                {
                    toplam += --sayi2;
                }
                Console.WriteLine($"Sayıların toplamı = {toplam}");
            }
            {
                Console.WriteLine("************************************");
                Console.WriteLine("VERSİYON 2");
                Console.WriteLine();

                int toplam = 0;
                Console.WriteLine("1.sayıyı giriniz!");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz!");
                int sayi2 = int.Parse(Console.ReadLine());


                while (sayi1 >= sayi2 )
                {
                    toplam += sayi2++;
                }

                while (sayi2 >= sayi1 )
                {
                    toplam += sayi2--;
                }
                Console.WriteLine($"Sayıların toplamı = {toplam}");
            }
                
            
         




            Console.ReadKey();
        }
         
    }
}
