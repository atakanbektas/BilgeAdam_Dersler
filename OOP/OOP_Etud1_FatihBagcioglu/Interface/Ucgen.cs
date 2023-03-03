using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Ucgen : ISekil
    {
        public Ucgen()
        {
            Console.WriteLine("Ucgen çizilmeye hazır.");

        }
        public void Ciz()
        {           
            Console.WriteLine("Ucgen Çizildi.");           
        }
    }
}
