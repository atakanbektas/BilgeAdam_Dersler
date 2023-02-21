using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenUcgenClass
{
    internal class Dikdörtgen : IIslemYapilabilir
    {
        public Dikdörtgen()
        {
            Console.WriteLine("Dikdörtgen Oluşturuldu");
        }

        public string Ciz()
        {
            return "Dikdörtgen Çizildi";
        }
    }
}
