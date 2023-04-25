using Asp_Custom_Product.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace Asp_Custom_Product.Models
{
    public class Product
    {
        public Product()
        {

        }
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name can not be null")]
        [StringLength(50, ErrorMessage = "Name can not be greater than or equal to 50 words")]
        public string Name { get; set; }

        [Range(0, 10000000)]
        public decimal Price { get; set; }

        [DescriptionValidation]
        public string Description { get; set; }
        public Category? Category { get; set; }
    }
    public enum Category
    {
        Phone = 1,
        Computer,
        Tablet
    }
}
