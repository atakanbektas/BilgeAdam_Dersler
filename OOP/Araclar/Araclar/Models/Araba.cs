using Araclar.IOzellikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar.Models
{
    internal class Araba : Araclar, ISurus
    {
        public Araba()
        {
            
        }
        public override int Hiz { get; set; }
        public override string YakitTuru { get; set; }

        void ISurus.Parket()
        {

        }

        void ISurus.Sur()
        {

        }
    }
}
