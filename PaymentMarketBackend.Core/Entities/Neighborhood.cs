using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Core.Entities
{
    public partial class Neighborhood : BaseEntity
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
