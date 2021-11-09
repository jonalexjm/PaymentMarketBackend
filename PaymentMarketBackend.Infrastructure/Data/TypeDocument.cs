using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Infrastructure.Data
{
    public partial class TypeDocument
    {
        public TypeDocument()
        {
            Users = new HashSet<User>();
        }

        public int IdTypeDocument { get; set; }
        public string TypeDocument1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
