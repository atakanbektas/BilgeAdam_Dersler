using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenUcgenClass
{
    internal class Ucgen : IIslemYapilabilir
    {
        public Ucgen()
        {
            Console.WriteLine("Ucgen Olusturuldu.");

        }

        public string Ciz()
        {
            return "Ucgen Çizildi";
        }
    }
}
