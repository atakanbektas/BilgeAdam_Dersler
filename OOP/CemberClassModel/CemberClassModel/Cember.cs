using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CemberClassModel
{
    internal class Cember
    {

        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }


        private double _merkezX;
        public double MerkezX
        {
            get { return _merkezX; }
            set { _merkezX = value; }
        }


        private double _merkezY;
        public double MerkezY
        {
            get { return _merkezY; }
            set { _merkezY = value; }
        }


        private double _yariCap;
        public double YariCap
        {
            get { return _yariCap; }
            set { _yariCap = value; }
        }

        public Cember(double x, double y, double r)
        {
            MerkezX = x;
            MerkezY = y;
            YariCap = r;
        }
        public void Goster()
        {
            string koordinatX = MerkezX.ToString();
            string koordinatY = MerkezY.ToString();
            string Alan = GetAlan().ToString();
            string Yaricap = YariCap.ToString();
            string Cevre = GetCevre().ToString();

        }
        public void SetMerkezXY(double x, double y)
        {
            MerkezX = x;
            MerkezY = y;
        }
        public void SetYariCap(double r)
        {
            YariCap = r;
        }
        public double GetAlan()
        {
            return Math.Round(Math.PI * Math.Pow(YariCap, 2),2);
        }
        public double GetCevre()
        {
            return Math.Round(2 * Math.PI * YariCap,2);
        }
        public double Mesafe(Cember a)
        {
            return Math.Round(Math.Sqrt(Math.Pow(MerkezX - a._merkezX, 2) + Math.Pow(MerkezY - a.MerkezY, 2)),2);
        }
        public bool IcindeMi(Cember a)
        {
            bool sonuc = false, kucukMu = false;
            kucukMu = a._yariCap < _yariCap ? true : false;

            if (kucukMu)
            {
                double yaricapFarklari = _yariCap - a._yariCap;
                sonuc = Mesafe(a) <= yaricapFarklari ? true : false;
            }
            return sonuc;
        }
        public Cember BuyukOlan(Cember b)
        {
            Cember sonuc = b;

            if (b._yariCap < _yariCap)
            {
                sonuc = this;
            }
            else if (b._yariCap == _yariCap)
            {
                sonuc = null;
            }

            return sonuc;
        }
        public string TegetYap(char eksen)
        {
            string result;
            if (eksen.ToString().ToUpper() == "X")
            {
                _merkezY = _yariCap;
                result = $"({_merkezX},{_merkezY})";
            }
            else if (eksen.ToString().ToUpper() == "Y")
            {
                _merkezX = _yariCap;
                result = $"({_merkezX},{_merkezY})";
            }
            else
            {
                result = "Girilen eksen 'X' veya 'Y' değildi.";
            }
            return result;
        }


    }
}
