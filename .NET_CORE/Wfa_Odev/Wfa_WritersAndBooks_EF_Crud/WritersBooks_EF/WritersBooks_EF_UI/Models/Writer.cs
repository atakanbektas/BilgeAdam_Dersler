using System;
using System.Collections.Generic;

namespace WritersBooks_EF_UI.Models
{
    public partial class Writer
    {
        public Writer()
        {
            Books = new HashSet<Book>();
        }

        public int WriterId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int? Age { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return $"ID: {WriterId}\n AD SOYAD: {FirstName} {LastName}";
        }
    }
}
