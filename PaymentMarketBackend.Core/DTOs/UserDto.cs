namespace PaymentMarketBackend.Core.DTOs
{
    public class UserDto
    {
        public int IdUser { get; set; }
        public string NumberDocument { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? IdTypeDocument { get; set; }
        public int? IdCity { get; set; }
    }
}