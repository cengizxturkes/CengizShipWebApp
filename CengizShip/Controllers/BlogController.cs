using Microsoft.AspNetCore.Mvc;

namespace CengizShip.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
