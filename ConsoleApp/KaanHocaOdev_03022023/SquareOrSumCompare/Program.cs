using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOrSumCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen başlangıç sayısı giriniz.");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen bitiş sayısı giriniz.");
            int stop = int.Parse(Console.ReadLine());

           int sumOfSquare =  GetSumOfSquare(start, stop);
           int squareOfSum =  GetSquareOfSum(start, stop);

            Console.WriteLine($"Aralıktaki sayıların toplamlarının karesi = {squareOfSum}");
            Console.WriteLine($"Aralıktaki sayıların karelerinin toplamı = {sumOfSquare}");

            Console.ReadLine();
        }

        private static int GetSquareOfSum(int start, int stop)
        {
            int sum = 0;
            for (int i = start; i <= stop; i++)
            {
                sum += i;
            }
            return (int)Math.Pow(sum, 2);
        }

        private static int GetSumOfSquare(int start, int stop)
        {
            int sum = 0;
            for (int i = start; i <= stop; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }
            return sum;
        }
    }
}


