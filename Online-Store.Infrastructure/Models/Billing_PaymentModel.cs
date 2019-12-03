using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class Billing_PaymentModel
    {
        [Key]
        public Guid BillingPaymentID { get; set; }

        public Guid? BillingID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? PaymentModeID { get; set; }

        public double? Amount { get; set; }

        public double? Tendered { get; set; }

        [StringLength(20, ErrorMessage = "Limit code to 20 characters.")]
        public string CardNo { get; set; }

        [StringLength(20, ErrorMessage = "Limit code to 20 characters.")]
        public string RefNo { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [StringLength(20, ErrorMessage = "Limit code to 20 characters.")]
        public string BankName { get; set; }

        public double? ChargeAmount { get; set; }

        public double? ChargePercent { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
