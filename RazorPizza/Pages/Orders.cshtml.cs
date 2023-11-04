using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class Orders : PageModel
    {
        public List<PizzaOrder> PizzaOrders { get; set; } = new List<PizzaOrder>();

        private readonly ApplicationDbContext _dbContext;

        public Orders(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            PizzaOrders = _dbContext.PizzaOrders.ToList();
        }
    }
}