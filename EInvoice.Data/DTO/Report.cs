using System.Collections.Generic;

namespace EInvoice.Data.DTO
{
    public class Report
    {
        public string InvoiceType { get; set; }
        public string Pattern { get; set; }
        public string Serial { get; set; }

        public int TotalBegining { get; set; }

        public int? FromBuyNo { get; set; }
        public int? ToBuyNo { get; set; }

        public int? FromBeginingNo { get; set; }
        public int? ToBeginingNo { get; set; }

        public int TotalAllInvoice { get; set; }
        public int? FromAllInvoice { get; set; }
        public int? ToAllInvoice { get; set; }

        public int TotalIssued { get; set; }

        public int TotalCanceled { get; set; }
        public List<int> ListCanceled { get; set; }

        public int TotalClosingStock { get; set; }
        public int? FromClosingStock { get; set; }
        public int? ToClosingStock { get; set; }
    }
}