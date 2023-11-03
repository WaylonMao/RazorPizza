using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages.Forms;

public class CustomPizza : PageModel
{
    [BindProperty] public PizzasModel? Pizza { get; set; }
    public float PizzaPrice { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (Pizza == null) return BadRequest("Pizza is null");
        PizzaPrice = Pizza.BasePrice;
        if (Pizza.TomatoSauce) PizzaPrice += 1f;
        if (Pizza.Cheese) PizzaPrice += 2f;
        if (Pizza.Pepperoni) PizzaPrice += 1f;
        if (Pizza.Mushrooms) PizzaPrice += 1f;
        if (Pizza.Tuna) PizzaPrice += 1f;
        if (Pizza.Pineapple) PizzaPrice += 1f;
        if (Pizza.Ham) PizzaPrice += 2f;
        if (Pizza.Beef) PizzaPrice += 4f;

        return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
    }
}