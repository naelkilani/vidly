using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public byte DurationInMonths { get; set; }
        public decimal SignUpFee { get; set; }
        public decimal DiscountRate { get; set; }
        [NotMapped]
        public string DiscountRateDisplay => $"{DiscountRate * 100}%";
    }
}