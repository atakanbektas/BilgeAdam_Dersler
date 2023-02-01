using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiSayininKareleriToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen iki adet sayı giriniz." + Environment.NewLine);
            int i =Convert.ToInt32( Console.ReadLine());
            int k =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine(i*i+k*k);
            Console.WriteLine(Math.Pow(i,2)+Math.Pow(k,2) + Environment.NewLine);

            Console.WriteLine("Kullanıcıdan sayı almadan yadırma" + Environment.NewLine);
            

            Console.WriteLine((3*3) + (5*5));
            Console.WriteLine(Math.Pow(3,2)+Math.Pow(5,2));
            Console.WriteLine((3+5)*(3+5)-(2*3*5));

            Console.ReadKey();

        }
    }
}
