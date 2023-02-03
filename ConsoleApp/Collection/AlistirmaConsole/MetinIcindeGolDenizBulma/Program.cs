using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinIcindeGolDenizBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //göl olan şehirler akdenizin alt kümesi mi?deniz olan şehirler göl olan şehirlerin üst kümesi mi?deniz olan şehirler hemdenizhemgöl olan şehirlerin alt kümesi mi? 

            HashSet<string> deniz = new HashSet<string>() { "Antalya", "Isparta", "Mersin", "Hatay", "Burdur", "Kahramanmaraş", "Osmaniye", "Adana" };

            HashSet<string> göl = new HashSet<string>() { "Antalya", "Isparta", "Burdur" };

            HashSet<string> ikiside = new HashSet<string>() { "Mersin", "Antalya", "Muğla", "Trabzon", "Hatay", "İstanbul", "Bursa", "Tekirdağ", "İzmir", "Aydın", "Rize", "Adana","Isparta" };

           
            Console.WriteLine(göl.IsSubsetOf(deniz));
            Console.WriteLine(deniz.IsSupersetOf(göl));
            Console.WriteLine(deniz.IsSubsetOf(ikiside));

            


            Console.ReadLine();
        }
    }
}
