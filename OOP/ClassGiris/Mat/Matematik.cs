using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mat
{
    // statik class'da Constructor Metod oluşturamazsın. Çünkü static sınıf dediğimiz zaman aslında program çalışır çalışmaz bu sınıfın oluşturulduğu anlamına gelir ve New keywordü ile nesne oluşturamazsın. Math sınıfı en belirgin örneğidir. Kullanıcının değişkeni değiştiremeyeceğini istediğimiz durumlarda const anahtar kelimesini kullanırız.
    public static class Matematik
    {
        private const double PI = 3.14;
        public static int KullaniciPI { get; set; }

        /// <summary>
        ///  İki integer değerini kıyaslamaktadır. 
        /// </summary>
        /// <param name ="sayi1"> ilk sayıyı int tipinde göndermelisiniz. </param>
        /// <param name ="sayi2"> ilk sayı ile kıyaslayacağınız sayıyı int tipinde göndermelisiniz. </param>      
        /// <returns> Büyük olanı int olarak return eder. </returns>
        public static int Buyuk(int sayi1, int sayi2)
        {
            return (sayi1 > sayi2 ? sayi2 : sayi1);
        }


        /// <summary>
        ///  Bu metod gönderdiğiniz üç integer tipinden en büyük olanı return etmektedir. 
        /// </summary>
        /// <param name="sayi1"> int tipinde 1. sayıyı girmelisin.  </param>
        /// <param name="sayi2"> int tipinde 2. sayıyı girmelisin.  </param>      
        /// <param name="sayi3"> int tipinde 3. sayıyı girmelisin. </param>      
        /// <returns> En büyük sayı </returns>
        public static int Buyuk(int sayi1, int sayi2, int sayi3)
        {
            return ((sayi1 >= sayi2 && sayi1 >= sayi3) ? sayi1 : ((sayi2 > sayi3) ? sayi2 : sayi3));
        }

        
        //public int Gel(int sayi1, int sayi2)
        //{
        //    return 0;
        //}




    }
}
