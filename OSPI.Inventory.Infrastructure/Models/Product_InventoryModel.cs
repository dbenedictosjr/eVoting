using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class Product_InventoryModel
    {
        public Guid ProductInventoryID { get; set; }

        public Guid? ProductID { get; set; }

        public DateTime? TransactionDate { get; set; }

        public double? Cost { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public double? Quantity { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
