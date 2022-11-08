using System.ComponentModel.DataAnnotations;

namespace MvcCar.Models
{
    public class Extra
    {
        public Extra(string extraItem)
        {
            ExtraItem = extraItem;
        }

        [Key]
        public int Id { get; set; }
        public string ExtraItem { get; set; }

        public override string ToString()
        {
            return ExtraItem;
        }
    }
}
