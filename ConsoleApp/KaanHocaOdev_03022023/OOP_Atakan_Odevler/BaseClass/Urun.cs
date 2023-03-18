using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    internal class Urun : BaseClass
    {
        private string _marka { get; set; }
        private string _model { get; set; }

        private decimal _alisFiyati;
        public decimal AlisFiyati
        {
            get { return _alisFiyati; }
            set { _alisFiyati = value < 0 ? 0 : value; }
        }


        private decimal _satisFiyati;
        public decimal SatisFiyati
        {
            get { return _satisFiyati; }
            set { _satisFiyati = value < _alisFiyati ? _alisFiyati : value; }
        }

        private decimal _kampanyaFiyati;
        public decimal KampanyaFiyati
        {
            get { return _kampanyaFiyati; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0'dan küçük olamaz!");
                    _kampanyaFiyati = _satisFiyati - 1;

                }
                else if (value >= _satisFiyati)
                {
                    Console.WriteLine("Kampanya fiyatı satış fiyatına eşit veya fazla olamaz!");
                    _kampanyaFiyati = _satisFiyati - 1;
                }
                else
                {
                    _kampanyaFiyati = value;
                }
            }
        }

        public void BilgileriIste()
        {
            Console.Write("Marka Giriniz.. ");
            _marka = Console.ReadLine();
            Console.Write("Model Giriniz.. ");
            _model = Console.ReadLine();
            Console.Write("Alis Fiyati Giriniz.. ");
            AlisFiyati = decimal.Parse(Console.ReadLine());
            Console.Write("Satis Fiyatı Giriniz.. ");
            SatisFiyati = decimal.Parse(Console.ReadLine());
            Console.Write("Kampanya Fiyatı Giriniz.. ");
            KampanyaFiyati = decimal.Parse(Console.ReadLine());
            Console.Write("Güncelleme tarihi Giriniz.. ");
            GuncellemeTarihi = DateTime.Parse(Console.ReadLine());
            Console.Write("Barkod Giriniz.. ");
            Barkod = long.Parse(Console.ReadLine());
        }
        public void BilgileriYazdir()
        {
            Console.WriteLine($"{id} NUMARALI ARAÇ ÖZELLİKLERİ");
            Console.WriteLine($"Marka = {_marka}");
            Console.WriteLine($"Model = {_model}");
            Console.WriteLine($"Alış Fiyatı = {_alisFiyati}");
            Console.WriteLine($"Satış Fiyatı = {_satisFiyati}");
            Console.WriteLine($"Kampanya Fiyatı = {_kampanyaFiyati}");
            Console.WriteLine($"Güncelleme Tarihi = {GuncellemeTarihi}");
            Console.WriteLine($"Barkod No = {Barkod}");
            Console.WriteLine($"Oluşturulma Tarihi = {OlusturulmaTarihi.ToShortDateString()}");
        }
        public Urun()
        {
            OlusturulmaTarihi = DateTime.Now;
        }

    }
}
