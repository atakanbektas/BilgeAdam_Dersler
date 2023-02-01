using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adminSifreBelirleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            string sifre = "1234";
            string id = "admin";
        
            Console.WriteLine("ID giriniz.");
            string idGirilen = Console.ReadLine();
            
            while(idGirilen.ToLower()!=id)
            {
                Console.WriteLine("Kullanıcı adınız hatalıdır. Lütfen kullanıcı adı giriniz.");
                idGirilen = Console.ReadLine();
            }

            a: 
            Console.WriteLine(" Sifre giriniz.");
            string sifreGirilen =Console.ReadLine();
            

            if (sifreGirilen==sifre)
            {
            
                Console.WriteLine(" Giriş yapıldı.");
                
            }
            
            else
            {
                Console.Write("Bilgiler hatalı tekrar deneyiniz. ");
                 
                goto a;
            }
             
            Console.ReadKey();
        }

        static string Main2(string[] yazilar)
        {
           b:  
            return "naber";
        }
    }
}
