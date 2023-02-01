using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*[14:03] Fatih Bağcıoğlu (BilgeAdam Boost)
            1.SORU Elemanları rastgele(1,10000 dahil) tamsayılardan oluşan 30 elemanlı bir dizinin 2'ye tam bölünebilen elemanlarını küçükten büyüğe; hem 2'ye hem de 3'e bölünebilenlerinin sayısını ekrana yazan program.*/

            Random rnd = new Random();
            int i = 0;
            int[] nums = new int[30];
            foreach (int n in nums)
            {
                nums[i++] = rnd.Next(1, 10001);
            }
            Array.Sort(nums);
            Console.WriteLine("İkiye Bölünenler");
            IkiyeBolunen(nums);
            Console.WriteLine("\nİkiye ve Üçe Bölünenler");
            IkiyeVeUceBolunen(nums);

            Console.ReadLine();

        }
        static void IkiyeVeUceBolunen(params int[] nums)
        {
            int sayac = 0;
            foreach (var item in nums)
            {
                if (item % 2 == 0 && item%3==0)
                {
                    Console.Write(item + " ");
                    sayac++;
                }
            }
            Console.WriteLine($"\n2 ve 3 e bölünen sayıların sayısı: {sayac}");
            
        }


        static void IkiyeBolunen(params int[] nums)
        {
            foreach (var item in nums)
            {
                if (item%2==0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            
        }
    }
}
