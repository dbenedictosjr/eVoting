using System;

namespace Online_Store.Infrastructure.Models
{
    public class Product_InventoryEntry_DetailModel
    {
        public Guid ProductInventoryEntryDetailID { get; set; }

        public Guid? ProductInventoryEntryID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Cost { get; set; }

        public DateTime? TranDate { get; set; }

        public double? SystemCount { get; set; }

        public double? PhysicalCount { get; set; }

        public bool? Edited { get; set; }

        public Guid? ProductUnitID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
