using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureProjTraining.Pages
{
    public class IndexModel : PageModel
    {
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Display(Name = "Product Description")]
        public string Description { get; set; }

        public void OnGet()
        {

        }

        public  void OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            ////_db.Customers.Add(Customer);
            //// Thread(30); //await _db.SaveChangesAsync();
           // return RedirectToPage("/About");
        }
    }
}
