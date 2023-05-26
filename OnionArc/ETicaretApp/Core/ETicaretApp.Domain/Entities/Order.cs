using ETicaretApp.Domain.Entities.General;

namespace ETicaretApp.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public int CustomerId { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual Customer Customer { get; set; } = null!;

    }
}
