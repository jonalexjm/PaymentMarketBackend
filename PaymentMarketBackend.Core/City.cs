namespace PaymentMarketBackend.Core
{
    public class City : BaseEntity
    {
        
        public string Description { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}