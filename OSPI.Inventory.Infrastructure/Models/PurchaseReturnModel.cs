using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OSPI.Inventory.Infrastructure.Models
{
    public class PurchaseReturnModel
    {
        public Guid PurchaseReturnID { get; set; }

        public Guid? StoreID { get; set; }

        [StringLength(20, ErrorMessage = "Limit Purchase Return Number to 20 characters.")]
        public string PurchaseReturnNo { get; set; }

        public DateTime? TranDate { get; set; }

        public Guid? SupplierID { get; set; }

        [StringLength(500, ErrorMessage = "Limit Remarks to 500 characters.")]
        public string Remarks { get; set; }

        public Guid? StatusID { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
