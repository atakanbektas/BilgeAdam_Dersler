using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMutevaziDegilim
{
    public class Atakan
    {

        public static List<string> Hobileri = new List<string>(); 
        public string AdSoyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string BildigiProglamlamaDilleri { get; set; }
        // public string Hobi { get; set; }
        private string myVar;

        public string Hobi
        {
            get { return myVar; }
            set 
            {
                Hobileri.Add(value);
                myVar = value; 
            }
        }

        public string EhliyetDurumu { get; set; }
        public string CalabildigiEnstrumanlar { get; set; }
        public string Meslegi { get; set; }
        public int Yas { get; set; }

        public Atakan()
        {
            Console.WriteLine("Ben bugün OOP'ye başladım.\n");
        }



        public void Topla()
        {

        }

    }
}
