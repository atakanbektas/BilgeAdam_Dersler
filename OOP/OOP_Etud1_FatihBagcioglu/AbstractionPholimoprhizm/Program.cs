using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPholimoprhizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kedi kedi = new Kedi();
            //kedi.Olusturuldu();
            //kedi.TehlikeliMetoduAc();

            Kopek kopek = new Kopek();
            kopek.Ad = "Reis";
            kopek.BacakSayisi = 4;
            kopek.Yas = "13";
            kopek.HareketDurum = 0;

            Console.WriteLine($"{kopek.Ad} adlı köpek {kopek.BacakSayisi} bacaklı ve {kopek.HareketDurum}");
            kopek.Olusturuldu();
            kopek.SesCikar();
            Console.Read();
        }
    }
}
