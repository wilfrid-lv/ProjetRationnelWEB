using Microsoft.AspNetCore.Mvc;

namespace ProjetRationnelWEB.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

    }
}
