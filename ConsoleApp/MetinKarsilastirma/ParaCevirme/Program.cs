using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaCevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para miktarı giriniz");
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            double para = double.Parse(Console.ReadLine());
            Console.WriteLine(para.ToString("C2", CultureInfo.CurrentCulture));
            Console.ReadLine();
            
        }
    }
}
