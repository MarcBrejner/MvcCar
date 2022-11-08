using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCar.Data;
using MvcCar.Migrations;
using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace MvcCar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCarContext(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<MvcCarContext>>()))
            {
                // Look for any cars.
                if (context.Car.Any())
                {
                    return;   // DB has been seeded
                }

                context.Car.AddRange(
                    new Car
                    {
                        Make = "Skoda",
                        Model = "Fabia",
                        Color = "Blue",
                        Extras = "Yes",
                        RecommendedPrice = 250000
                    },

                    new Car
                    {
                        Make = "Kia",
                        Model = "Ceed",
                        Color = "White",
                        Extras = "Yes",
                        RecommendedPrice = 180000
                    },

                    new Car
                    {
                        Make = "Ferrari",
                        Model = "Enzo",
                        Color = "Red",
                        Extras = "Yes",
                        RecommendedPrice = 2000000
                    }

                );

                context.Customer.AddRange(
                    new Customer
                    {
                        Name = "Mogens",
                        Surname = "Faber",
                        Age = 52,
                        HouseNumber = 1,
                        Street = "Bondegaardsvej",
                        Town = "Bondegaardsby",
                        ZipCode = 1000,
                        Country = "Denmark",
                        Created = (DateTime.Today)
                    },

                    new Customer
                    {
                        Name = "Klaus",
                        Surname = "Frimann",
                        Age = 31,
                        HouseNumber = 10,
                        Street = "Akademivej",
                        Town = "Lyngby",
                        ZipCode = 2800,
                        Country = "Denmark",
                        Created = (DateTime.Today)
                    },

                    new Customer
                    {
                        Name = "Gitte",
                        Surname = "Chen",
                        Age = 62,
                        HouseNumber = 14,
                        Street = "Alsikemarken",
                        Town = "Soeborg",
                        ZipCode = 2860,
                        Country = "Denmark",
                        Created = (DateTime.Today)
                    },

                new Customer
                    {
                        Name = "Gitte",
                        Surname = "Ib",
                        Age = 20,
                        HouseNumber = 12,
                        Street = "Alsikemarken",
                        Town = "Soeborg",
                        ZipCode = 2860,
                        Country = "Denmark",
                        Created = (DateTime.Today)
                    }

                );

                Car SuzukiSwift = new Car
                {
                    Make = "Suzuki",
                    Model = "Swift",
                    Color = "Silver",
                    Extras = "yes",
                    RecommendedPrice = 175000
                };

                Customer CustomerJens = new Customer
                {
                    Name = "Jens",
                    Surname = "Hansen",
                    Age = 52,
                    HouseNumber = 1,
                    Street = "Bondegaardsvej",
                    Town = "Bondegaardsby",
                    ZipCode = 1000,
                    Country = "Denmark",
                    Created = (DateTime.Today)
                };

                SalesPerson SalesMartin = new SalesPerson
                {
                    Name = "Martin",
                    Country = "Denmark",
                    HouseNumber = 30,
                    JobTitle = "Sales Person",
                    Salary = 30000,
                    Street = "Salgsvej",
                    Town = "Salgsby",
                    ZipCode = 2000
                };

                context.SalesPerson.Add(SalesMartin);
                context.Car.Add(SuzukiSwift);
                context.Customer.Add(CustomerJens);
                context.SaveChanges();

                //CarPurchase JensPurchase = new CarPurchase(SuzukiSwift, (DateTime.Today), 2);
                CarPurchase JensPurchase = new CarPurchase
                {
                    CarId = SuzukiSwift.Id,
                    CustomerId = CustomerJens.Id,
                    SalesPersonId = SalesMartin.Id,
                    PricePaid = (int)SuzukiSwift.RecommendedPrice,
                    OrderDate = DateTime.Today
                };

                context.CarPurchase.Add(JensPurchase);

                context.SaveChanges();
            }
        }
    }
}