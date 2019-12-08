using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Online_Store.Infrastructure.Models
{
    public class Product_YieldingModel
    {
        public Guid Product_YieldingID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ItemID { get; set; }

        public double? Quantity { get; set; }

        public Guid? ProductUnitID { get; set; }

        [StringLength(10, ErrorMessage = "Limit Sales Category to 10 characters.")]
        public string SalesCategory { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
