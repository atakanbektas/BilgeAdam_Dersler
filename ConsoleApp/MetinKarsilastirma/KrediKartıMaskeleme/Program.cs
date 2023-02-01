using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediKartıMaskeleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lütfen kredi kartı son 4 no giriniz.");
            string krediKartıNo = Console.ReadLine();
            Console.WriteLine(krediKartıNo.PadLeft(16,'*'));

           
            Console.ReadLine();
            
        }
    }
}
