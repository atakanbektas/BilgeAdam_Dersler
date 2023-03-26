using System;
using System.Collections.Generic;

namespace Wfa_KisiRehberi_DbFirst_EF.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
