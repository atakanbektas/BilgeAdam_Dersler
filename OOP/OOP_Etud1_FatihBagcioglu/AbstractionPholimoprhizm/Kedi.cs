using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPholimoprhizm
{
    internal class Kedi : Hayvan
    {
        public Kedi()
        {
            Console.WriteLine("Kedi Doğdu");
        }
        public override void SesCikar()
        {
            Console.WriteLine("Miyavvvv");
        }
        public override void Olusturuldu()
        {
            Console.WriteLine("Kedi sınıfından türeyen metodum.");
        }

        protected override void TehlikeliMetot()
        {
            Console.WriteLine("Tehlikeli metod açıldı.");
        }
        public void TehlikeliMetoduAc()
        {
            TehlikeliMetot();
        }

        // Dede, Baba, Çocuk tane classım var , en gelişmiş class Çocuktur..
        // Liskov prensibi = Solid(L) Temel bir sınıfın alabileceği özelliklerinin hepsinin karşılayabiliyor ve kendi içerisinde çeşitli operasyonlar yürütebiliyor olan temel sınıftan türetilmiş sınıfların olması gerekiyor.

    }
}
