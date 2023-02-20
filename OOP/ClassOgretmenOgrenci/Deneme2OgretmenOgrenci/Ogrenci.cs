using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme2OgretmenOgrenci
{
    internal class Ogrenci : Insan
    {
        public string Hobi { get; set; }

        public void Yazdir()
        {
            Console.WriteLine("ADI : "+Ad);
            Console.WriteLine("SOYADI : "+Soyad);
            Console.WriteLine("YASI : "+Yas);
            Console.WriteLine("HOBİSİ : "+Hobi);
        }
    }
}
