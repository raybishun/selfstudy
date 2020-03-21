using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvc5_ef6.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name="Product Name")]
        public string Name { get; set; }

        [Display(Name="Product Price")]
        public decimal Price { get; set; }

    }
}