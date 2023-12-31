﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Models;

namespace RazorPizza.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class Checkout : PageModel
    {
        public string? PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string? ImageTitle { get; set; }
        
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom Pizza";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

        }
    }
}