using System;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class Product_InventoryEntry_VarianceModel
    {
        public Guid ProductInventoryEntryVarianceID { get; set; }

        public DateTime? TranDate { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ProductInventoryEntryID { get; set; }

        public double? Quantity { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
