using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    abstract class BaseClass
    {
        static protected int id { get; set; } = 0;
        public DateTime OlusturulmaTarihi { get; set; }
        public long Barkod { get; set; }
        public DateTime GuncellemeTarihi { get; set; }

     

        public BaseClass()
        {
            id++;
        }

    }
}
