using Araclar.IOzellikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar.Models
{
    internal class Otobüs : Araclar, ISurus
    {
        public Otobüs()
        {

        }
        public override int Hiz { get; set; }
        public override string YakitTuru { get; set; }

        public void Parket()
        {

        }

        public void Sur()
        {

        }
    }
}
