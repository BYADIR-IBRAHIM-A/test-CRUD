using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Models
{
    public class PriceMinimumAttribute : ValidationAttribute
    {
        private readonly double _minimumPrice;

        public PriceMinimumAttribute(double minimumPrice)
        {
            _minimumPrice = minimumPrice;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is decimal price)
            {
                if ((double)price < _minimumPrice)
                {
                    return new ValidationResult($"❌ السعر يجب ألا يقل عن {_minimumPrice} ريال.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
