using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Core.Entities
{
    public partial class User : BaseEntity
    {
        public User()
        {
            ChargeCards = new HashSet<ChargeCard>();
            Invoices = new HashSet<Invoice>();
            UserRols = new HashSet<UserRol>();
        }

        public int IdUser { get; set; }
        public string NumberDocument { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? IdTypeDocument { get; set; }
        public int? IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual TypeDocument IdTypeDocumentNavigation { get; set; }
        public virtual ICollection<ChargeCard> ChargeCards { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }
    }
}
