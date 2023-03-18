using Araclar.IOzellikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar.Models
{
    internal class Gemi : Araclar, IGemi
    {
        public Gemi()
        {

        }
        public override int Hiz { get; set; }
        public override string YakitTuru { get; set; }

        public string DumeneGec()
        {
            return "";
        }

        public string LimanaBagla()
        {
            return "";
        }
    }
}
