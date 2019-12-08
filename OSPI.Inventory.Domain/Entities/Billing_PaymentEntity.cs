using OSPI.Inventory.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Inventory.Domain.Entities
{
    public class Billing_PaymentEntity : IAuditableRepository
    {
        [Key]
        public Guid BillingPaymentID { get; set; }

        public Guid? BillingID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? PaymentModeID { get; set; }

        public double? Amount { get; set; }

        public double? Tendered { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CardNo { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string RefNo { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string BankName { get; set; }

        public double? ChargeAmount { get; set; }

        public double? ChargePercent { get; set; }

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
