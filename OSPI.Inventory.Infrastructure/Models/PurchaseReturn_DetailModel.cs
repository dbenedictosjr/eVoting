using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class PurchaseReturn_DetailModel
    {
        public Guid PurchaseReturnDetailID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? PurchaseReturnID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Quantity { get; set; }

        public double? Cost { get; set; }

        public Guid? ProductUnitID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
