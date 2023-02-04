using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArrayWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[9] { 17, 222, 30, -4, -15, 60, 0, 12, 21 };
            PrintArray(nums);
            Console.ReadKey();
        }
        static void PrintArray(int[] nums)
        {
            int i = 0;
            while (i < 9)
            {
                Console.WriteLine(string.Format("{1}.Sayınız = {0}", nums[i++],i));
            }

        }

    }
}
