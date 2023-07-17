using Microsoft.AspNetCore.Mvc;

namespace PureInvestWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
