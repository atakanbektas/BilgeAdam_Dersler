using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Hoşgeldiniz. Bu program iki sayının çarpımını hesaplamaktadır.\n");
            WantNums();
        }
        private static void WantNums()
        {
            Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            int num2 = int.Parse(Console.ReadLine());
            MultiplyNums(num1,num2);
        } 
        private static void MultiplyNums(int num1,int num2)
        {
            ShowResult(num1 * num2);
        }
        private static void ShowResult(int sum)
        {
            Console.WriteLine($"İşleminizin sonucu = {sum}");
              isAgain();
        }
        private static void isAgain()
        {
            Console.WriteLine("Tekrar İslem Yapmak İster misiniz ? EVET/HAYIR");
            string answerOfUser = Console.ReadLine().ToUpper();
            if (answerOfUser=="EVET")
            {
                WantNums();
            }
            else
            {
                FinishMessage();
            }
        }
        private static void FinishMessage()
        {
            Console.WriteLine("Bir hatamız olmamıştır diye umuyoruz, gene bekleriz!");            
            Console.ReadLine();
        }

        
    }
}
