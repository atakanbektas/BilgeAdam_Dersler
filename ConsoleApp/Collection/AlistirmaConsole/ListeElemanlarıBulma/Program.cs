using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeElemanlarıBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> metinler = new List<string>() {"ali","can","cem"};
            
            metinler.Add("ece"); //2.soru

            metinler.Insert(0, "oya"); //3.Soru

            int canIndexNo = metinler.IndexOf("can"); //4. soru

            metinler.RemoveAt(canIndexNo); //5.Soru

            metinler.Remove("cem"); // 6.Soru

            foreach (string isim in metinler)
            {
                Console.Write(isim+" ");       //7.Soru
            }
            string[] metinler2 = { "alf", "ela", "ahu", "eda", "han" }; //8.soru

            metinler.AddRange(metinler2);  //9.soru

          

            Console.WriteLine();
            foreach (string isim in metinler)
            {
                Console.Write(isim+" ");     //10.soru
            }

            Console.WriteLine();
            for (int i = 0; i < metinler.Count; i++)
            {
                Console.Write(metinler[i]+" ");    //11.soru
            }
            Console.WriteLine("\n\n\n");


            Console.WriteLine($"İlk count: {metinler.Count}");
            Console.WriteLine($"İlk kapasite: {metinler.Capacity}");          
            

            for (int j = 0; j < 8; j++)
            {
                metinler.Add(null);       //12. Soru
            }
            Console.WriteLine($"Son count: {metinler.Count}");
            Console.WriteLine($"Son kapasite: {metinler.Capacity}");



            Console.Read();




        }
    }
}
