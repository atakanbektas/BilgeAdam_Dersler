using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 3, 5, 8 };
            int[] array2 = new int[5];
            int[] array3 = new int[4];


            //CopyTO
            array1.CopyTo(array2,1);
            foreach (var item in array2)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            
            //Copy
            Array.Copy(array1, array3, 4);
            foreach (var item in array3)
            {
                Console.Write(item+" ");
            } 
            Console.WriteLine();


            //Clone
            int[] array4 = (int[])array1.Clone();
            foreach (var item in array4)
            {
                Console.Write(item+" ");
            }


            

            Console.ReadLine();
        }
    }
}
