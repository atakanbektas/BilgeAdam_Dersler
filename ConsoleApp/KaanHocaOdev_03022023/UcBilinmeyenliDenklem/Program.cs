using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcBilinmeyenliDenklem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen çevre giriniz!");
            int cevre = int.Parse(Console.ReadLine());
            int yariCevre = cevre >> 1;


            List<int> kenarlar = DikUcgenDegerleriBul(yariCevre);
            Console.WriteLine($"Kenar 1 = {kenarlar[0]}");
            Console.WriteLine($"Kenar 2 = {kenarlar[1]}");
            Console.WriteLine($"Kenar 3 = {kenarlar[2]}");
            Console.ReadLine();
        }

        private static List<int> DikUcgenDegerleriBul(int yariCevre)
        {
            List<int> kenarlar = new List<int>();

            for (int a = 1; a < yariCevre; a++)
            {
                for (int b = a + 1; b <= yariCevre; b++)
                {
                    int c = (yariCevre * 2) - a - b;
                    if (c > b)
                    {
                        double ucgenAlan1 = (a * b) / 2;
                        double ucgenAlan2 = Math.Sqrt(yariCevre*((yariCevre - a) * (yariCevre - b) * (yariCevre - c)));

                        if (ucgenAlan1 == ucgenAlan2)
                        {
                            kenarlar.Add(a);
                            kenarlar.Add(b);
                            kenarlar.Add(c);
                            return kenarlar;
                        }
                    }
                    else
                    {
                        b = yariCevre;
                    }
                }
            }
            return kenarlar;
        }
    }
}
