using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Core.Entities
{
    public partial class ChargeCard
    {
        public ChargeCard()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int IdChargeCard { get; set; }
        public string Description { get; set; }
        public decimal? Valor { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdMarket { get; set; }
        public int? IdAnnio { get; set; }

        public virtual Annio IdAnnioNavigation { get; set; }
        public virtual User IdCustomerNavigation { get; set; }
        public virtual Market IdMarketNavigation { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
