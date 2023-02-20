using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanOgrenciMemurClass
{
    internal class Akademisyen : Memur
    {
        public string Mail { get; set; }
        public string Program { get; set; }

        public override void BilgileriGoster()
        {
            Console.WriteLine("Bu bir akademisyendir.");

            Console.WriteLine($"Adı = {Adi}");
            Console.WriteLine($"Soyadı = {Soyadi}");
            Console.WriteLine($"T.C = {tcKimlikNo}");
            Console.WriteLine($"Dogum Tarihi = {DogumTarihi}");
            Console.WriteLine($"BirimAdi = {BirimAdi}");
            Console.WriteLine($"Program  =  {Program}");
            Console.WriteLine($"Mail Adresi =  {Mail}");
        }
        public override void BilgileriAl()
        {
            base.BilgileriAl();
            Console.WriteLine("Mail Adresi giriniz");
            Mail = Console.ReadLine();
            Console.WriteLine("Program giriniz");
            Program = Console.ReadLine();
        }
    }
}
