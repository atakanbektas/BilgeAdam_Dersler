using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTurClass
{
    public abstract class Tur
    {
        public string CanliTuru { get; set; }
        public string Familya { get; set; }
        public string Aile { get; set; }
        
        virtual public void TurGoster()
        {
            Console.WriteLine("Bu bir türdür.");
        }
        public  void AileGoster()
        {
            Console.WriteLine($"Ailesi = {Aile}");
        }
        abstract public void FamilyaGoster();
      

    }
}
