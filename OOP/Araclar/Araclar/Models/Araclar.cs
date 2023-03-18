using Araclar.IOzellikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar.Models
{
    abstract class Araclar : IAracTur, IAracMekanik, IBakim, IVitesDegistir
    {
        public string Model { get; set; }
        public string Renk { get; set; }
        public string Kasko { get; set; }
        public abstract int Hiz { get; set; }
        public abstract string YakitTuru { get; set; }

        public string BakimaGit()
        {
            return "";
        }

        public string VitesDegistir()
        {
            return "";
        }
    }
}
