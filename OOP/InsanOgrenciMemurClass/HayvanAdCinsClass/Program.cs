using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanAdCinsClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek();
            Console.WriteLine($"Köpek sesi = {kopek.SesVer()}");

            Kedi kedi = new Kedi();
            Console.WriteLine($"Kedi sesi = {kedi.SesVer()}");
            List<object> listKedi =  kedi.BilgiIste();
            List<object> listKopek = kopek.BilgiIste();

            foreach (var item in listKedi)
            {
                Console.WriteLine($"Kedi = {item}");
            }
            foreach (var item in listKopek)
            {
                Console.WriteLine($"Köpek = {item}");
            }

            Console.ReadKey();
        }
    }
}
