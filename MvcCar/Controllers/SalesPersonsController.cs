using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcCar.Data;
using MvcCar.Models;

namespace MvcCar.Controllers
{
    public class SalesPersonsController : Controller
    {
        private readonly MvcCarContext _context;

        public SalesPersonsController(MvcCarContext context)
        {
            _context = context;
        }

        // GET: SalesPersons
        public async Task<IActionResult> Index()
        {
              return View(await _context.SalesPerson.ToListAsync());
        }

        // GET: SalesPersons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SalesPerson == null)
            {
                return NotFound();
            }

            var salesPerson = await _context.SalesPerson
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesPerson == null)
            {
                return NotFound();
            }

            return View(salesPerson);
        }

        private bool SalesPersonExists(int id)
        {
          return _context.SalesPerson.Any(e => e.Id == id);
        }
    }
}
