using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class UOMModel
    {
        [Key]
        public Guid BillingYieldingID { get; set; }

        public Guid? BillingID { get; set; }

        public Guid? StoreID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ItemID { get; set; }

        public double? Quantity { get; set; }

        public double? Cost { get; set; }

        public double? Price { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
