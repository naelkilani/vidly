namespace Vidly.Dtos
{
    public class MembershipDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte DurationInMonths { get; set; }
        public decimal SignUpFee { get; set; }
        public decimal DiscountRate { get; set; }
        public string DiscountRateDisplay => $"{DiscountRate * 100}%";
    }
}