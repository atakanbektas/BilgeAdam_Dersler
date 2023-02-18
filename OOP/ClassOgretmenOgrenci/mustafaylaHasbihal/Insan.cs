using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafaylaHasbihal
{
    internal class Insan : Canli
    {
        public int AyakNo { get; set; }

        public Insan(int ayakNo):base(22)
        {
            AyakNo = ayakNo; 
        }
    }
}
