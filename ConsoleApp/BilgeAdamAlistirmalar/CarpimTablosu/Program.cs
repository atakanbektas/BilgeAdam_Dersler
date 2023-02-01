using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i<10)
            {
               int k = 0;
                while (k<9)
                {
                    k++;
                    Console.Write(String.Format("{0,-1} * {1,-1} = {2,-7}",k,i,i*k));
                    
                    //Console.Write($"{i}*{k} = {i*k} ");
                    
                }
                Console.WriteLine();
                i++;
            }

            Console.ReadKey();
        }
    }
}
