using Microsoft.AspNetCore.Mvc;

namespace MyBp.Controllers
{
    using Microsoft.AspNetCore.Authentication.Cookies;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return this.SignOut(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
