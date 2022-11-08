using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCar.Models;

namespace MvcCar.Data
{
    public class MvcCarContext : DbContext
    {
        public MvcCarContext (DbContextOptions<MvcCarContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCar.Models.Car> Car { get; set; } = default!;

        public DbSet<MvcCar.Models.Customer> Customer { get; set; }

        public DbSet<MvcCar.Models.SalesPerson> SalesPerson { get; set; }

        public DbSet<MvcCar.Models.CarPurchase> CarPurchase { get; set; }
    }
}
