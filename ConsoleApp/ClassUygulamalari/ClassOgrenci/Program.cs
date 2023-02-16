using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassOgrenci
{
    internal class Program
    {

        static void Main()
        {
            Ogrenci ogrenci1 = new Ogrenci("Aykut","Terzi",32145632310,389);
            ogrenci1.Yazdir();
            Ayrac();

            Ogrenci ogrenci2 = new Ogrenci("Gökçehan","Gucuk",12345678901,101);
            ogrenci2.Yazdir();
            Ayrac();

            Ogrenci ogrenci3 = new Ogrenci("Atakan", "Bektaş", 13598642311, 327);
            ogrenci3.Yazdir();
            Ayrac();

            


            Console.Read();
        }

        private static void Ayrac()
        {            
            Console.WriteLine("\n\n\n");
        }
    }
}
