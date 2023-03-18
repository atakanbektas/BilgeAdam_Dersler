using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Canli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Erkek aykut = new Erkek(12354);
            aykut.DogumYili = 1989;
            aykut.TcNo = 12345;
            Console.WriteLine(aykut.DogumYili);
            Console.WriteLine(aykut.TcNo);
            aykut.TcNo = 123456789;
          
            Console.WriteLine(aykut.TcNo);

            Mat.Matematik
            Console.ReadLine();
        }
    }
}
