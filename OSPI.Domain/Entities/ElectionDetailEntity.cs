using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ElectionDetailEntity : IAuditableEntity
    {
        [Key]
        public Guid ElectionDetailId { get; set; }

        public Guid ElectionId { get; set; }

        public Guid CandidateId { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ElectionId")]
        public virtual ElectionEntity Election { get; set; }

        [ForeignKey("CandidateId")]
        public virtual CandidateEntity Candidate { get; set; }
    }
}