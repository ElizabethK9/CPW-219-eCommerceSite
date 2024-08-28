using Microsoft.AspNetCore.Mvc;

namespace CPW_219_eCommerceSite.Controllers
{
    public class MerchController : Controller
    {
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
    }
}
