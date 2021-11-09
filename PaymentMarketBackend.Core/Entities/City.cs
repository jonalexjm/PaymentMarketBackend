using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Core.Entities
{
    public partial class City
    {
        public City()
        {
            Neighborhoods = new HashSet<Neighborhood>();
            Users = new HashSet<User>();
        }

        public int IdCity { get; set; }
        public string City1 { get; set; }
        public int? IdState { get; set; }

        public virtual State IdStateNavigation { get; set; }
        public virtual ICollection<Neighborhood> Neighborhoods { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
