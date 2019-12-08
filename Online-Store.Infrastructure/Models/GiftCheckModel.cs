using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class GiftCheckModel
    {
        public Guid GCID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Gift Check Number to 20 characters.")]
        public string GC_No { get; set; }

        public double? GC_Amount { get; set; }

        public DateTime? GC_From { get; set; }

        public DateTime? GC_To { get; set; }

        public Guid? StoreID { get; set; }

        public DateTime? TranDate { get; set; }

        public Guid? PayeeReferenceID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
