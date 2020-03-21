using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using mvc5_ef6.Models;

namespace mvc5_ef6.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Product product = new Product() { ProductId = 1, Name = "Shirt", Price = 25.99m };

            return View(product);
        }

        public ActionResult List()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { ProductId=1, Name="p1", Price=1.25m},
                new Product() { ProductId=2, Name="p2", Price=4.25m},
                new Product() { ProductId=3, Name="p3", Price=21.35m}
            };

            return View(products);
        }

        public ActionResult Display()
        {
            return View();
        }
    }
}