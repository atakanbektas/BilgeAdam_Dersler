using System.ComponentModel.DataAnnotations;

namespace HomePage.Models
{
    public class FilmKind
    {
        public Film Film { get; set; }
        public Kind Kind{ get; set; }      
        public int FilmId { get; set; }      
        public int KindId { get; set; }
    }
}