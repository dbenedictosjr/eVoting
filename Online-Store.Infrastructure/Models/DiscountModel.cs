using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class DiscountModel
    {
        public Guid DiscountID { get; set; }

        [StringLength(50, ErrorMessage = "Limit Discount Description to 50 characters.")]
        public string DiscountDescription { get; set; }

        public double? Amount { get; set; }

        public double? DiscountPercent { get; set; }

        public bool? DiscountAfterVat { get; set; }

        public bool? Restricted { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
