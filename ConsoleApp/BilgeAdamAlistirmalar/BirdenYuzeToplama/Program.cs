using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdenYuzeToplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            int i = 1;
            while (i!=100)  sonuc += i++;            
            Console.WriteLine($"1-100 Arası sayılar toplamı ={sonuc}");
            Console.ReadLine();
        }
    }
}
