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
        public Guid ProductYieldingID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ItemID { get; set; }

        public double? Quantity { get; set; }

        public Guid? ProductUnitID { get; set; }

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
