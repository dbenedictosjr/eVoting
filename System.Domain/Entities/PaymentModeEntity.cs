using System.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Domain.Entities
{
    public class PaymentModeEntity : IAuditableEntity
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
