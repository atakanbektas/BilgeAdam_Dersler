using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkiSayiBölümException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            

            try
            {
                Console.WriteLine("Lütfen iki sayı giriniz!");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                sonuc = a / b;
                Console.WriteLine(sonuc);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Bu program illaki çalışacak!");
            }
            Console.ReadLine();
        }
    }
}
