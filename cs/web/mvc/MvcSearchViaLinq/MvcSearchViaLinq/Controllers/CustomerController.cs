using MvcSearchViaLinq.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcSearchViaLinq.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            // Uses a (default List) View to return all

            using (var db = new CustomerDbContext())
            {
                var customers = from c in db.Customers
                               select c;

                return View(customers.ToList());
            }
        }

        public ActionResult List(string name)
        {
            // Uses a custom List View to return 1 record

            using (var db = new CustomerDbContext())
            {
                var customer = from c in db.Customers
                               where c.Name == name
                               select c;

                // var customer = db.Customers.Where(c => c.Name == name);

                return View(customer.ToList());
            }
        }

        public ActionResult Details(string name)
        {
            using (var db = new CustomerDbContext())
            {
                //var customer = from c in db.Customers
                //               where c.Name == name
                //               select c;

                return View(db.Customers.Where(x => x.Name == "five").FirstOrDefault());
            }
        }

        public ActionResult Details2(string name)
        {
            // Uses a custom List View to return 1 record

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