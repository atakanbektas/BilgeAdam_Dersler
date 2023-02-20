using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanAdCinsClass
{
    internal class Kedi : Hayvan
    {

        public override string SesVer()
        {
            return "Miyavvv";
        }
     

        public override List<object> BilgiIste()
        {
            Ad = Console.ReadLine();
            Cins = Console.ReadLine();
            YasadigiYer = Console.ReadLine();
            Cinsiyet = Console.ReadLine();
            return new List<object>() {Ad, Cins, YasadigiYer, Cinsiyet };
        }
    }
}
