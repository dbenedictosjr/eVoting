using Online_Store.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class PurchaseReturnEntity : IAuditableRepository
    {
        [Key]
        public Guid PurchaseReturnID { get; set; }

        public Guid? StoreID { get; set; }

        [Column(TypeName = "varchar(20")]
        public string PurchaseReturnNo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public Guid? SupplierID { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Remarks { get; set; }

        public Guid? StatusID { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
