using OSPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class DeletedRecordsEntity : IAuditableEntity
    {
        [Key]
        public Guid DeletedID { get; set; }

        public Guid? PrimaryID { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string SourceTable { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }
    }
}
