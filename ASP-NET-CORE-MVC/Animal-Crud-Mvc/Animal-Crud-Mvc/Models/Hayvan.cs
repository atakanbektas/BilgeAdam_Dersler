using System.ComponentModel.DataAnnotations;

namespace Animal_Crud_Mvc.Models
{
    public class Hayvan
    {
        public Hayvan(string ad)
        {
            Ad = ad;
        }
        public int Id { get; set; }

        #region AdAttribute
        [Required]
        [MaxLength(50, ErrorMessage = "En fazla 50 karakter girmelisiniz!")]
        [MinLength(2, ErrorMessage = "En az 2 karakter girmelisiniz!")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Ad sadece harf ve boşluk karakterleri içerebilir.")]
        #endregion
        public string Ad { get; set; }

        #region ResimYoluAttribute
        [RegularExpression(@"(.*\.png$|.*\.jpg$)", ErrorMessage = "Resim yolu sadece png veya jpg formatında olabilir.")]
        #endregion
        public string? ResimYolu { get; set; }

        #region AciklamaAttribute
        [StringLength(1000, ErrorMessage = "Açıklama 1000 karakterden fazla olamaz!")]
        #endregion
        public string? Aciklama { get; set; }


    }
}
