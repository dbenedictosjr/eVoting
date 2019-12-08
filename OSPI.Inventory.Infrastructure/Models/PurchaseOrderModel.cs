using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class PurchaseOrderModel
    {
        public Guid PurchaseOrderID { get; set; }

        [StringLength(30, ErrorMessage = "Limit Purchase Order No to 30 characters")]
        public string PurchaseOrderNo { get; set; }

        public DateTime? TranDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public Guid? RTPID { get; set; }

        public Guid? SupplierID { get; set; }

        [StringLength(500, ErrorMessage = "Limit Remarks to 500 characters")]
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
