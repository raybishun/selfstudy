using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoHtmlAndTagHelpersApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoHtmlAndTagHelpersApp.Pages
{
    public class TwoFormsModel : PageModel
    {
        [BindProperty]
        public PersonModel  NewPerson { get; set; }
        [BindProperty]
        public AddressModel NewAddress { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostPersonAsync()
        {
            if (!ModelState.IsValid)
            {
                // Return page in the same condition
                return Page();
            }

            // Essentially refresh the page and call OnGetAsync()
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAddressAsync()
        {
            if (!ModelState.IsValid)
            {
                // Return page in the same condition
                return Page();
            }

            // Essentially refresh the page and call OnGetAsync()
            return RedirectToPage();
        }
    }
}
