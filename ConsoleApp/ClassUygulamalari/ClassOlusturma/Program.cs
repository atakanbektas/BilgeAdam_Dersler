using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Kebapci kebapci = new Kebapci();
            kebapci.IsimIste();

            Ayrac();
            Müsteri müsteri = new Müsteri();
            müsteri.IsimIste();

            Ayrac();
            Donerci donerci = new Donerci();

            donerci.Yazdir();
            kebapci.Yazdir();
            müsteri.Yazdir();
            
            

            Console.Read();

        }

        private static void Ayrac()
        {
            Console.WriteLine("\n"+new string('-',70)+"\n");
        }
    }
}
