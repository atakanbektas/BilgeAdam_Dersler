using System;
using System.Collections.Generic;

namespace WritersBooks_EF_UI.Models
{
    public partial class Book
    {
        public Book()
        {
            Writers = new HashSet<Writer>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Writer> Writers { get; set; }

  
    }
}
