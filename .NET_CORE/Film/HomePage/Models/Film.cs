using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string? FilmName { get; set; }
        public int? Duration { get; set; }
        public int? Rating { get; set; }        
        public virtual ICollection<Kind>? Kinds { get; set; } = new List<Kind>();

        
    }
}
