using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class VoteDetailEntity : IAuditableEntity
    {
        [Key]
        public Guid VoteDetailId { get; set; }

        public Guid VoteId { get; set; }

        public Guid CandidateId { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("VoteId")]
        public virtual VoteEntity Vote { get; set; }

        [ForeignKey("CandidateId")]
        public virtual CandidateEntity Candidate { get; set; }
    }
}