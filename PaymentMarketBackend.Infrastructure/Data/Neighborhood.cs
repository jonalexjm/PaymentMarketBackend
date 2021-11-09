using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Infrastructure.Data
{
    public partial class Neighborhood
    {
        public Neighborhood()
        {
            Markets = new HashSet<Market>();
        }

        public int IdNeighborhood { get; set; }
        public string Neighborhood1 { get; set; }
        public int? IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Market> Markets { get; set; }
    }
}
