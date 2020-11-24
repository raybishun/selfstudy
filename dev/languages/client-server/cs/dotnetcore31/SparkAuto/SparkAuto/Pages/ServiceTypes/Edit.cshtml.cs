using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Models;

namespace SparkAuto.Pages.ServiceTypes
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ServiceType ServiceType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServiceType = await _db.ServiceType.FirstOrDefaultAsync(m => m.Id == id);

            if (ServiceType == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_db.Attach(ServiceType).State = EntityState.Modified;

            //try
            //{
            //    await _db.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!ServiceTypeExists(ServiceType.Id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            // RB (Replacement for the above commented code)
            // This only updates the properties that were changed (not all properties in the model)
            var serviceFromDb = await _db.ServiceType.FirstOrDefaultAsync(s => s.Id == ServiceType.Id);
            serviceFromDb.Name = ServiceType.Name;
            serviceFromDb.Price = ServiceType.Price;
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        //private bool ServiceTypeExists(int id)
        //{
        //    return _db.ServiceType.Any(e => e.Id == id);
        //}
    }
}
