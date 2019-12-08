using Online_Store.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class ProductParStock_DetailEntity : IAuditableRepository
    {
        [Key]
        public Guid ParStockDetailID { get; set; }

        public Guid? ParStockID { get; set; }

        public Guid? ProductID { get; set; }

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
