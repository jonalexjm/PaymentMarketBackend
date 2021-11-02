using System.Collections.Generic;

namespace PaymentMarketBackend.Core
{
    public class State : BaseEntity
    {
        
        public string  Description { get; set; }
        public int CountryId { get; set; }
        public Country country { get; set; }
        public virtual ICollection<City> cities { get; set; }
    }
}