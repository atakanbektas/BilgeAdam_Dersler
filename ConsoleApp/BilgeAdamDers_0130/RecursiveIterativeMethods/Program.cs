using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveIterativeMethods //Faktoriyel hesaplama RecursiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faktoriyeli hesaplanacak sayıyı giriniz.");
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int j;
            Console.WriteLine(Deneme(x,out j));
            Console.WriteLine(RecursiveMethod(n));
            Console.Read();
        }

        static int RecursiveMethod(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n*RecursiveMethod(n-1);
        }
        static int Deneme(int k,out int x)
        {
            x = 5;
            return 0;
        }
    }
}
