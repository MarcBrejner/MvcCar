using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.IO;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using MvcCar.Controllers;
using NuGet.Packaging;

namespace MvcCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }

        [Display(Name = "Recommended Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal RecommendedPrice { get; set; }
        public string? Extras { get; set; }
        public virtual ICollection<CarPurchase> Purchases { get; set; }
    }
}