using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MvcCar.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public int? HouseNumber { get; set; }
        public string? Street { get; set; }
        public string? Town { get; set; }

        [Display(Name = "Zip Code")]
        public int? ZipCode { get; set; }
        public string? Country { get; set; }

        [Display(Name= "Address")]
        public string Address
        {
            get
            {
                return $"{Street} {HouseNumber}, {ZipCode}, {Town}, {Country}";
            }
        }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        public virtual ICollection<CarPurchase> Purchases { get; set; }
    }
}
