using CPW_219_eCommerceSite.Data;
using CPW_219_eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace CPW_219_eCommerceSite.Controllers
{
    public class MembersController : Controller
    {
        private readonly MerchKnicknacksContext _context;

        public MembersController(MerchKnicknacksContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel regModel)
        {
            if (ModelState.IsValid)
            {
                Member newMember = new()
                {
                    Email = regModel.Email,
                    Password = regModel.Password,
                };

                _context.Members.Add(newMember);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }
            return View(regModel);
        }

       
    }
}
