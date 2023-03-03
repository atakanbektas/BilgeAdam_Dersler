using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Etud1_FatihBagcioglu
{
    internal class Kisi
    {
        public Kisi()
        {
            Console.WriteLine("Kisi oluşturuldu");
        }
        private string _ad;

        public string Ad
        {
            get { return "Mr. " + _ad; }
            set { _ad = value; }
        }

        public string Soyad { get; set; }
        private int _yas;

        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value < 18)
                {
                    _yas = 18;
                }
                else 
                {
                    _yas = value;
                }

            }
        }




        public static void Metot()
        {
            Console.WriteLine("Kisi sınıfından oluşturulan metodum");
        }
    }
}
