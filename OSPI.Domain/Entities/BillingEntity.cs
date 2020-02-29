using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OSPI.Domain.Entities
{
    public class BillingEntity : IAuditableEntity
    {
        [Key]
        public Guid BillingId { get; set; }

        public Guid StoreId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ActualDate { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string InvoiceNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public int? TableNo { get; set; }

        public double? Discount { get; set; }

        public int? NoOfPerson { get; set; }

        public int? NoOfSC { get; set; }

        public int? Shift { get; set; }

        public int? Workstation { get; set; }

        public double? ServiceCharge { get; set; }

        public Guid PayeeReferenceId { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SalesCategory { get; set; }

        public Guid StatusId { get; set; }

        public Guid DiscountId { get; set; }

        public double? Deposit { get; set; }

        [Column(TypeName = "varchar(8000)")]
        public string Remarks { get; set; }

        [Column(TypeName = "varchar(1)")]
        public string TableCode { get; set; }

        public Guid? ServerId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CardNumber { get; set; }

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
