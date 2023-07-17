using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PureInvestWebsite.Models; // Add this using statement to include the necessary models

namespace PureInvestWebsite.Pages
{
    public class PurchaseModel : PageModel
    {
        [BindProperty]
        public PurchaseModel Purchase { get; set; } = new PurchaseModel();

        public IActionResult OnGet()
        {
            // Add your logic here for handling the GET request
            // Example: Initialize the purchase model or retrieve data for rendering the form

            return Page();
        }

        public IActionResult OnPostPurchase()
        {
            if (!ModelState.IsValid)
            {
                // If the form data is invalid, return to the form page
                return Page();
            }

            // Add your logic here for handling the form submission
            // Example: Process the purchase, update the database, send email notifications, etc.

            // For demonstration purposes, let's redirect to the home page
            return RedirectToPage("/Index");
        }
    }
}
