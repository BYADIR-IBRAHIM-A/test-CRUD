using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using FlowerShop.Models; // عشان يتعرف على NoTestWordAttribute

namespace FlowerShop.Models
{
    public class Plant
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "اسم النبتة مطلوب.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "أن يكون بين 2 و 100 حرف.")]
        [NoTestWord] // <<< هنا التحقق المخصص الجديد
        public string Name { get; set; }


        [Required(ErrorMessage = "الوصف مطلوب.")]
        [StringLength(500, ErrorMessage = "الوصف لا يمكن أن يتجاوز 500 حرف.")]
        public string Description { get; set; }

        [Precision(10, 2)]
        [Required(ErrorMessage = "السعر مطلوب.")]
        [Range(1, 10000, ErrorMessage = "السعر يجب أن يكون بين 1 و 10000.")]
        [PriceMinimum(5)] // ✅ تحقق مخصص إضافي على السعر
        public decimal Price { get; set; }


        [Required(ErrorMessage = "الكمية مطلوبة.")]
        [Range(1, 100, ErrorMessage = "❌ الكمية يجب أن تكون بين 1 و 100.")]
        [StockLimit] // ✅ تحقق إضافي لضمان عدم تجاوز 100
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
