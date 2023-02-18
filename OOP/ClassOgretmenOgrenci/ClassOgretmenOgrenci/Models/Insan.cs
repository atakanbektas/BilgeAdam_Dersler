using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOgretmenOgrenci.Models
{
    internal class Insan
    {
        public Ogrenci ogrenci { get; set; }
        public Ogretmen ogretmen { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

     
        void SetOgrenciYas()
        {
           
        }
      
    }
}
