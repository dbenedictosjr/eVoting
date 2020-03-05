using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class CandidateEntity : IAuditableEntity
    {
        [Key]
        public Guid CandidateId { get; set; }

        public Guid PositionId { get; set; }

        public Guid CandidateMemberId { get; set; }

        public Guid NomineeMemberId { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string Plataforma { get; set; }

        [Column(TypeName = "char(30)")]
        public string Status { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("PositionId")]
        public virtual PositionEntity Position { get; set; }

        [ForeignKey("CandidateMemberId")]
        public virtual MemberEntity CandidateMember { get; set; }

        [ForeignKey("NomineeMemberId")]
        public virtual MemberEntity NomineeMember { get; set; }

        public virtual ICollection<ElectionDetailEntity> Votes { get; set; }
    }
}
