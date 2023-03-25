using System;
using System.Collections.Generic;

namespace WFA_Nortwind.UI.Models
{
    public partial class CondimentsCategory
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
