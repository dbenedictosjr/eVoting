using Online_Store.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class Product_InventoryEntry_DetailEntity : IAuditableRepository
    {
        [Key]
        public Guid ProductInventoryEntryDetailID { get; set; }

        public Guid? ProductInventoryEntryID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Cost { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? TranDate { get; set; }

        public double? SystemCount { get; set; }

        public double? PhysicalCount { get; set; }

        public bool? Edited { get; set; }

        public Guid? ProductUnitID { get; set; }

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
