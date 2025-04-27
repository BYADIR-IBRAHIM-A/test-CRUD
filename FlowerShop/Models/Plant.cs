using System.ComponentModel.DataAnnotations;

namespace FlowerShop.Models
{
    public class Plant
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "اسم النبتة مطلوب.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "اسم النبتة يجب أن يكون بين 2 و 100 حرف.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "الوصف مطلوب.")]
        [StringLength(500, ErrorMessage = "الوصف لا يمكن أن يتجاوز 500 حرف.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "السعر مطلوب.")]
        [Range(1, 10000, ErrorMessage = "السعر يجب أن يكون بين 1 و 10000.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "الكمية مطلوبة.")]
        [Range(0, 1000, ErrorMessage = "الكمية يجب أن تكون بين 0 و 1000.")]
        public int StockQuantity { get; set; }

        [Required(ErrorMessage = "حدد نوع النبات.")]
        [Display(Name = "نوع النبات")]
        public PlantType Type { get; set; }
    }

    public enum PlantType
    {
        داخلي,
        خارجي
    }
}
