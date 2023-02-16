using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDortgen
{
    internal class DikDortgen
    {
        private double Solx { get; set; }
        private double Soly { get; set; }
        private double Sagx { get; set; }
        private double Sagy { get; set; }

        public DikDortgen(double a,double b,double c,double d)
        {
            Solx = a;
            Soly = b;
            Sagx = c;
            Sagy = d;
        }
        public void SetSolUst(double a, double b)
        {
           
        }
        public void SetSagAlt(double a, double b)
        {

        }
        public double GetBoy()
        {
            return Sagx-Solx;
        }
        public double GetEn()
        {
            return Sagy-Soly;
        }
        public double GetAlan()
        {
            return GetEn()*GetBoy();
        }
        public double GetCevre()
        {
            return (GetEn()+GetBoy())*2;
        }
        public DikDortgen BuyukOlan(DikDortgen b)
        {
            return b;
        }
        public void KareYap()
        {
            

            
        }


    }
}
