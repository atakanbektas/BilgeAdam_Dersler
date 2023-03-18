using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrenciNoOlustur("atakan", "bektas", "yazilim", 1);
            ogrenci.OgrenciYazdir();

            Console.ReadKey();
        }
    }
}
