using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFormMvcApp.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Ürün adı zorunludur")]

        [StringLength(100)]
        [Display(Name="Ürün Adı")]
        public string Name { get; set; }=string.Empty;

        [Required(ErrorMessage = "Fiyat zorunludur")]
        [Range(0,100000)]
        [Display(Name="Ürün Fiyatı")]
        public double? Price { get; set; }

        [Display(Name="Ürün Resmi")]
        public string Image { get; set; }=string.Empty;

        [Display(Name="Aktif Mi?")]
        public bool IsActive { get; set; }
        
        [Display(Name="Kategori")]
        [Required(ErrorMessage = "Kategori şeçimi zorunludur")]
        public int ? CategoryId { get; set; }
    }
}