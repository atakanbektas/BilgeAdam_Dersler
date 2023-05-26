using ETicaretApp.Domain.Entities.General;
using Microsoft.EntityFrameworkCore;

namespace ETicaretApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int StockQuantity { get; set; }
        public int? CategoryId { get; set; }

        [Precision(18, 5)]
        public decimal? UnitPrice { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual Category? Category { get; set; }
    }
}
