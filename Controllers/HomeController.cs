using Microsoft.AspNetCore.Mvc;

namespace MyCompanyApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
