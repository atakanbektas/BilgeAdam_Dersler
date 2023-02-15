using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFirin
{
    internal class Firin
    {

        //MarkaFiyatGüçModelGarantiSüresiGarantiVarmıMaxDerecesi
        public string Marka { get; set; }
        public decimal Fiyat { get; set; }
        public string Guc { get; set; }
        public string Model { get; set; }        
        public bool GarantiVarMi { get; set; }
        public int MaxDerecesi { get; set; }

        private int garantiSuresi;

        public int GarantiSuresi
        {
            get { return garantiSuresi; }
            set { garantiSuresi = value; }
        }


        public int GarantiUzat(string nesne)
        {
            
            Console.WriteLine(nesne + "'in " + "Uzatılacak Yılını Giriniz.");
            int uzatilacakYil = int.Parse(Console.ReadLine());
            Console.WriteLine($"{nesne}'in garanti süresi {uzatilacakYil} yıl uzatıldı.");
            return garantiSuresi+=uzatilacakYil;
        }









        public Firin()
        {
            Console.WriteLine("Fırın Oluşturuldu.");
        }
    }
}
