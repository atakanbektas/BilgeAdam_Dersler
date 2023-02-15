using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassFirin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firin firin1 = new Firin();
            firin1.Marka = "Bosch";
            firin1.Model = "HBF514BW0T Beyaz Ankastre Fırın";
            firin1.MaxDerecesi = 275;
            firin1.Guc = "3.3KW";
            firin1.GarantiVarMi = true;
            firin1.GarantiSuresi = 2;
            firin1.Fiyat = 6210m;
            //firin1.GarantiUzat("firin1");

            Firin firin2 = new Firin();
            firin2.Marka = "Beko";
            firin2.Model = " Bfe 400 B A Enerji Sınıfı 66 lt Ocaklı Fırın";
            firin2.MaxDerecesi = 290;
            firin2.Guc = "3.5KW";
            firin2.GarantiVarMi = true;
            firin2.GarantiSuresi = 3;
            firin2.Fiyat = 7100m;
            //firin2.GarantiUzat("firin2");

            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 50)));

            Console.WriteLine("1. FIRININ ÖZELLİKLERİ");
            Console.WriteLine($"Markası : {firin1.Marka}");
            Console.WriteLine($"Modeli : {firin1.Model}");
            Console.WriteLine($"Max derecesi : {firin1.MaxDerecesi}");
            Console.WriteLine($"Gücü : {firin1.Guc}");
            Console.WriteLine($"Garantisi var : {firin1.GarantiVarMi}");
            Console.WriteLine($"Garanti süresi : {firin1.GarantiSuresi}");
            Console.WriteLine($"Fiyatı : {firin1.Fiyat}");

            Console.WriteLine(string.Concat(Enumerable.Repeat("-",50)));

            Console.WriteLine("2. FIRININ ÖZELLİKLERİ");
            Console.WriteLine($"Markası : {firin2.Marka}");
            Console.WriteLine($"Modeli : {firin2.Model}");
            Console.WriteLine($"Max derecesi : {firin2.MaxDerecesi}");
            Console.WriteLine($"Gücü : {firin2.Guc}");
            Console.WriteLine($"Garantisi var : {firin2.GarantiVarMi}");
            Console.WriteLine($"Garanti süresi : {firin2.GarantiSuresi}");
            Console.WriteLine($"Fiyatı : {firin2.Fiyat}");


            
                      
            Console.Read();
        }
    }
}
