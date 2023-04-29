using System.ComponentModel.DataAnnotations;

namespace EFProductCrud.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [RegularExpressionAttribute("^[a-zA-Z]*$", ErrorMessage = "Sadece harf içerebilir")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter girebilirsiniz")]
        [MinLength(3, ErrorMessage = "En az 3 karakter girebilirsiniz")]
        public string Name { get; set; }

        [Range(1, 150, ErrorMessage = "Ürün fiyatı 0$-150$ arası olmalıdır.")]
        public decimal Price { get; set; }
        public bool isExist { get; set; }
    }
}
