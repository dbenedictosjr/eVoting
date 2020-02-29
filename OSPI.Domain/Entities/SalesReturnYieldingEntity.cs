using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class SalesReturnYieldingEntity : IAuditableEntity
    {
        [Key]
        public Guid SalesReturnYieldingId { get; set; }

        public Guid? SalesReturnId { get; set; }

        public Guid? ProductId { get; set; }

        public Guid? ItemId { get; set; }

        public double? Quantity { get; set; }

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
