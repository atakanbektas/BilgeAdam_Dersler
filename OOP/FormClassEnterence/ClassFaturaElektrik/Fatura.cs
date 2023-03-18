using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFaturaElektrik
{
    internal class Fatura
    {
		private int _sonOdemeGun;
		public int SonOdemeGun
		{
			get { return _sonOdemeGun; }
			set { _sonOdemeGun = value; }
		}


        private int _sonOdemeAy;
        public int SonOdemeAy
        {
            get { return _sonOdemeAy; }
            set { _sonOdemeAy = value; }
        }



        private int _sonOdemeYil;
        public int SonOdemeYil
        {
            get { return _sonOdemeYil; }
            set { _sonOdemeYil = value; }
        }


        protected double _tutar;
        public double Tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        } 

        public void SetSonOdemeTarihi(int gun, int ay, int yil)
        {

        }
        public void SetTutar(double tutar)
        {

        }
        public bool SonTarihiGecmisMi(int gun, int ay, int yil)
        {
            return true;
        }

        public void Yazdir()
        {

        }



    }
}
