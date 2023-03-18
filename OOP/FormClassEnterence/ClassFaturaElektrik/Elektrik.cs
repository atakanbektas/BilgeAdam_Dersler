using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFaturaElektrik
{
    internal class Elektrik
    {
		private int _ilkIndex;
		public int IlkIndex
		{
			get { return _ilkIndex; }
			set { _ilkIndex = value; }
		}

        private int _sonIndex;
        public int SonIndex
        {
            get { return _sonIndex; }
            set { _sonIndex = value; }
        }


        public Elektrik(int ilk,int son,int gun,int ay,int yil)
        {

        }

    }
}
