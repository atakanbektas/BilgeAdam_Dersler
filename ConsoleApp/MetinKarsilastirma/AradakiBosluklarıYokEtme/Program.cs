using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AradakiBosluklarıYokEtme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string sifre = "";
            string ayraclar1 = "*_-!'^+%&/()=?";
            char[] ayraclar2 = ayraclar1.ToCharArray();
            

            Console.WriteLine("ID giriniz!");
            string ID = Console.ReadLine().Trim(ayraclar2);
            Console.WriteLine("Sifre giriniz!");

            for (int i = 0; i < ayraclar1.Length; i++)
            {
              
            }
           

            Console.WriteLine($"Kullanıcı adı = {ID}\nSifre = {sifre}");
            Console.ReadKey();

        }
    }
}
