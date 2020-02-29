using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ReceivedOrderDetailEntity : IAuditableEntity
    {
        [Key]
        public Guid ReceivedOrderDetailId { get; set; }

        public Guid? StoreId { get; set; }

        public Guid? ReceivedOrderId { get; set; }

        public Guid? ProductId { get; set; }

        public double? Quantity { get; set; }

        public double? Cost { get; set; }

        public Guid? ProductUnitId { get; set; }

        public double? UnitQuantity { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }

        public Guid? PurchaseOrderDetailId { get; set; }

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
