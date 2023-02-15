using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMutevaziDegilim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atakan atakan = new Atakan();



            atakan.AdSoyad = "Atakan Bektaş";
            atakan.BildigiProglamlamaDilleri = "C#";
            atakan.DogumTarihi = Convert.ToDateTime("22.02.1995");
            atakan.CalabildigiEnstrumanlar = "Gitar,Yan Flüt";
            atakan.Hobi = "Tiyatro";
            atakan.Hobi = "Müzik";
            atakan.Hobi = "Yüzme";
            atakan.Hobi = "Aykut beyle sohbet";

            atakan.Meslegi = "Çok yıldız yazılımcı";
            atakan.Yas = 27;


            Console.WriteLine("Bilgiler yükleniyor.");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine($"Adı Soyadı = {atakan.AdSoyad}\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"Dogum Tarihi = {atakan.DogumTarihi.ToString("dd MMMM yyyy")}\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"Yaşı = {atakan.Yas}\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"Meslegi = {atakan.Meslegi}\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"Bildigi Proglamlama Dilleri = {atakan.BildigiProglamlamaDilleri}\n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"Calabildigi Enstrumanlar = {atakan.CalabildigiEnstrumanlar}\n");

            foreach (var item in Atakan.Hobileri)
            {
                Console.WriteLine($"Hobileri = {item}");
            }

            Console.ReadLine();

        }
    }
}
