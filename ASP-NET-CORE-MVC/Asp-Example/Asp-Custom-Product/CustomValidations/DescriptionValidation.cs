using System.ComponentModel.DataAnnotations;

namespace Asp_Custom_Product.CustomValidations
{
    public class DescriptionValidation : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string text = value.ToString();
            int textLength = text.Length;
            if (textLength > 10 && textLength < 150)
            {
                return ValidationResult.Success;
            }
            else if (textLength <= 10)
            {
                return new ValidationResult("Description can not be less than 10 char");
            }
            else
            {
                return new ValidationResult("Description can not be greater than 150 char");
            }
        }

    }
}
