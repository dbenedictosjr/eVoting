using OSPI.Inventory.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Inventory.Domain.Entities
{
    public class ReceivedOrderEntity : IAuditableRepository
    {

        [Key]
        public Guid ReceivedOrderID { get; set; }

        public Guid? StoreID { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string ReceivedOrderNo { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string DeliveryNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public Guid? PurchaseOrderID { get; set; }

        public Guid? SupplierID { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Remarks { get; set; }

        public double? OtherCharges { get; set; }

        public double? Discount { get; set; }

        public Guid? StatusID { get; set; }

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
