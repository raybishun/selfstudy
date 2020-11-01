using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoHtmlAndTagHelpersApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoHtmlAndTagHelpersApp.Pages
{
    public class DataDemoModel : PageModel
    {
        public List<PersonModel> People { get; set; } = new List<PersonModel>();
        
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } = "";

        [BindProperty]
        public PersonModel NewPerson { get; set; }

        public async Task OnGetAsync()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Peter", LastName = "Parker" });
            output.Add(new PersonModel { FirstName = "Bruce", LastName = "Wayne" });
            output.Add(new PersonModel { FirstName = "Ray", LastName = "Bishun" });

            if (string.IsNullOrWhiteSpace(SearchTerm) == false)
            {
                People = output.Where(x => x.LastName.StartsWith(SearchTerm)).ToList();
            }
            else
            {
                // Return the full list
                // People = output;
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // Return page in the same condition
                return Page();
            }

            People.Add(NewPerson);

            // Essentially refresh the page and call OnGetAsync()
            return RedirectToPage();
        }
    }
}
