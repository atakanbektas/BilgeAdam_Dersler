using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraclarInterface
{
    public interface IAracOzellikleri
    {
        int Model { get; set; }
        int Hiz { get; set; }
        string Renk { get; set; }
        string YakitTuru { get; set; }
        int TekerlekSayisi { get; set; }

    }
}
