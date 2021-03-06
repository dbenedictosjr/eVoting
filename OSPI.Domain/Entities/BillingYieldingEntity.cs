﻿using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OSPI.Domain.Entities
{
    public class BillingYieldingEntity : IAuditableEntity
    {
        [Key]
        public Guid BillingYieldingId { get; set; }

        public Guid? BillingId { get; set; }

        public Guid? StoreId { get; set; }

        public Guid? ProductId { get; set; }

        public Guid? ItemId { get; set; }

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
