using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MvcCar.Data;
using MvcCar.Models;

namespace MvcCar.Controllers
{
    public class CarPurchasesController : Controller
    {
        private readonly MvcCarContext _context;

        public CarPurchasesController(MvcCarContext context)
        {
            _context = context;
        }

        // GET: CarPurchases
        public async Task<IActionResult> Index()
        {

            return View(await _context.CarPurchase.ToListAsync());
        }

        // GET: CarPurchases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarPurchase == null)
            {
                return NotFound();
            }

            var carPurchase = await _context.CarPurchase
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carPurchase == null)
            {
                return NotFound();
            }

            return View(carPurchase);
        }

        private bool CarPurchaseExists(int id)
        {
          return _context.CarPurchase.Any(e => e.Id == id);
        }
    }
}
