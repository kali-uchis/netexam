using Microsoft.AspNetCore.Mvc;
using netexam.Models;
using System.Diagnostics;

namespace netexam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static IList<user> usersList = new List<user> { };

        static string adminUserID = "admin@exam.com";
        static string customerId = "customer@exam.com";

        static string adminPass = "admin";
        static string customerPass = "customer";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult loginPage()
        {
            return View();
        }


        public IActionResult addUser()
        {
            return View();
        }



        

        public IActionResult signUpPage(user details)
        {
            Random Id = new Random();
            int userId = Id.Next(1, 10000);
            Console.WriteLine("user details: ", details);
            details.Id = userId;
            usersList.Add(details);

            ViewBag.details = details;
            return View("loginPage");


        }


        public IActionResult checkCredentials(login details)
        {
            Console.WriteLine(details);

            if (details.EmailId == adminUserID && details.Password == adminPass)
            {
                return RedirectToAction("adminexamIndex", "Admin");

            }


            if (details.EmailId == customerId && details.Password == customerPass)
            {
                return RedirectToAction("customerexamIndex", "Customer");

            }

            Console.WriteLine("Input details: ", details);
            foreach (var eachUser in usersList)
            {

                if (eachUser.Email == details.EmailId && eachUser.Password == details.Password)
                {
                   // if (eachUser.Email == "Customer")
//{
                        return RedirectToAction("customerexamIndex", "Customer");
//}

/*
                    if (eachUser.Email == "Admin") //admin@exam.com
                    {
                        return RedirectToAction("adminexamIndex", "Admin");
                    }
*/
                }
            }

            ViewBag.prompt = "Invalid Email ID or Password. Try again..."; //this ViewBag or ViewData sends from controller to view
            return View("loginPage");

        }
    }
}