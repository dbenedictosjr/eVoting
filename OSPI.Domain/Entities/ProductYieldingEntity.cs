using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ProductYieldingEntity : IAuditableEntity
    {
        [Key]
        public Guid ProductYieldingId { get; set; }

        public Guid? ProductId { get; set; }

        public Guid? ItemId { get; set; }

        public double? Quantity { get; set; }

        public Guid? ProductUnitId { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SalesCategory { get; set; }

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
