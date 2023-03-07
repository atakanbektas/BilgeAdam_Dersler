using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPholimoprhizm
{
    internal class Kopek : Hayvan
    {
        public Kopek()
        {
            Console.WriteLine("Köpek doğdu.");
        }
        public bool EvcilMi { get; set; }
        public string Cinsiyet { get; set; }

        public override void SesCikar()
        {
            Console.WriteLine("Havhav");
        }
        public override void Olusturuldu()
        {
            Console.WriteLine("Köpek Sınıfından Türetildim.");
        }

        protected override void TehlikeliMetot()
        {
            throw new NotImplementedException();
        }
    }
}
