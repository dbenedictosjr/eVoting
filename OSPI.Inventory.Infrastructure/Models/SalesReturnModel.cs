using System;
using System.ComponentModel.DataAnnotations;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class SalesReturnModel
    {
        public Guid SalesReturnID { get; set; }

        [StringLength(30, ErrorMessage = "Limit Sales Return Number to 30 characters.")]
        public string SalesReturnNo { get; set; }

        public Guid? BillingID { get; set; }

        public DateTime? TranDate { get; set; }

        public double? Discount { get; set; }

        public int? Shift { get; set; }

        public int? Workstation { get; set; }

        public Guid? PayeeReferenceID { get; set; }

        public double? Deposit { get; set; }

        [StringLength(8000, ErrorMessage = "Limit Remarks to 8000 characters.")]
        public string Remarks { get; set; }

        public Guid? StoreID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
