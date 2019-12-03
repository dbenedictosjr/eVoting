using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Store.Infrastructure.Models
{
    public class BillingModel
    {
        [StringLength(30, ErrorMessage = "Limit InvoiceNo to 30 characters.")]
        public string InvoiceNo { get; set; }

        public DateTime? TranDate { get; set; }

        public int? TableNo { get; set; }

        public double? Discount { get; set; }

        public int? NoOfPerson { get; set; }

        public int? NoOfSeniorCitizen { get; set; }

        public int? Shift { get; set; }

        public int? Workstation { get; set; }

        public double? ServiceCharge { get; set; }

        [Required]
        [StringLength(8000, ErrorMessage = "Limit Remarks to 8000 characters.")]
        public string Remarks { get; set; }

        [Required]
        [StringLength(1, ErrorMessage = "Limit Table Code to 1 characters.")]
        public string TableCode { get; set; }

        public Guid? ServerID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Card Number to 20 characters.")]
        public string CardNumber { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
