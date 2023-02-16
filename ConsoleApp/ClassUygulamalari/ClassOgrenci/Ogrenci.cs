using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassOgrenci
{
    internal class Ogrenci
    {
        public static int count = 0;

        public string Ad { get; set; }
        public string Soyad { get; set; }

        private int ogrenciNo;
        public int OgrenciNo
        {
            get { return ogrenciNo; }
            set
            {
                if (value.ToString().Length == 3)
                {
                    ogrenciNo = value;
                }
                else
                {
                    Console.WriteLine("Öğrenci no 3 basamaklı sayı olmalıdır.");
                    ApplicationException applicationException = new ApplicationException();
                    Console.WriteLine(applicationException.Message);
                    Console.WriteLine("Program Kapatılıyor.....");
                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            }
        }

        private long tcNo;
        public long TcNo
        {
            get
            {
                return tcNo;
            }
            set
            {
                if (value.ToString().Length == 11)
                {
                    tcNo = value;
                }
                else
                {
                    Console.WriteLine("TC Kimlik No 11 basamaklı sayı olmalıdır.");
                    ApplicationException applicationException = new ApplicationException();
                    Console.WriteLine(applicationException.Message);
                    Console.WriteLine("Program Kapatılıyor.....");
                    System.Threading.Thread.Sleep(15000);
                    Environment.Exit(0);
                }

            }
        }

        public void Yazdir()
        {
            Console.WriteLine($"{count}. Öğrenci adı = {Ad} ");
            Console.WriteLine($"{count}. Öğrenci soyadı = {Soyad} ");
            Console.WriteLine($"{count}. Öğrenci T.C = {tcNo} ");
            Console.WriteLine($"{count}. Öğrenci Öğrenci No = {ogrenciNo} ");
        }
        public Ogrenci(string ad, string soyad, long tcNo, int ogrenciNo)
        {
            count++;
            Ad = ad;
            Soyad = soyad;
            TcNo = tcNo;
            OgrenciNo = ogrenciNo;
        }



    }
}
