using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tekrar:

            Console.WriteLine("Kullanıcı Adı giriniz!");
            Parola parola = new Parola(Console.ReadLine());

            goto Tekrar;
        }
    }
}
