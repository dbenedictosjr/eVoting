using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class PositionEntity : IAuditableEntity
    {
        [Key]
        public Guid PositionId { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        public string PositionName { get; set; }

        [Column(TypeName = "INT")]
        public int MinimumRequiredVotes { get; set; }

        [Column(TypeName = "INT")]
        public int MaximumRequiredVotes { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Qualifications { get; set; }

        public Guid BallotId { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BallotId")]
        public virtual BallotEntity Ballot { get; set; }
    }
}
