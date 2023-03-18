using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Listem listem = new Listem();
            listem.Ekle(3);
            listem.Ekle("Atakan");
            listem.Ekle("Baran");
            listem.Ekle(3.5d.GetType());

            //1074528256


            foreach (var item in listem)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
