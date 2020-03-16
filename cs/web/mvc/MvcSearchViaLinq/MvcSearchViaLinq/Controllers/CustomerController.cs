using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcSearchViaLinq.Models;

namespace MvcSearchViaLinq.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDbContext db = new CustomerDbContext();
        
        // GET: Customer
        public ActionResult Index(string name)
        {
            var customer = from c in db.Customers
                           where c.Name == name
                           select c;

            // var customer = db.Customers.Where(c => c.Name == name);

            return View(customer.ToList());
        }
    }
}