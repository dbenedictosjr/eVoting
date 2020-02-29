using OSPI.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSPI.Domain.Entities
{
    public class RoleAccessEntity : IAuditableEntity
    {
        [Key]
        public Guid RoleAccessId { get; set; }

        public Guid RoleId { get; set; }

        public Guid ModuleId { get; set; }

        public bool CanAdd { get; set; }

        public bool CanEdit { get; set; }

        public bool CanDelete { get; set; }

        public bool CanView { get; set; }

        public bool CanPrint { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime CreatedDate { get; set; }

        public Guid UpdatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime UpdatedDate { get; set; }

        [Timestamp()]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ModuleId")]
        public virtual ModuleEntity Module { get; set; }

        [ForeignKey("RoleId")]
        public virtual RoleEntity Role { get; set; }
    }
}