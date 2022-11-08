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
    public class CarsController : Controller
    {
        private readonly MvcCarContext _context;

        public CarsController(MvcCarContext context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index(string searchString)
        {
            var cars = from m in _context.Car
                select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                cars = cars.Where(s => s.Model!.Contains(searchString));
            }

            return View(await cars.ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Car == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Cars/Create

        private bool CarExists(int id)
        {
          return _context.Car.Any(e => e.Id == id);
        }
    }
}
