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
    public class CustomersController : Controller
    {
        private readonly MvcCarContext _context;

        public CustomersController(MvcCarContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index(string searchString, string streetString)
        {   

            var customers = from c in _context.Customer select c;
            
            if (!string.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(streetString))
            {
                customers = customers.Where(s => s.Street.Contains(streetString));
            }

            var customerSearchView = new CustomerSearchView
            {
                Customers = await customers.ToListAsync()
            };

            return View(customerSearchView);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        private bool CustomerExists(int id)
        {
          return _context.Customer.Any(e => e.Id == id);
        }
    }
}
