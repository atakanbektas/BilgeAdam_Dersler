using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    internal class Donerci
    {
        public string Name { get; set; } = "Dönercim Döner";

        public void Yazdir()
        {
            Console.WriteLine($"Dönerci adı = {Name.ToUpper()}");
        }
        public void IsimIste()
        {
            Console.WriteLine("Donerci adi giriniz!");
            Name = Console.ReadLine();
        }
    }
}
