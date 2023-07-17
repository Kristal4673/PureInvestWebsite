using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PureInvestWebsite.Models;

namespace PureInvestWebsite.PageModels
{
    public class AddToCartModel : PageModel
    {
        [BindProperty]
        public CartModel? Cart { get; set; }

        public IActionResult OnGet()
        {
            // Add your logic here for handling the GET request
            // Example: Initialize the cart or retrieve the cart items from a database or session
            Cart = new CartModel();

            // Pass the cart model to the Razor Page for rendering
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // If the form data is invalid, return to the form page
                return Page();
            }

            // Add your logic here for handling the form submission
            // Example: Update the cart with the selected product or perform any other necessary actions

            // For demonstration purposes, let's redirect to the home page
            return RedirectToPage("/Index");
        }
    }
}
