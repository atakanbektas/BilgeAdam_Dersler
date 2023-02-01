using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5, j = 3;
            string metin = "BilgeAdam";
            OnKereYaz(metin);
            CarpYaz(i, j);
            ToplaYaz(i, j);
            BirdenYuzeYaz();
            Console.WriteLine("\nKaresi alınacak sayıyı giriniz");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(KareAl(k));
            Console.Read();
        }
        private static void BirdenYuzeYaz()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + " ");
            }
        }
        private static int KareAl(int k)
        {
            return (int)Math.Pow(k, 2);
        }
        private static void CarpYaz(int i, int j)
        {
            Console.WriteLine($"Çarpım sonucu ={i * j}");
        }
        private static void ToplaYaz(int i, int j)
        {
            Console.WriteLine($"Toplam sonucu ={i + j}");
        }
        private static void OnKereYaz(string metin)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(metin);
            }
        }
    }
}
