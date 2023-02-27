using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenUcgenClass
{
    internal class CizimAraci
    {
        private readonly IIslemYapilabilir _islem;

        public CizimAraci(IIslemYapilabilir islem)
        {
            _islem = islem;
        }

        public string Ciz()
        {
            return _islem.Ciz();
        }
        
            
        
    }
}
