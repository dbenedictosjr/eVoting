using System;

namespace Online_Store.Infrastructure.Models
{
    public class SalesOrder_SlipModel
    {
        public Guid SalesOrderSlipID { get; set; }

        public Guid? SalesOrderID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Quantity { get; set; }

        public double? Price { get; set; }

        public double? Discount { get; set; }

        public Guid? DiscountID { get; set; }

        public DateTime? TranDate { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
