using System;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class SalesReturn_YieldingModel
    {
        public Guid SalesReturnYieldingID { get; set; }

        public Guid? SalesReturnID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ItemID { get; set; }

        public double? Quantity { get; set; }

        public double? Price { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
