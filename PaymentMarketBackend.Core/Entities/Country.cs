using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Core.Entities
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public int IdCountry { get; set; }
        public string Country1 { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
