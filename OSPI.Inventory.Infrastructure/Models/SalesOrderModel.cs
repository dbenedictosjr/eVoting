using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class SalesOrderModel
    {
        public Guid SalesOrderID { get; set; }

        [StringLength(30, ErrorMessage = "Limit Sales Order Number to 30 characters.")]
        public string SalesOrderNo { get; set; }

        public DateTime? TranDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int? TableNo { get; set; }

        public double? Discount { get; set; }

        public int? NoOfPerson { get; set; }

        public int? NoOfSC { get; set; }

        public double? ServiceCharge { get; set; }

        public Guid? PayeeReferenceID { get; set; }

        [StringLength(10, ErrorMessage = "Limit Sales Category to 10 characters.")]
        public string SalesCategory { get; set; }

        public Guid? StatusID { get; set; }

        public Guid? DiscountID { get; set; }

        [StringLength(500, ErrorMessage = "Limit Remarks to 500 characters.")]
        public string Remarks { get; set; }

        public double? Deposit { get; set; }

        public Guid? BillingID { get; set; }

        [StringLength(1, ErrorMessage = "Limit Table Code to 1 characters.")]
        public string TableCode { get; set; }

        public Guid? ServerID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Card Number to 20 characters.")]
        public string CardNumber { get; set; }

        public double? SvcCharge { get; set; }

        public int? SvcType { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
