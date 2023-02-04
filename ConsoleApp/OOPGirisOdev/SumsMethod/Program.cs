using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine(GetSum(sum,int.Parse(Console.ReadLine())));
        }

        private static int GetSum(int sum, params int[] nums)
        {
            sum += nums[0];
            Console.Write($"Toplam = {sum} + ");
            return GetSum(sum, int.Parse(Console.ReadLine()));
        }
    }
}
