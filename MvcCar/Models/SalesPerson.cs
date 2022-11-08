using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MvcCar.Models
{
    public class SalesPerson
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? JobTitle { get; set; }
        public int? HouseNumber { get; set; }
        public string? Street { get; set; }
        public string? Town { get; set; }

        [Display(Name = "Zip Code")]
        public int? ZipCode { get; set; }
        public string? Country { get; set; }

        [Display(Name = "Address")]
        public string Address
        {
            get
            {
                return $"{Street} {HouseNumber}, {ZipCode}, {Town}, {Country}";
            }
        }
        
        public int? Salary { get; set; }

        public virtual ICollection<CarPurchase> Purchases { get; set; }
    }
}
