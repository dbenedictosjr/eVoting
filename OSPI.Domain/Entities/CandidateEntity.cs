using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OSPI.Domain.Entities
{
   public class CandidateEntity : IAuditableEntity
    {
        [Key]
        public Guid CandidateID { get; set; }

        public Guid PositionID { get; set; }

        public Guid CandidateMemberID { get; set; }

        public Guid NomineeMemberID { get; set; }

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

        [ForeignKey("PositionID")]
        public virtual PositionEntity Position { get; set; }

        [ForeignKey("CandidateMemberID")]
        public virtual MemberEntity CandidateMember { get; set; }

        [ForeignKey("NomineeMemberID")]
        public virtual MemberEntity NomineeMember { get; set; }
    }
}
