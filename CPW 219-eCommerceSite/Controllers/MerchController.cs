﻿using CPW_219_eCommerceSite.Data;
using CPW_219_eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;

namespace CPW_219_eCommerceSite.Controllers
{
    public class MerchController : Controller
    {
        private readonly MerchKnicknacksContext _context;

        public MerchController(MerchKnicknacksContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() 
        { 
            
           // List<Merch> Merchendise = _context.Merchendise.ToList();
           List<Merch> Merchendise = await (from merch  in _context.Merchendise select merch) .ToListAsync();

            return View(Merchendise);
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

        public async Task<IActionResult> Edit(InformationType id)
        {
            Merch? merchToEdit = await _context.Merchendise.FindAsync(id);
            if (merchToEdit == null)
            {
                return NotFound();
            }
            return View(merchToEdit);
        }
    }
}
