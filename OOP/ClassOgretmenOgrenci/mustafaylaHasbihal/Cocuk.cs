using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafaylaHasbihal
{
    internal class Cocuk : Insan
    {        
        private string Kresi { get; set; }

        public Cocuk(string kresi):base(35)
        {
            Kresi = kresi;
        }
    }
}
