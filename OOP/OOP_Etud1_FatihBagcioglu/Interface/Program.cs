using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        // bir interface abstract classlara benzerdir. Tüm metodları implemente edilmek zorundadırç
        /*
         * interface dediğimiz kavram diğerlerine göre basittir
         * class değildirler.
         * kendi başlarına operasyon yapamazlar.
         * miras verdiği sınıflarda oluşturulacak operasyonlar yalnızca metot kimliği taşır.
         * aynı isimlerde metotları farklı operasyonlar yürütebilmemize imkan sağlar.
         * aslında altına yazılan metodlar abstract metoddur.
         * Pholimorphizm diyoruz..
         */
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.Ciz();

            Console.WriteLine(new string('-',20));

            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.Ciz();

            Console.WriteLine(new string('-', 20));

            CizimAraci cizimAraci = new CizimAraci(new Ucgen());
            cizimAraci.Sergile();

            Console.Read();
        }
    }
}
