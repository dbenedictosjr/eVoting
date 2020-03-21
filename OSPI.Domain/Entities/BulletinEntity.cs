using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using OSPI.Domain.Interfaces;

namespace OSPI.Domain.Entities
{
    public class BulletinEntity : IAuditableEntity
    {
        [Key]
        public Guid BulletinId { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime DatePosted { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        public string Title { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string Description { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string ImageName { get; set; }

        public Guid MemberId { get; set; }

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
    }
}
