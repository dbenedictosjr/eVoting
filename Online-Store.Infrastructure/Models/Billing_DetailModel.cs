﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class Billing_DetailModel
    {
        [Key]
        public Guid BillingDetailID { get; set; }

        public Guid? BillingID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Quantity { get; set; }

        public double? Price { get; set; }

        public bool? Vatable { get; set; }

        public double? Discount { get; set; }

        public Guid? DiscountID { get; set; }

        public double? ServiceChargeDue { get; set; }

        public double? Cost { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
