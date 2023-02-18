using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBilgiGoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            kisi.GetMessage();

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.GetMessage();

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.GetMessage();

            DaliOlanOgrenci daliOlanOgrenci1 = new DaliOlanOgrenci();

            daliOlanOgrenci1.Dallar = new List<string>() { "Tiyator","Müzik" };

            
            Console.ReadKey();
        }
    }
}
