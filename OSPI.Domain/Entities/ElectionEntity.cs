using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ElectionEntity : IAuditableEntity
    {
        [Key]
        public Guid ElectionId { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime DateVoted { get; set; }
        
        public Guid MemberId { get; set; }

        public Guid BallotId { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("MemberId")]
        public virtual MemberEntity Member { get; set; }

        [ForeignKey("BallotId")]
        public virtual BallotEntity Ballot { get; set; }
    }
}