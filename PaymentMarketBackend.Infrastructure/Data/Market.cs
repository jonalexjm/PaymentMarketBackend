using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Infrastructure.Data
{
    public partial class Market
    {
        public Market()
        {
            ChargeCards = new HashSet<ChargeCard>();
        }

        public int IdMarket { get; set; }
        public string Market1 { get; set; }
        public int? IdNeighborhood { get; set; }

        public virtual Neighborhood IdNeighborhoodNavigation { get; set; }
        public virtual ICollection<ChargeCard> ChargeCards { get; set; }
    }
}
