using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SparkAuto.Data;
using SparkAuto.Models;

namespace SparkAuto.Pages.ServiceTypes
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ServiceType  ServiceType { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        // NOTE: Don't need to pass ServiceType to the OnPostAsync method as the
        // [BindProperty] attribute is used for the ServiceType property above

        //public async Task<IActionResult> OnPostAsync(ServiceType serviceType)
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.ServiceType.Add(ServiceType);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
