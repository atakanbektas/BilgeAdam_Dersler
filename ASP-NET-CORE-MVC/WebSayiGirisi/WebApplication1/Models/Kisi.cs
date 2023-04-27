using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Kisi
    {
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [MinLength(10, ErrorMessage = "Test")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string TcKimlikNo { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]

        public int KodNo { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Sifre { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string SifreTekrar { get; set; }

    }
}
