using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraclarInterface
{
    public interface IYakitKasko
    {
        string YakitTuru { get; set; }
        bool Kasko { get; set; }
    }
}
