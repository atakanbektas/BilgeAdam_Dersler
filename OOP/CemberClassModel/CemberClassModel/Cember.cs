using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CemberClassModel
{
    internal class Cember
    {
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

		public Cember(double x,double y,double r)
		{
			MerkezX = x;
			MerkezY = y; 
		    YariCap = r;
		}


		public void Yaz()
		{

		}
		
		public void SetMerkezXY(double x, double y)
		{
			MerkezX = x;
			MerkezY	= y;
		}
		public void SetYariCap(double r)
		{
			YariCap = r;
		}
		public double GetAlan()
		{
			return Math.PI*Math.Pow(YariCap,2);
		}
		public double GetCevre()
		{
			return 2*Math.PI*YariCap;
		}
		public double Mesafe(Cember a)
		{
			return 0;
		}
		public bool IcindeMi(Cember a)
		{
			return true;
		}
		public Cember BuyukOlan(Cember b)
		{
			return b;
		}
		public void TegetYap(char eksen)
		{

		}


	}
}
