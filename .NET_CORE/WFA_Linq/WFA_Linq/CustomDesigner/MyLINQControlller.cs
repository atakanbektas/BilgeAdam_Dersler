using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Linq.CustomDesigner
{
    public static class MyLINQControlller
    {
        public static bool CiftSayiMi(int sayi)
        {
            return sayi % 2 == 0;
        }
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> obj, Func<T, bool> predict)
        {
            List<T> filtrelenenVeriler = new List<T>();

            foreach (var item in obj)
            {
                if (predict.Invoke(item))
                {
                    filtrelenenVeriler.Add(item);
                    IEnumerable<int> deneme2 = new List<int>();
                }               
            }

            return filtrelenenVeriler;
        }
        public static void Cagir()
        {
            List<int> sayilar = new List<int> { 10, 22, 13, 44, 75 };

            
            sayilar.MyWhere(CiftSayiMi);
        }

        public static void Sil<T, R>(this ICollection<T> collection, Func<T, R> predict) 
        {
            ICollection<T> silinecekDatalar = new List<T>();
            foreach (var item in collection)
            {
                if(typeof(R) == typeof(bool))
                {
                    if (Convert.ToBoolean(predict(item)))
                    {
                        silinecekDatalar.Add(item);
                    }
                }
            }
            foreach (var item in silinecekDatalar)
            {
                collection.Remove(item);
            }
        }
    }
}
