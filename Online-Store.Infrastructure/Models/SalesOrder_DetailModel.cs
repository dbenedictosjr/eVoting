using System;

namespace Online_Store.Infrastructure.Models
{
    public class SalesOrder_DetailModel
    {
        public Guid SalesOrderDetailID { get; set; }

        public Guid? SalesOrder { get; set; }

        public Guid? ProductID { get; set; }

        public double? Quantity { get; set; }

        public double? Price { get; set; }

        public double? Discount { get; set; }

        public Guid? DiscountID { get; set; }

        public double? SCDue { get; set; }

        public double? Cost { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
