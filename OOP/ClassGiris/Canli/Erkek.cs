using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canli
{
    internal class Erkek : Insan
    {
        public bool AskerlikYapildiMi { get; set; }

        public Erkek(long tcNo)
        {
            TcNo = tcNo;
        }
    }
}
