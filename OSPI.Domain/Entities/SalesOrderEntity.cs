using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class SalesOrderEntity : IAuditableEntity
    {
        [Key]
        public Guid SalesOrderId { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string SalesOrderNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }

        public int? TableNo { get; set; }

        public double? Discount { get; set; }

        public int? NoOfPerson { get; set; }

        public int? NoOfSC { get; set; }

        public double? ServiceCharge { get; set; }

        public Guid? PayeeReferenceId { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SalesCategory { get; set; }

        public Guid? StatusId { get; set; }

        public Guid? DiscountId { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Remarks { get; set; }

        public double? Deposit { get; set; }

        public Guid? BillingId { get; set; }

        [Column(TypeName = "varchar(1)")]
        public string TableCode { get; set; }

        public Guid? ServerId { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CardNumber { get; set; }

        public double? SvcCharge { get; set; }

        public int? SvcType { get; set; }

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
