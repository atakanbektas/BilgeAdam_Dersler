using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isTrue = true;
            int deger = isTrue ? 1 : 0;
            Console.WriteLine($"bool değerin dönüştürülmüş sayısı ve tipi = {deger}{deger.GetType()}");


            decimal dcm = 7m;
            int deger2 = (int)dcm;
            Console.WriteLine($"{deger2} sayısının tipi: {deger2.GetType()}");



            double sayi1 = 56/10;
            int sayi2 = (int)sayi1;
            Console.WriteLine(sayi2);

            double sayi3 = 5.6;
            int sayi4 = (int)sayi3;
            Console.WriteLine(sayi4);

            double sayi5 = 5.6;
            int sayi6 = Convert.ToInt32(sayi5);
            Console.WriteLine(sayi6);


            Console.ReadKey();
        }
    }
}
// Convert edilen değer küsüratlı sayıysa, yakın olan değere gider. Cast işleminde ise tam sayı kısmına eşit olur. 