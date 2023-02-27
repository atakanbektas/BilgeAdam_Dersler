using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraclarInterface.Concrates
{
    internal abstract class Arac:IAracOzellikleri,IVitesDegistir,IYakitKasko,IEylemler
    {
        private int _hiz;
        public int Hiz
        {
            get { return _hiz; }
            set { _hiz = value; }
        }

        private string _renk;
        public string Renk
        {
            get { return _renk; }
            set { _renk = value; }
        }

        public int Model { get; set ; }
        public string YakitTuru { get; set ; }
        public int TekerlekSayisi { get ; set ; }
        public  bool Kasko { get ; set ; }

        public abstract string AracOzellikleriniGoster();
        public string Durdur(object obj)
        {
            return $"{obj} nesnesi durdu.";
        }

        public void Sur(object obj)
        {
            Console.WriteLine($"{obj} nesnesi sürülüyor..");
        }

        public void VitesDegistir(object obj)
        {
            Console.WriteLine($"{obj} nesnesi vitesi değiştirdi.");
        }

        public void Parket(object obj)
        {
            Console.WriteLine($"{obj} nesnesi parketti.");
        }

 
    }
}
