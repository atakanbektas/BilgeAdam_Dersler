using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Canli
{
    internal class Kadin : Insan
    {
        private bool _anneMi;

        public bool AnneMi
        {
            get { return _anneMi; }
            set { _anneMi = value; }
        }
        
        public Kadin(long tcNo)
        {
            TcNo = tcNo;
        }
        
    }
}
