using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    internal class Kebapci
    {
        private string name;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            if (name.ToLower()=="aspava")
            {
                Console.WriteLine("Girilen isim aynıdır.");
            }
            else
            {
                Console.WriteLine("İsim aynı değildir.");
            }
            this.name = name;
        }
        public void IsimIste()
        {
            Console.WriteLine("Kebapci adi giriniz!");
            name = Console.ReadLine();
        }

        public void Yazdir()
        {
            Console.WriteLine($"Kebapci adi : {name.ToUpper()}");
        }
    }
}
