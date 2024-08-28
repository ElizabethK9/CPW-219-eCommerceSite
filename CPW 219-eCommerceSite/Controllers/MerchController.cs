using CPW_219_eCommerceSite.Data;
using CPW_219_eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace CPW_219_eCommerceSite.Controllers
{
    public class MerchController : Controller
    {
        private readonly MerchKnicknacksContext _context;

        public MerchController(MerchKnicknacksContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Merch merch)
        {
            if (ModelState.IsValid)
            {
                _context.Merchendise.Add(merch);
                await _context.SaveChangesAsync();

                ViewData["Message"] = $"{merch.Title} was added successfully!";
                //Show succes message on page
                return View();
            }

            return View(merch);
        }
    }
}
