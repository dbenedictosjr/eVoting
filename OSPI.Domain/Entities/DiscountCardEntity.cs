using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class DiscountCardEntity : IAuditableEntity
    {
        [Key]
        public Guid CardID { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CardNo { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string CardDescription { get; set; }

        public double? DiscountAmount { get; set; }

        public double? DiscountPercent { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? AquiredDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }

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
