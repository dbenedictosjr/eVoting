using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class DiscountCardModel
    {
        public Guid CardID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Card Number to 20 characters.")]
        public string CardNo { get; set; }

        [StringLength(50, ErrorMessage = "Limit Card Number to 50 characters.")]
        public string CardDescription { get; set; }

        public double? DiscountAmount { get; set; }

        public double? DiscountPercent { get; set; }

        public DateTime? AquiredDate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
