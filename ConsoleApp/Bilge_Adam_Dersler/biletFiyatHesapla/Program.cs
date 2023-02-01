using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletFiyatHesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci sayısı giriniz");
            int ogrenciSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Sivil sayısı giriniz");
            int sivilSayi = int.Parse(Console.ReadLine());
                     

            Console.WriteLine($"Toplam bilet fiyatı = {(ogrenciSayi<<3)-(ogrenciSayi) + ((sivilSayi<<3)+(2*sivilSayi))}");

            Console.ReadLine();
        }
    }
}
