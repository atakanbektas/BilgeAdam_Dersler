using System;
using System.Collections.Generic;

namespace WFA_Nortwind.UI.Models
{
    public partial class KritikSeviyeUrunBilgileri
    {
        public string ProductName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public short? SiparisVerilmesiGerekenMiktarMinimum { get; set; }
    }
}
