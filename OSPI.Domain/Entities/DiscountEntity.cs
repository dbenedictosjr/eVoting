using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class DiscountEntity : IAuditableRepository
    {
        [Key]
        public Guid DiscountID { get; set; }

        [Column(TypeName = "varchar50")]
        public string DiscountDescription { get; set; }

        public double? Amount { get; set; }

        public double? DiscountPercent { get; set; }

        public bool? DiscountAfterVat { get; set; }

        public bool? Restricted { get; set; }

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
