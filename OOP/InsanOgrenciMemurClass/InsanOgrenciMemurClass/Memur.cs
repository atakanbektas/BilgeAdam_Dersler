using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanOgrenciMemurClass
{
    internal class Memur : Insan
    {
        public string BirimAdi { get; set; }
        public void SicilNo()
        {

        }
        public override void BilgileriGoster()
        {
            Console.WriteLine("Bu bir memurdur.");
            Console.WriteLine($"Adı = {Adi}");
            Console.WriteLine($"Soyadı = {Soyadi}");
            Console.WriteLine($"T.C = {tcKimlikNo}");
            Console.WriteLine($"Dogum Tarihi = {DogumTarihi}");
            Console.WriteLine($"BirimAdi = {BirimAdi}");
        }
        public override void BilgileriAl()
        {
            base.BilgileriAl();
            Console.WriteLine("Birim Adı Giriniz");
            BirimAdi = Console.ReadLine();
        }
    }
}
