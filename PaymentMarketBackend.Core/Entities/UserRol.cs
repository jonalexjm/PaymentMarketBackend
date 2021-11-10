using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Core.Entities
{
    public partial class UserRol : BaseEntity
    {
        public int IdUserRol { get; set; }
        public int? IdUser { get; set; }
        public int? IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
