using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OSPI.Domain.Entities
{
    public class BallotEntity : IAuditableEntity
    {
        [Key]
        public Guid BallotId { get; set; }

        [Column(TypeName = "VARCHAR(10)")]
        public string RefCode { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        public string Description { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime RegStartDate { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime RegEndDate { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime VotingStartDate { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime VotingEndDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<PositionEntity> Positions { get; set; }
    }
}