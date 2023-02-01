using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFoundIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* [14:51] Fatih Bağcıoğlu(BilgeAdam Boost)
 2SORU 10 elemanlı bir dizi tanımlayalım. içerisindeki 2'lerin indexlerini veren program

 [14:51] Fatih Bağcıoğlu(BilgeAdam Boost)
 index numaralarını veren program.[14:51] Fatih Bağcıoğlu(BilgeAdam Boost)
 10 eleman Random olsun, eğer 2 var index numaralarını versin. 1 ile 10 arası*/

            Random rnd = new Random();
            int i = 0, sayac = 0;
            int[] nums = new int[10];
            

            foreach (var item in nums)
            {
                nums[i] = rnd.Next(1, 5);
                if (nums[i] == 2)
                {
                    sayac++;
                    Console.WriteLine($"Index numaraları ={i}");
                }

                i++;
            }

            Console.WriteLine($"\nDizinin içinde '2' sayısı {sayac} adet vardır.");

            Console.ReadLine();




        }
    }
}
