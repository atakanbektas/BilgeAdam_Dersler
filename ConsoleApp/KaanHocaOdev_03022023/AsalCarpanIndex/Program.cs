using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalCarpanIndex
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sayac = 0;
            int k;
            Console.WriteLine("Kaçıncı sıradaki asal çarpanı bulmak istiyorsunuz?");
            int indexNo = int.Parse(Console.ReadLine());
            for (int i = 2; i < int.MaxValue; i++)
            {
                k = AsalCarpanBul(i);
                if (k != 0)
                {
                    sayac++;
                    if (sayac == indexNo)
                    {
                        i = int.MaxValue;
                        Console.WriteLine(k);
                    }
                }
            }
            Console.ReadLine();
        }
        static int AsalCarpanBul(int sayi)
        {
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return 0;
                }
            }
            return sayi;
        }      
    }
}
