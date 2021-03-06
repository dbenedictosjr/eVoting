﻿using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace System.Domain.Entities
{
    public class BillingYieldingEntity : IAuditableEntity
    {
        [Key]
        public Guid BillingYieldingID { get; set; }

        public Guid? BillingID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ItemID { get; set; }

        public double? Quantity { get; set; }

        public double? Cost { get; set; }

        public double? Price { get; set; }

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
