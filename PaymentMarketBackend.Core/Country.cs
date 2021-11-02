using System.Collections.Generic;

namespace PaymentMarketBackend.Core
{
    public class Country : BaseEntity
    {
        
        public string Description { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}