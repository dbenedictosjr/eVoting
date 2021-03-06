﻿using System.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Domain.Entities
{
    public class PurchaseOrderDetailEntity : IAuditableEntity
    {
        [Key]
        public Guid PurchaseOrderDetailID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? PurchaseOrderID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Quantity { get; set; }

        public double? Cost { get; set; }

        public double? MaximumStock { get; set; }

        public double? Stock { get; set; }

        public double? DRQuantity { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
