using OSPI.Inventory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Inventory.Domain.Entities
{
    public class PaymentModeEntity : IAuditableRepository
    {
        [Key]
        public Guid PaymentModeID { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string PaymentModeDescription { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string PaymentType { get; set; }

        public double? BankChargeAmount { get; set; }

        public double? BankChargePercent { get; set; }

        public bool? Active { get; set; }

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
