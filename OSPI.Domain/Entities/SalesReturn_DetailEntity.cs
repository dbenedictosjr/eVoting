using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class SalesReturn_DetailEntity : IAuditableRepository
    {
        [Key]
        public Guid SalesReturnDetailID { get; set; }

        public Guid? SalesReturnID { get; set; }

        public Guid? ProductID { get; set; }

        public Guid? ProductUnitID { get; set; }

        public double? Quantity { get; set; }

        public double? Price { get; set; }

        public double? Discount { get; set; }

        public Guid? StoreID { get; set; }

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
