using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Models
{
    public class NoTestWordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var name = value as string;
            if (!string.IsNullOrEmpty(name) && name.ToLower().Contains("test"))
            {
                return new ValidationResult("لا يمكن أن يحتوي اسم النبتة على الكلمة 'test'.");
            }
            return ValidationResult.Success;
        }
    }
}
