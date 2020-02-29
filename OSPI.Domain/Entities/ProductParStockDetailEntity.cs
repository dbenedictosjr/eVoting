using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ProductParStockDetailEntity : IAuditableEntity
    {
        [Key]
        public Guid ParStockDetailId { get; set; }

        public Guid? ParStockId { get; set; }

        public Guid? ProductId { get; set; }

        public double? MaximumStock { get; set; }

        public double? MinimumStock { get; set; }

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
