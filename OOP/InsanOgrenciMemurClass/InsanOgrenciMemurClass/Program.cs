using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanOgrenciMemurClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ogrenci ogrenci1 = new Ogrenci();
            //ogrenci1.Adi = "Aykut";
            //ogrenci1.Soyadi = "Terzi";
            //ogrenci1.Sinif = "Boost";
            //ogrenci1.Bolum = "Yazılım";
            //ogrenci1.DogumTarihi = Convert.ToDateTime("01.01.1989");
            //ogrenci1.BirimAdi = "Bilgisayar";
            //ogrenci1.OgrenciNo = 01;
            //ogrenci1.tcKimlikNo = 32401010101;
            //ogrenci1.BilgileriGoster();


            //Console.WriteLine();

            //Memur memur1 = new Memur();
            //memur1.DogumTarihi = DateTime.Now;
            //memur1.Adi = "Gokcehan";
            //memur1.Soyadi = "Gucuk";
            //memur1.tcKimlikNo = 34512353210;
            //memur1.BirimAdi = "Şantiye";
            //memur1.BilgileriGoster();

            //Console.WriteLine();

            //Akademisyen akademisyen1 = new Akademisyen();
            //akademisyen1.Adi = "Mustafa";
            //akademisyen1.Soyadi = "Mehmet Özcan";
            //akademisyen1.DogumTarihi = DateTime.Now;
            //akademisyen1.BirimAdi = "TESTER";
            //akademisyen1.Program = "Global Test";
            //akademisyen1.tcKimlikNo = 11111111111;
            //akademisyen1.Mail = "mustafahatabulur@gmail.com";
            //akademisyen1.BilgileriGoster();

            //Console.WriteLine();

            //Insan insan1 = new Insan();
            //insan1.Adi = "Sultan";
            //insan1.Soyadi = "Hasret";
            //insan1.DogumTarihi = DateTime.Now;
            //insan1.tcKimlikNo = 51515151515;
            //insan1.BilgileriGoster();
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.BilgileriAl();
            ogrenci1.BilgileriGoster();
            Console.WriteLine();

            Insan insan1 = new Insan();
            insan1.BilgileriAl();
            insan1.BilgileriGoster();
            Console.WriteLine();

            Akademisyen akademisyen1 = new Akademisyen();
            akademisyen1.BilgileriAl();
            akademisyen1.BilgileriGoster();
            Console.WriteLine();

            Memur memur1 = new Memur();
            memur1.BilgileriAl();
            memur1.BilgileriGoster();
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
