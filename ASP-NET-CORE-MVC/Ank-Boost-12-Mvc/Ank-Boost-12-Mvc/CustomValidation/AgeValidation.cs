using System.ComponentModel.DataAnnotations;

namespace Ank_Boost_12_Mvc.CustomValidation
{
    public class AgeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if ((int)value > 19 && (int)value < 42)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Yaş 19-42 arası olabilir.");
            }
        }
    }
}
