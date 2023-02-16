using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    internal class Müsteri
    {
        private string name;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public void IsimIste()
        {
            Console.WriteLine("Müsteri adi giriniz!");
            name = Console.ReadLine();
        }

        public void Yazdir()
        {
            Console.WriteLine($"Müşteri adı = {name.ToUpper()}");
        }
    }
}
