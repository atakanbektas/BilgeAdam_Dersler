using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme2OgretmenOgrenci
{
    internal class Insan
    {
        private int _yas;
        public int Yas
        {
            get { return _yas; }
            set { _yas = value < 18 ? 18 : (value > 26 ? value + 3 : value); }
        }


        private string _ad;
        public string Ad
        {
            get { return "Sayın : " + _ad; }
            set { _ad = value; }
        }

        public string Soyad { get; set; }



    }
}
