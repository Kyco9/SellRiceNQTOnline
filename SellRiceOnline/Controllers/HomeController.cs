using Microsoft.AspNetCore.Mvc;

namespace SellRiceOnline.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
