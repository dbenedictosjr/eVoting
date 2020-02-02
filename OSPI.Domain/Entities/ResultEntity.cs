using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class ResultEntity : IAuditableEntity
    {
        [Key]
        public Guid ResultID { get; set; }

        public Guid VoteID { get; set; }

        public Guid MemberID { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime DateVoted { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("VoteID")]
        public virtual VoteEntity Role { get; set; }

        [ForeignKey("MemberID")]
        public virtual MemberEntity Member { get; set; }
    }
}
