using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Core.Entities
{
    public partial class Annio : BaseEntity
    { 
        public Annio()
        {
            ChargeCards = new HashSet<ChargeCard>();
        }

        public int IdAnnio { get; set; }
        public int? Annio1 { get; set; }

        public virtual ICollection<ChargeCard> ChargeCards { get; set; }
    }
}
