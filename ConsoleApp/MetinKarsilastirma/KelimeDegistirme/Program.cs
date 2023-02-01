using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen metin gir!");
            string metin = Console.ReadLine();
            Console.WriteLine("Değişecek kelime gir!");
            string degisecekKelime = Console.ReadLine();
            Console.WriteLine("Yerine getirilecek kelime gir");
            string atanacakKelime = Console.ReadLine();

            Console.WriteLine(metin.Replace(degisecekKelime, atanacakKelime));
            Console.ReadLine();
        }
    }
}
