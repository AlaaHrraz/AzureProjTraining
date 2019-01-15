using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureProjTraining.ViewModels
{
    public class ProductViewModel
    {
        
            [Required]
            [Display(Name = "Product Name")]
            public string Name { get; set; }
            [Display(Name = "Product Description")]
            public string Description { get; set; }
        
    }
}
