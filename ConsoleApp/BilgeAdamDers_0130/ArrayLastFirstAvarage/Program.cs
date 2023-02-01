using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLastFirstAvarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir adet 10 elemanlı elemanlarını rastgele girilen dizi tanımlayın. Bu dizi içerisindeki elemanların toplamını, ortalamasını, ilk ve son elemanını ekrana yazdırın.*/
            Random rnd = new Random();
            int[] nums = new int[10];
            int i = 0;
            foreach (var item in nums)
            {
                nums[i] = rnd.Next(1,10);
                Console.Write(nums[i++] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"İlk Eleman ={nums.First()}");
            Console.WriteLine($"Son Eleman ={nums.Last()}");
            Console.WriteLine($"En büyük ={nums.Max()}");
            Console.WriteLine($"En küçük ={nums.Min()}");
            Console.WriteLine($"Toplamı ={nums.Sum()}");
            Console.WriteLine($"Ortalama ={nums.Average()}");
            

            Console.ReadLine();

        }
    }
}
