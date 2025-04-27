using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Models
{
    public class StockLimitAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is int quantity)
            {
                if (quantity > 100)
                {
                    return new ValidationResult("❌ لا يمكن أن تتجاوز الكمية 100.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
