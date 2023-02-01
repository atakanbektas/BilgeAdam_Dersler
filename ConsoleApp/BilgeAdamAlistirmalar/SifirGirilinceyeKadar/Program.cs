using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifirGirilinceyeKadar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.SORU Klavyeden sıfır girilinceye kadar girilen sayıların kendisini ve karesini ekrana yazdıran program While ile
            int i = 1;
            int sayi = 1;
            Console.WriteLine("Lütfen sayıları giriniz.! Çıkmak için 0'a basınız.");
            while (sayi!=0)
            {
                sayi = int.Parse(Console.ReadLine());
                if (sayi==0)
                {
                    break;
                }
                Console.WriteLine($"{i}.sayi = {sayi}");
                Console.WriteLine($"{i}.sayinin karesi = {Math.Pow(sayi,2)}");
                i++;
            }
            Console.WriteLine("Program Sonlandı.");
            Console.ReadLine();
            

        }
    }
}
