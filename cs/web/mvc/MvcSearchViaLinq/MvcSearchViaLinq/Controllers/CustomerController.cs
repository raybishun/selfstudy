using MvcSearchViaLinq.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcSearchViaLinq.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index(string name)
        {
            using (var db = new CustomerDbContext())
            {
                var customer = from c in db.Customers
                               where c.Name == name
                               select c;

                // var customer = db.Customers.Where(c => c.Name == name);

                return View(customer.ToList());
            }
        }
    }
}