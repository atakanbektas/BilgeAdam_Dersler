using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanAdCinsClass
{
    internal class Kopek : Hayvan
    {
        public override List<object> BilgiIste()
        {
            Ad = Console.ReadLine();
            Cins = Console.ReadLine();
            YasadigiYer = Console.ReadLine();
            Cinsiyet = Console.ReadLine();
            return new List<object>() { Ad,Cins,YasadigiYer,Cinsiyet};
        }

        public override string SesVer()
        {
            return "Hav Hav";
        }
    }
}
