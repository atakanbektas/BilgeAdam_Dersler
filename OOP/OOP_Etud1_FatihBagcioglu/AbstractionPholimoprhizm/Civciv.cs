using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPholimoprhizm
{
    internal class Civciv : Hayvan
    {
        public Civciv()
        {
            Console.WriteLine("Civciv doğdu.");
        }
        public override void SesCikar()
        {
            Console.WriteLine("Cik Cik");
        }

        protected override void TehlikeliMetot()
        {
            throw new NotImplementedException();
        }
    }
}
