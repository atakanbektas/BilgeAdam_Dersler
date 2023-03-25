using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WFA_MostPopularCities.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Product>? Products { get; } = new List<Product>();
        public override string ToString()
        {
            return $"{Name}";
        }     

    }
}
