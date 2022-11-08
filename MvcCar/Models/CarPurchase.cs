using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCar.Models
{
    public class CarPurchase
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public int SalesPersonId { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public int PricePaid { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        [Required]
        public virtual Car Car { get; set; }
    }
}
