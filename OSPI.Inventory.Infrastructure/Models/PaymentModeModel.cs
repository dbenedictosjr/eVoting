using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class PaymentModeModel
    {
        public Guid PaymentModeID { get; set; }

        [StringLength(50, ErrorMessage = "Limit Payment Mode Description to 50 characters.")]
        public string PaymentModeDescription { get; set; }

        [StringLength(50, ErrorMessage = "Limit Payment Type to 50 characters.")]
        public string PaymentType { get; set; }

        public double? BankChargeAmount { get; set; }

        public double? BankChargePercent { get; set; }

        public bool? Active { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
