using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegenenBegenmeyenSayma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cevap = ' ';
            int sayacE = 0, sayacK = 0, sayacH = 0;
            while (cevap != 'B')
            {
                try
                {

                    Console.WriteLine("Ürünü beğendiniz mi? (Evet/E , Hayır/H, Kararsız/K");
                    Console.WriteLine("Çıkmak için B'ye basınız!");
                    cevap = char.Parse(Console.ReadLine().ToUpper());
                    switch (cevap)
                    {
                        case 'E': sayacE++; break;
                        case 'H': sayacH++; break;
                        case 'K': sayacK++; break;
                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir hata ile karşılaşıldı! Baştan başlıyor!");
                }
            }
            Console.WriteLine($"Beğenen sayısı = {sayacE}\nBeğenmeyen sayısı = {sayacH}\nKararsız sayısı ={sayacK}\nToplam müşteri sayısı ={sayacE + sayacH + sayacK}");
            Console.ReadLine();
        }
    }
}
