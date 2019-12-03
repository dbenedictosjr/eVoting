using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Store.Infrastructure.Models
{
    public class ReceivedOrderModel
    {
        public Guid ReceivedOrderID { get; set; }

        public Guid? StoreID { get; set; }

        [StringLength(30, ErrorMessage = "Limit Received Order Number to 30 characters.")]
        public string ReceivedOrderNo { get; set; }

        [StringLength(30, ErrorMessage = "Limit Delivery Number to 30 characters.")]
        public string DeliveryNo { get; set; }

        public DateTime? TranDate { get; set; }

        public Guid? PurchaseOrderID { get; set; }

        public Guid? SupplierID { get; set; }

        [StringLength(30, ErrorMessage = "Limit Remarks to 500 characters.")]
        public string Remarks { get; set; }

        public double? OtherCharges { get; set; }

        public double? Discount { get; set; }

        public Guid? StatusID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
