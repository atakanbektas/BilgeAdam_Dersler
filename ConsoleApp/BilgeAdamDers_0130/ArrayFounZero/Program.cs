using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFounZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden kullanıcı tarafından girilen, beş elemanlı bir sayı dizisinde, son rakamı 0(sıfır) olan sayıların sayısını bulan programı yazınız.*/
            int i = 0, sayac = 0;
            int[] nums = new int[5];
            foreach (var item in nums)
            {
                Console.WriteLine($"Lütfen{i + 1}.sayıyı giriniz!");
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] % 10 == 0)
                {
                    sayac++;
                }
            }
            Console.WriteLine($"Girdiğiniz sayılardan {sayac} tanesinin son rakamı '0' dır");
            Console.Read();

        }
    }
}
