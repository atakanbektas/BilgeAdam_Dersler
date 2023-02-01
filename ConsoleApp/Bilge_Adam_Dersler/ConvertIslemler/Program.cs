using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"Girdiğiniz değerin 3 katı {Convert.ToInt32(Console.ReadLine())*3}" );


            //string sayiStrin = "3";
            //int sayiInt = Convert.ToInt32(sayiStrin);
            ////var sayiVar = Convert.ToInt32(sayiStrin);

            //Console.WriteLine(sayiInt);
            //Console.WriteLine($"İlk girilen sayi tipi : {sayiStrin.GetType()}");
            //Console.WriteLine($"Döndürülmüş sayinin tipi : {sayiInt.GetType()}");
            ////Console.WriteLine($"Var tipinin sayinin tipi  : {sayiInt.GetType()}");

            string sayiStrin = "3";
            int sayiInt = int.Parse(sayiStrin);       

            Console.WriteLine($"İlk girilen sayi tipi : {sayiStrin.GetType()}");
            Console.WriteLine($"Döndürülmüş sayinin tipi : {sayiInt.GetType()}");

            string a = "5";
            int aInt = int.Parse(a);
            
            Console.WriteLine($"{aInt++} ve bu sayinin tipi = {aInt.GetType()}");
            
          



            Console.ReadLine();

        }
    }
}
// ++ işlemi eğer sayıdan sonra yazılırsa önce yazdırır sonra artırır.
// ++ işlemi eğer sayıdan önce yazılırsa önce artırır sonra yazdırır.
// compiler assambly koduna çeviren derleyicidir.