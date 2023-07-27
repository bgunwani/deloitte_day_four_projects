using Microsoft.AspNetCore.Mvc;

namespace coreAuthenticationMiddlewares.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Process(string username, string password)
        {
            if(username != null && password != null && username.Equals("admin") && password.Equals("admin"))
            {
                HttpContext.Session.SetString("username", username);
                return View("Welcome");
            }
            ViewBag.Error = "Invalid Credentials";
            return View("Index");
        }
    }
}
