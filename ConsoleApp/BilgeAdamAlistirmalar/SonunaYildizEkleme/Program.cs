using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SonunaYildizEkleme
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                for (int i = 0; i < 1000; i += 2)
                {
                    for (int k = 0; k <= i / 2; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    string mesaj = "İyi ki doğdun Mehtap";
                    mesaj = mesaj.PadRight(46, '*');
                    Console.WriteLine(mesaj);
                    for (int j = i / 2; j >= 0; j--)
                    {
                        Console.Write("*");
                    }

                    Thread.Sleep(500);
                    Console.WriteLine();
                } 
            }

            Console.ReadLine();

        }
    }
}
