using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanici
{
    internal class Parola
    {
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get
            {
                return _kullaniciAdi;
            }
            set
            {
                _kullaniciAdi = value;
            }
        }
        public Parola(string admin)
        {
            if (admin.ToLower()=="admin")
            {
                Console.WriteLine("Hoşgeldin admin.");
            }
            else
            {
                Console.WriteLine("Admin kullanıcı değilsiniz.");
            }
        }
    }
}