using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atakan_Odevler
{
    public class Departman
    {
        public int DepartmanNo { get; set; }
        public string DepartmanAdi { get; set; }

        enum Bolum
        {
            Uretim,
            Pazarlama,
            Finans,
            a,
            b,
           
        }

        public string DepartmanAdiSoyle(int departmanNo)
        {
            DepartmanNo = departmanNo;
            DepartmanAdi = Enum.ToObject(typeof(Bolum), departmanNo).ToString();
            return DepartmanAdi;
        }

        public int DepartmanNoSoyle(int index)
        {
            DepartmanNo = index;

            return DepartmanNo;
        }

       




    }
}
