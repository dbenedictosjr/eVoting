using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class BillingModel
    {
        [StringLength(30, ErrorMessage = "Limit Code to 30 characters.")]
        public string InvoiceNo { get; set; }

        public DateTime? TranDate { get; set; }

        public int? TableNo { get; set; }

        public double? Discount { get; set; }

        public int? NoOfPerson { get; set; }

        public int? NoOfSC { get; set; }

        public int? Shift { get; set; }

        public int? Workstation { get; set; }

        public double? ServiceCharge { get; set; }

        [Required]
        [StringLength(8000, ErrorMessage = "Limit Code to 8000 characters.")]
        public string Remarks { get; set; }

        [Required]
        [StringLength(1, ErrorMessage = "Limit Code to 1 characters.")]
        public string TableCode { get; set; }

        public Guid? ServerID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Code to 20 characters.")]
        public string CardNumber { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
