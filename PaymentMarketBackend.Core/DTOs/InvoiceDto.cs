using System;

namespace PaymentMarketBackend.Core.DTOs
{
    public class InvoiceDto
    {
        public int IdInvoice { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? Date { get; set; }
        public int? IdChargeCard { get; set; }
        public int? IdCobrador { get; set; }
    }
}