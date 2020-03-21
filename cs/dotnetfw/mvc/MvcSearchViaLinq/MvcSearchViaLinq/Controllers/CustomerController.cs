using System.Linq;
using System.Web.Mvc;

using MvcSearchViaLinq.Models;

namespace MvcSearchViaLinq.Controllers
{
    public class CustomerController : Controller
    {
        //[HttpGet]
        //public ActionResult Details()
        //{
        //    return View(new Customer());
        //}

        // [AcceptVerbs(HttpVerbs.Post)]
        // [HttpPost]
        public ActionResult Details(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                using (var db = new CustomerDbContext())
                {
                    var customer = (from c in db.Customers
                                    where c.Name == name.Trim()
                                    orderby c.LastCheckIn descending
                                    select c).FirstOrDefault();

                    // var customer = db.Customers.Where(c => c.Name == name).FirstOrDefault();

                    if (customer == null)
                    {
                        return View(new Customer() { Name = $"[{name}] not found." });
                    }

                    return View(customer);
                }
            }
            else
            {
                return View(new Customer());
            }
        }

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

        [HttpGet]
        public ActionResult Create()
        {
            var customer = new Customer();

            return View(customer);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            using (var db = new CustomerDbContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }

            return RedirectToAction("Details");
        }
    }
}