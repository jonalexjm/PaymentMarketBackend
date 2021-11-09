using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Core.Entities
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
        }

        public int IdState { get; set; }
        public string State1 { get; set; }
        public int? IdCountry { get; set; }

        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
