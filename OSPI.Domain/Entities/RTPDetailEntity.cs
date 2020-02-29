using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class RTPDetailEntity : IAuditableEntity
    {
        [Key]
        public Guid RTPDetailId { get; set; }

        public Guid? RTPId { get; set; }

        public Guid? ProductId { get; set; }

        public double? Quantity { get; set; }

        public double? MaximumStock { get; set; }

        public double? Stock { get; set; }

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
