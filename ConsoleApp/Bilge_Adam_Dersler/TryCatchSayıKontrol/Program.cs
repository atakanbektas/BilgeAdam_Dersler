using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchSayıKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            bool kontrol = true;
            while (kontrol)
            {
                Console.WriteLine("Lütfen sayı giriniz.");
                try
                {
                    sayi1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(sayi1);
                }
                catch (Exception)
                {
                    Console.WriteLine("Tamsayı Girişi yapmadınız!");
                }
               
                Console.WriteLine("Çıkmak için 'E' tuşuna basınız!");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    break;
                }
            }
     

            Console.ReadLine();
        }
    }
}
