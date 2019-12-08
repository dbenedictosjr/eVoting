using System;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class SalesReturn_DetailModel
    {
        public Guid SalesReturnDetailID { get; set; }

        public Guid? SalesReturnID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ProductUnitID { get; set; }

        public double? Quantity { get; set; }

        public double? Price { get; set; }

        public double? Discount { get; set; }

        public Guid? StoreID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
