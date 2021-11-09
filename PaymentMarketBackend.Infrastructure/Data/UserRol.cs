using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Infrastructure.Data
{
    public partial class UserRol
    {
        public int IdUserRol { get; set; }
        public int? IdUser { get; set; }
        public int? IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
