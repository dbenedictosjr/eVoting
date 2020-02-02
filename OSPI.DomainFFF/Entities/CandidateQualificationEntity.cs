using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OSPI.Domain.Entities
{
    public class CandidateQualificationEntity : IAuditableRepository
    {
        [Key]
        public Guid CandidateQualificationID { get; set; }

        public Guid CandidateID { get; set; }

        public Guid QualificationID { get; set; }

        public byte[] Qualified { get; set; }

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

        [ForeignKey("QualificationID")]
        public virtual QualificationEntity Qualification { get; set; }
    }
}
