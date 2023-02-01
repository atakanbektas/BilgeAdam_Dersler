using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFoundRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*10 elemanlı bir dizinin elemanları 1-1000 arasında bilgisayar tarafından rastgele atanacaktır. Bu dizideki 500-600 arasındaki sayıların toplamı ile 100-500 arasındaki sayıların sayısını bulan programı yazınız.*/

            Random rnd = new Random();
            int[] nums = new int[10];
            int i = 0, sum = 0;

            foreach (var item in nums)
            {
                nums[i] = rnd.Next(1, 1000);
                Console.Write(nums[i]+" ");
                Console.WriteLine();
                if (nums[i]>=500 && nums[i]<=600)
                {
                    sum += nums[i];
                }
              
                i++;

            }
            i = 0;
            foreach (var item in nums)
            {
                if (nums[i] >= 100 && nums[i] <= 500)
                {
                    Console.WriteLine($"100-500 Arası sayılar ={nums[i]}");
                }
                i++;
            }
            Console.WriteLine($"Sayıların Toplamı = {sum}");
            Console.ReadKey();
        }
    }
}
