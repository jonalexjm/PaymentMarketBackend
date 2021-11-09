using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Infrastructure.Data
{
    public partial class Rol
    {
        public Rol()
        {
            UserRols = new HashSet<UserRol>();
        }

        public int IdRol { get; set; }
        public string RolName { get; set; }

        public virtual ICollection<UserRol> UserRols { get; set; }
    }
}
