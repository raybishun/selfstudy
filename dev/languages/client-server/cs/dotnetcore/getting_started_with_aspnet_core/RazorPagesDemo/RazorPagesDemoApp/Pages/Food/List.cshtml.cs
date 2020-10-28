using System.Collections.Generic;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemoApp.Pages.Food
{
    public class ListModel : PageModel
    {
        private readonly IFoodData _foodData;
        public List<FoodModel> Food { get; set; }
        public ListModel(IFoodData foodData)
        {
            _foodData = foodData;
        }

        public async Task OnGet()
        {
            Food = await _foodData.GetFood();
        }
    }
}
