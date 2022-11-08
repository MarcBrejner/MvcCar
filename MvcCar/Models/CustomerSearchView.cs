using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcCar.Models
{
    public class CustomerSearchView
    {
        public List<Customer>? Customers { get; set; }
        public string? StreetString { get; set; }
        public string? SearchString { get; set; }
    }
}
