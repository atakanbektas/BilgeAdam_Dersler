using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPholimoprhizm
{

    // abstract class dediğimiz yapılar BaseClass olarak nitelendirilir ve diğer sınıflara temel yapıda hizmetleri sunması açısından oluşturulur.
    // bir abstarct class kalıtım verdiği class'larda abstract metotların implemente edilmesini zorunlu kılar. 
    // virtual metodun implemente zorunluluğu yoktur.
    // abstarct bir metod protected,public, internal alabilir(private alamaz.)
    // bir abstract metodun oluşturulma niyeti zaten en bşaında dışarı açılma eğilimidir.
    // protected için miras alınacak sınıflarda kullanıma açıyoruz.
    // Abstract bir metot protected olarak sağlanabilir yalnız, ileride bir yazılımcı bu access modifier ı göz önünde bulundurup kullanılmasını tehlikeli görebilir. (Ulaşım class)...(yol class)...(araba,otobüs classımız olabilir) daha yol class'ı oluşturulmadığı için bu metodu öngören yazılımcı protected'ı almış olabilir)

    abstract class Hayvan
    {
        public string Ad { get; set; }
        public string Yas { get; set; }
        public int BacakSayisi { get; set; }
        public  bool UcuyorMu { get; set; }        
        public HareketDurumu HareketDurum { get; set; }

        protected abstract void TehlikeliMetot(); // bu metoda Main'den ulaşamazsın(protected)..

        public abstract void SesCikar();
        public virtual void Olusturuldu()
        {
            Console.WriteLine("Hayvan sınıfı oluşturuldu.");
        }
    }
}
