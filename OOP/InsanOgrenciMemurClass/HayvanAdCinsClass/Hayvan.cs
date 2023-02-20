using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanAdCinsClass
{
    abstract class Hayvan
    {
        public string Ad { get; set; }
        public string Cins { get; set; }
        public string YasadigiYer { get; set; }
        public string Cinsiyet { get; set; }

        public abstract List<object> BilgiIste();
        public abstract string SesVer();

    }
}
