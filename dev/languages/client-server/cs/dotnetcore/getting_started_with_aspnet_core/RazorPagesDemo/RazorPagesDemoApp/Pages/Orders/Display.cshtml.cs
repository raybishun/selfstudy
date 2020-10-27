using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemoApp.Pages.Orders
{
    public class DisplayModel : PageModel
    {
        private readonly IOrderData _orderData;
        private readonly IFoodData _foodData;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public OrderModel Order { get; set; }
        public string ItemPurchased { get; set; }

        public DisplayModel(IOrderData orderData, IFoodData foodData)
        {
            _orderData = orderData;
            _foodData = foodData;
        }

        public void OnGet()
        {
        }
    }
}
