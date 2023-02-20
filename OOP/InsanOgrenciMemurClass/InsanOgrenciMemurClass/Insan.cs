using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanOgrenciMemurClass
{
    public class Insan
    {
        //Adi, Doğum Tarihi, Soyadi, TcNo olacak
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi  { get; set; }
        public long tcKimlikNo { get; set; }

        public virtual void BilgileriGoster()
        {
            Console.WriteLine("Bu bir insandır!");
            Console.WriteLine($"Adı = {Adi}");
            Console.WriteLine($"Soyadı = {Soyadi}");
            Console.WriteLine($"Dogum Tarihi = {DogumTarihi.ToShortDateString()}");
            Console.WriteLine($"T.C = {tcKimlikNo}");
        }
        public virtual void BilgileriAl()
        {
            Console.WriteLine("Ad giriniz");
            Adi = Console.ReadLine();
            Console.WriteLine("Soyad giriniz");
            Soyadi = Console.ReadLine();
            Console.WriteLine("TC giriniz");
            tcKimlikNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Dogum Tarihi giriniz");
            DogumTarihi = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
