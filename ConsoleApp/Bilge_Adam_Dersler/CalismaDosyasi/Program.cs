using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalismaDosyasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = int.Parse(Console.ReadLine());
            int sayi2 = int.Parse(Console.ReadLine());
            int sonuc = 0;

            int x = 8;
            int temp = x << 2;
            temp = temp + x;
            bool isEqual = x << 2 == temp;
            string islem = isEqual ? "islem dogru" : "islem yanlıs";
            Console.WriteLine(islem);


            Console.WriteLine(x);

            int x = 8;
            int temp = x << 2;
            temp = temp + x;
            bool isEqual = x << 2 == temp;
            string islem = isEqual ? "islem dogru" : "islem yanlıs";
            Console.WriteLine(islem);


            Console.WriteLine(x);

            int x = 8;
            int temp = x << 2;
            temp = temp + x;
            bool isEqual = x << 2 == temp;
            string islem = isEqual ? "islem dogru" : "islem yanlıs";
            Console.WriteLine(islem);


            Console.WriteLine(x);

            int x = 8;
            int temp = x << 2;
            temp = temp + x;
            bool isEqual = x << 2 == temp;
            string islem = isEqual ? "islem dogru" : "islem yanlıs";
            Console.WriteLine(islem);


            Console.WriteLine(x);

            Console.WriteLine(Topla(sayi1,sayi2));
            Console.ReadKey();
        }
          
        static int Topla(int sayi1, int sayi2)
        {            

            return (sayi1 + sayi2);
            
        }
    }
}
