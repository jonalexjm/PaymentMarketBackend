

namespace PaymentMarketBackend.Core.DTOs
{
    public class ChargeCardDto
    {
        public int IdChargeCard { get; set; }
        public string Description { get; set; }
        public decimal? Valor { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdMarket { get; set; }
        public int? IdAnnio { get; set; }
    }
}