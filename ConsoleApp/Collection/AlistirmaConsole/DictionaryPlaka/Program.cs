using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPlaka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirler = new Dictionary<int, string>();
            sehirler.Add(1, "Adana");
            sehirler.Add(2, "Adıyaman");
            sehirler.Add(3, "Afyon");
            sehirler.Add(4, "Ağrı");
            sehirler.Add(5, "Amasya");
            sehirler.Add(6, "Ankara");
            sehirler.Add(7, "Antalya");
            sehirler.Add(8, "Artvin");
            sehirler.Add(9, "Aydın");
            sehirler.Add(10, "Balıkesir");

            foreach (var item in sehirler)
            {
                Console.WriteLine(item.Key + "  " + item.Value );
            }
            sehirler.Remove(1);
            sehirler[6] = "Angara";


            Console.WriteLine("--------------------------------");
            foreach (var item in sehirler)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }


            Console.ReadLine();
        }
    }
}
