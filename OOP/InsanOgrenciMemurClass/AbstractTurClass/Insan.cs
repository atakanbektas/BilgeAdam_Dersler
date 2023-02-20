using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTurClass
{
    public class Insan : Tur
    {
        public override void FamilyaGoster()
        {
            Console.WriteLine($"Familyası : {Familya}");
        }
    
        public override void TurGoster()
        {           
            Console.WriteLine($"Türü : {CanliTuru}");         

        }
    }
}
