using OSPI.Inventory.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Inventory.Domain.Entities
{
    public class PromoEntity : IAuditableRepository
    {
        [Key]
        public Guid PromoID { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string SalesCategory { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CustomerType { get; set; }

        public Guid? ProductID { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? StartHour { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? EndHour { get; set; }

        public double? DiscountAmount { get; set; }

        public double? DiscountPercent { get; set; }

        public double? Amount { get; set; }

        public bool? PromoActive { get; set; }

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
