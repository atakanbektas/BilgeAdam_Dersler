using ETicaretApp.Domain.Entities.General;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaretApp.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Customer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;

        [NotMapped]
        public string FullName { get { return Name + " " + Surname; } }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
