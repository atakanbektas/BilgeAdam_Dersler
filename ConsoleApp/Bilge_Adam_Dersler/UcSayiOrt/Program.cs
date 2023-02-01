using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcSayiOrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double sonuc;

            Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü sayıyı giriniz.");
            int k = Convert.ToInt32(Console.ReadLine());



            sonuc = Convert.ToDouble(i + j + k)/3;
            Console.WriteLine("Sonucunuz =" + sonuc);

            Console.ReadLine();
        }
    }
}
