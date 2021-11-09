using System;
using System.Collections.Generic;

#nullable disable

namespace PaymentMarketBackend.Infrastructure.Data
{
    public partial class Invoice
    {
        public int IdInvoice { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? Date { get; set; }
        public int? IdChargeCard { get; set; }
        public int? IdCobrador { get; set; }

        public virtual ChargeCard IdChargeCardNavigation { get; set; }
        public virtual User IdCobradorNavigation { get; set; }
    }
}
