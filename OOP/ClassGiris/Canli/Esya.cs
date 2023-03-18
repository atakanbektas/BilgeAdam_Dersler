using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canli
{
    //class'lar internal veya public olmak zorundadır. Çünkü inheritance yapılırsa zaten özellikleri kullanılabileceğinden protected yapılması saçma olur, aynı şekilde private yapmak da saçma olur çünkü ulaşılamayacaksa neden class oluşturduk..
    internal class Esya
    {
        public int Fiyat { get; set; }
    }
}
