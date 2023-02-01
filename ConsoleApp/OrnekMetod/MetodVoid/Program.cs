using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*[14:23] Fatih Bağcıoğlu (BilgeAdam Boost)
2.SORU 1'den başlayan ve dışarıdan gönderilen değere kadar ekrana yazdıran metodu çağıran program.(void)
*/
            int x = int.Parse(Console.ReadLine());
            Yazdir(x);
            Console.ReadLine();
        }       

        private static void Yazdir(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Console.Write(string.Format("{0,3} ", i));
                System.Threading.Thread.Sleep(50);
            }
        }

        
    }
}
