using Microsoft.AspNetCore.Mvc;

namespace CPW_219_eCommerceSite.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
