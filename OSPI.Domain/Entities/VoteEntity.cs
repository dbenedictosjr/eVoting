using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class VoteEntity : IAuditableEntity
    {
        [Key]
        public Guid VoteID { get; set; }

        public Guid CandidateID { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("CandidateID")]
        public virtual CandidateEntity Candidate { get; set; }
    }
}
