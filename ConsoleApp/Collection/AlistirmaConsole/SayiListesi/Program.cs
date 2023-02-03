using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiListesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>() { 3, 1, 1, 4, 5, 4, 7, 9, 6, 2, 1, 6 };
            Yazdir(sayilar);

            Console.ReadLine();
        }

        private static void Yazdir(List<int> sayilar)
        {
            Console.WriteLine(string.Join(" ",sayilar));

            //for (int i = 0; i < sayilar.Count; i++)
            //{
            //    if (sayilar[i] == 1)
            //    {
            //        sayilar.Remove(1);                    
            //    }                
            //}

            //while (sayilar.Contains(1))
            //{
            //    sayilar.Remove(1);
            //}
            //Console.WriteLine(string.Join(" ", sayilar));
            //Console.WriteLine(string.Join(" ", sayilar));

            sayilar.RemoveAll(sayi => sayi == 1);
            Console.WriteLine(string.Join(" ", sayilar));


        }
    }
}
