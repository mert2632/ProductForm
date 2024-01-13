using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFormMvcApp.Models
{
    public class ProductViewModel
    {
        public List<Product>? Products { get; set; }
        public List<Category>? Categories { get; set; }
        public string? SelectedCategory { get; set; }
    }
}