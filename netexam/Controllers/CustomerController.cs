using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult customerexamIndex()
        {
            return View();
        }
    }
}
