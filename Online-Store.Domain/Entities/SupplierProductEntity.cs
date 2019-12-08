using Online_Store.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.Domain.Entities
{
    public class SupplierProductEntity : IAuditableRepository
    {
        [Key]
        public Guid SupplierProductID { get; set; }

        public Guid? SupplierID { get; set; }

        public Guid? ProductID { get; set; }

        public double? Cost { get; set; }

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
