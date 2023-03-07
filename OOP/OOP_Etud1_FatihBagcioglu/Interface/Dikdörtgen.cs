using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Dikdörtgen : ISekil
    {
        public Dikdörtgen()
        {
            Console.WriteLine("Dikdörtgen çizilmeye hazır.");
        }
        public void Ciz()
        {
            Console.WriteLine("Dikdörtgen Çizildi.");
        }
    }
}
