using System;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class TotalSalesModel
    {
        public Guid TSID { get; set; }

        public DateTime? TranDate { get; set; }

        public double? Amount { get; set; }

        public int? WorkStation { get; set; }

        public bool? EODSent { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
