using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Infrastructure.Data
{
    public partial class TypeIdentification
    {
        public TypeIdentification()
        {
            Users = new HashSet<User>();
        }

        public int IdTypeIdentification { get; set; }
        public string TypeIdentification1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
