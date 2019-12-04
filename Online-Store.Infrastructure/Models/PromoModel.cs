using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class PromoModel
    {
        public Guid PromoID { get; set; }

        [StringLength(10, ErrorMessage = "Limit Sales Category to 10 characters.")]
        public string SalesCategory { get; set; }

        [StringLength(50, ErrorMessage = "Limit Customer Type to 50 characters.")]
        public string CustomerType { get; set; }

        public Guid? ProductID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? StartHour { get; set; }

        public DateTime? EndHour { get; set; }

        public double? DiscountAmount { get; set; }

        public double? DiscountPercent { get; set; }

        public double? Amount { get; set; }

        public bool? PromoActive { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
