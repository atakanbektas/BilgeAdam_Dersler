namespace Ank_Boost_12_Mvc.Models
{
    public class Araba
    {
        public string Marka { get; set; }
        public int Model { get; set; }

        public Araba(string marka, int model)
        {
            Model = model;
            Marka = marka;
        }
    }
}
