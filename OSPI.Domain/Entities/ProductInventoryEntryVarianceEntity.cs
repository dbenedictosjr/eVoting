using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ProductInventoryEntryVarianceEntity : IAuditableEntity
    {
        [Key]
        public Guid ProductInventoryEntryVarianceID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ProductInventoryEntryID { get; set; }

        public double? Quantity { get; set; }

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
