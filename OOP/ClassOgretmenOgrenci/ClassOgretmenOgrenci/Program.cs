using ClassOgretmenOgrenci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOgretmenOgrenci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insanOgrenci1 = new Insan();
            insanOgrenci1.Yas = 15;
            insanOgrenci1.Ad = "Cemtuğ";

            Insan insanOgretmen1 = new Insan();
            insanOgretmen1.Yas = 27;
            insanOgretmen1.Ad = "Fatih";
            

            Console.WriteLine(insanOgrenci1.Yas);
            Console.WriteLine(insanOgretmen1.Yas);
            Console.WriteLine(insanOgrenci1.Ad);

            Console.ReadKey();

        }
    }
}
