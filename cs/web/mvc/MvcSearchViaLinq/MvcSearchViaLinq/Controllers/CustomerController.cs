using MvcSearchViaLinq.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcSearchViaLinq.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult List()
        {
            using (var db = new CustomerDbContext())
            {
                var customers = from c in db.Customers
                                orderby c.LastCheckIn descending
                                select c;

                return View(customers.ToList());
            }
        }

        // [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Details(string name)
        {
            using (var db = new CustomerDbContext())
            {
                var customer = (from c in db.Customers
                               where c.Name == name
                               orderby c.LastCheckIn descending
                               select c).FirstOrDefault();

                // var customer = db.Customers.Where(c => c.Name == name).FirstOrDefault();

                return View(customer);
            }
        }
    }
}