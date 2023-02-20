using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme2OgretmenOgrenci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Atakan";
            ogrenci.Soyad = "Terzi";
            ogrenci.Yas = int.Parse(Console.ReadLine());
            ogrenci.Hobi = "Tiyatro";

            ogrenci.Yazdir();
            Console.ReadLine();
        }
    }
}
