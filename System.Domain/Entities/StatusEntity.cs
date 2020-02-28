using System.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Domain.Entities
{
    public class StatusEntity : IAuditableEntity
    {
        [Key]
        public Guid StatusID { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string StatusDescription { get; set; }

        [Column(TypeName = "varchar(25)")]
        public string Module { get; set; }

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
