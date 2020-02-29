using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ReceivedOrderEntity : IAuditableEntity
    {

        [Key]
        public Guid ReceivedOrderId { get; set; }

        public Guid? StoreId { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string ReceivedOrderNo { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string DeliveryNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public Guid? PurchaseOrderId { get; set; }

        public Guid? SupplierId { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Remarks { get; set; }

        public double? OtherCharges { get; set; }

        public double? Discount { get; set; }

        public Guid? StatusId { get; set; }

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
