using Araclar.IOzellikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araclar.Models
{
    internal class Motorsiklet : Araclar, ISurus, IMotor
    {
        public Motorsiklet()
        {

        }
        public string MotorTipi { get; set; }
        public override int Hiz { get; set; }
        public override string YakitTuru { get; set; }

        public void Parket()
        {

        }

        public void Sur()
        {

        }
    }
}
