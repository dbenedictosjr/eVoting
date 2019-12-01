using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class BillingModel
    {
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

        [Required]
        [StringLength(8000, ErrorMessage = "Limit Code to 8000 characters.")]
        public string Remarks { get; set; }

        [Required]
        [StringLength(1, ErrorMessage = "Limit Code to 1 characters.")]
        public string TableCode { get; set; }

        public long? ServerID { get; set; }

        [StringLength(20)]
        public string CardNumber { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }



        [Required]
        public Guid ID { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Limit Code to 10 characters.")]
        public string Code { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Limit Description to 50 characters.")]
        public string Description { get; set; }

        public byte[] RowVersion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
