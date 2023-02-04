using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriyeli Hesaplanacak sayıyı giriniz.!");
            Console.WriteLine($"Faktoriyelinizin sonucu = {GetFact(int.Parse(Console.ReadLine()))}");
            Console.Read();
        }

        private static int GetFact(int num)
        {
            if (num==1)
            {
                return 1;
            }
            return num * GetFact(num - 1);
        }
    }
}
