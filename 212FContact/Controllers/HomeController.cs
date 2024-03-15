using Microsoft.AspNetCore.Mvc;

namespace _212FContact.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
