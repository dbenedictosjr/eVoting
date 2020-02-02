using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class QualificationEntity : IAuditableRepository
    {
        [Key]
        public Guid QualificationID { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Description { get; set; }

        public Guid PositionID { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PositionID")]
        public virtual PositionEntity Position { get; set; }
    }
}
