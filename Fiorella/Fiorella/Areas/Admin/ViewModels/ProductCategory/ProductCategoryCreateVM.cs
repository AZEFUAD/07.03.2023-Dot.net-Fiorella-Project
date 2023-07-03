using System.ComponentModel.DataAnnotations;

namespace Fiorella.Areas.Admin.ViewModels.ProductCategory
{
    public class ProductCategoryCreateVM
    {
        [Required(ErrorMessage = "Ad mütləq daxil edilməlidir")]
        [MinLength(3, ErrorMessage = "Minimum uzunluq 3 simvol olmalıdır")]
        [MaxLength(20, ErrorMessage = "Maksimum uzunluq 20 simvol olmalıdır")]
        [Display(Name="Title")]
        public string Name { get; set; }
    }
}
