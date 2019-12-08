using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class SalesReturnEntity : IAuditableRepository
    {
        [Key]
        public Guid SalesReturnID { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string SalesReturnNo { get; set; }

        public Guid? BillingID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public double? Discount { get; set; }

        public int? Shift { get; set; }

        public int? Workstation { get; set; }

        public Guid? PayeeReferenceID { get; set; }

        public double? Deposit { get; set; }

        [Column(TypeName = "varchar(8000)")]
        public string Remarks { get; set; }

        public Guid? StoreID { get; set; }

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
