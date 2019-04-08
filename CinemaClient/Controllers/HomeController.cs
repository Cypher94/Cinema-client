using Microsoft.AspNetCore.Mvc;

namespace CinemaClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}