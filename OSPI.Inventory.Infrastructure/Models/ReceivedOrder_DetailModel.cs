using System;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class ReceivedOrder_DetailModel
    {
        public Guid ReceivedOrderDetailID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? ReceivedOrderID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Quantity { get; set; }

        public double? Cost { get; set; }

        public Guid? ProductUnitID { get; set; }

        public double? UnitQuantity { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public Guid? PurchaseOrderDetailID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
