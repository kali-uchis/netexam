using Microsoft.AspNetCore.Mvc;

namespace examnet.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult adminexamIndex()
        {
            return View();
        }
    }
}
