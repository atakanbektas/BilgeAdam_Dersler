using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKDV
{
    internal class Urun
    {

        public decimal Fiyat { get; set; }
        public decimal KdvFiyati { get; set; }


        public Urun(decimal fiyat)
        {
            Fiyat = fiyat;
            KdvFiyati = fiyat*1.18m;
        }
    }
}
